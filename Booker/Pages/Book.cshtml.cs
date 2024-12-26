using Booker.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Booker.Pages
{
    public class BookModel : PageModel
    {
        private readonly DataContext _context;

        public Item? BookItem { get; set; }

        public BookModel(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            BookItem = await _context.Items
                .Include(i => i.Book)
                .Include(i => i.User)
                .FirstOrDefaultAsync(i => i.Id == id);

            if (BookItem == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
