using Booker.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Booker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DataContext _context;
        const int PageSize = 25;

        public record PagedListViewModel(List<Item> Items, int Page, bool HasMorePages);

        public PagedListViewModel? ItemsList { get; set; }
        public string? Search { get; set; }
        public string? Grade { get; set; }
        public string? Subject { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public string? Level { get; set; }

        public IndexModel(ILogger<IndexModel> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int pageNumber = 0, string? search = null, string? grade = null, string? subject = null, decimal? minPrice = null, decimal? maxPrice = null, string? level = null)
        {
            Search = search;
            Grade = grade;
            Subject = subject;
            MinPrice = minPrice;
            MaxPrice = maxPrice;
            Level = level;

            var query = _context.Items
                .Include(i => i.Book).ThenInclude(b => b.BookGrades).ThenInclude(bg => bg.Grade)
                .Include(i => i.User)
                .AsQueryable();

            query = ApplyFilters(query, search, grade, subject, minPrice, maxPrice, level);

            var totalItems = await query.CountAsync();
            bool hasMorePages = totalItems > (pageNumber + 1) * PageSize;

            var items = await query
                .OrderBy(i => i.DateTime)
                .Skip(pageNumber * PageSize)
                .Take(PageSize)
                .ToListAsync();

            ItemsList = new PagedListViewModel(items, pageNumber, hasMorePages);

            if (Request.Headers["HX-Request"] == "true")
            {
                return Partial("_ItemGallery", ItemsList);
            }
            return Page();
        }

        private IQueryable<Item> ApplyFilters(IQueryable<Item> query, string? search, string? grade, string? subject, decimal? minPrice, decimal? maxPrice, string? level)
        {
            if (!string.IsNullOrWhiteSpace(search))
            {
                string lowerSearch = search.ToLower();
                query = query.Where(i => EF.Functions.Like(i.Book.Title.ToLower(), $"%{lowerSearch}%"));
            }

            if (!string.IsNullOrWhiteSpace(grade) && grade != "Wszystkie klasy")
            {
                string parsedGrade = grade.Replace("Klasa ", "").TrimEnd('.').Trim();
                query = query.Where(i => i.Book.BookGrades.Any(bg => bg.Grade.GradeNumber.Contains(parsedGrade)));
            }

            if (!string.IsNullOrWhiteSpace(subject) && subject != "Wszystkie przedmioty")
            {
                query = query.Where(i => i.Book.Subject == subject);
            }

            if (minPrice.HasValue)
            {
                query = query.Where(i => i.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                query = query.Where(i => i.Price <= maxPrice.Value);
            }

            if (!string.IsNullOrWhiteSpace(level) && level != "Wszystkie poziomy")
            {
                bool isBase = level.ToLower() == "podstawa";
                query = query.Where(i => i.Book.Level == isBase);
            }

            return query;
        }
    }
}