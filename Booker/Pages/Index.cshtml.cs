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

        public record PagedListViewModel(List<Booker.Data.Item> Items, int Page);

        public PagedListViewModel? ItemsList { get; set; }

        public IndexModel(ILogger<IndexModel> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int pageNumber = 0)
        {
            var items = await _context.Items
                .Include(i => i.Book).ThenInclude(b => b.BookGrades).ThenInclude(bg => bg.Grade)
                .Include(i => i.User)
                .OrderBy(i => i.DateTime)
                .Skip(pageNumber * PageSize)
                .Take(PageSize)
                .ToListAsync();

            ItemsList = new PagedListViewModel(items, pageNumber);

            return Page();
        }

        public async Task<IActionResult> OnGetMoreAsync(int pageNumber)
        {
            int index = pageNumber * PageSize;
            if (index >= await _context.Items.CountAsync())
            {
                return new NoContentResult();
            }

            var items = await _context.Items
                .Include(i => i.Book).ThenInclude(b => b.BookGrades).ThenInclude(bg => bg.Grade)
                .Include(i => i.User)
                .OrderBy(i => i.DateTime)
                .Skip(index)
                .Take(PageSize)
                .ToListAsync();

            ItemsList = new PagedListViewModel(items, pageNumber);

            return Partial("_ItemGallery", ItemsList);
        }
    }
}
