using Booker.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Booker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DataContext _context;
        private readonly ICompositeViewEngine _viewEngine;
        private readonly ITempDataProvider _tempDataProvider;

        public record PagedListViewModel(List<Item> Items, int Page);

        public PagedListViewModel? ItemsList { get; set; }

        public IndexModel(ILogger<IndexModel> logger, DataContext context, ICompositeViewEngine viewEngine, ITempDataProvider tempDataProvider)
        {
            _logger = logger;
            _context = context;
            _viewEngine = viewEngine;
            _tempDataProvider = tempDataProvider;
        }

        public async Task<IActionResult> OnGetAsync(int page = 0)
        {
            const int PageSize = 25;

            var items = await _context.Items
                .Include(i => i.Book)
                .Include(i => i.User)
                .OrderBy(i => i.DateTime)
                .Skip(page * PageSize)
                .Take(PageSize)
                .ToListAsync();

            ItemsList = new PagedListViewModel(items, page);

            return Page();
        }

        public async Task<IActionResult> OnGetMoreAsync(int page)
        {
            const int PageSize = 25;

            var items = await _context.Items
                .Include(i => i.Book)
                .Include(i => i.User)
                .OrderBy(i => i.DateTime)
                .Skip(page * PageSize)
                .Take(PageSize)
                .ToListAsync();

            if (items == null || items.Count == 0)
            {
                return Content("<div class='end-of-list'>Wszystkie książki zostały załadowane.</div>", "text/html");
            }

            var renderedHtml = string.Empty;
            foreach (var item in items)
            {
                renderedHtml += await RenderPartialViewToStringAsync("_BookTile", item);
            }

            return Content(renderedHtml, "text/html");
        }

        private async Task<string> RenderPartialViewToStringAsync(string viewName, object model)
        {
            var viewResult = _viewEngine.FindView(PageContext, viewName, false);
            if (!viewResult.Success)
            {
                throw new InvalidOperationException($"Unable to find view '{viewName}'.");
            }

            var viewDictionary = new ViewDataDictionary(new EmptyModelMetadataProvider(), ModelState)
            {
                Model = model
            };

            var tempData = new TempDataDictionary(HttpContext, _tempDataProvider);

            using var output = new StringWriter();
            var viewContext = new ViewContext(PageContext, viewResult.View, viewDictionary, tempData, output, new HtmlHelperOptions());
            await viewResult.View.RenderAsync(viewContext);
            return output.ToString();
        }
    }
}
