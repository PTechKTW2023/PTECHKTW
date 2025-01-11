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

        public record PagedListViewModel(List<Booker.Data.Item> Items, int Page);

        public PagedListViewModel? ItemsList { get; set; }

        public IndexModel(ILogger<IndexModel> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int page = 0)
        {
            const int PageSize = 25;

            var items = await _context.Items
                .Include(i => i.Book).ThenInclude(b => b.BookGrades).ThenInclude(bg => bg.Grade)
                .Include(i => i.User)
                .OrderBy(i => i.DateTime)
                .Skip(page * PageSize)
                .Take(PageSize)
                .ToListAsync();

            ItemsList = new PagedListViewModel(items, page);

            return Page();
        }
    }
}
