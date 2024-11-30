using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Booker.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public record PagedListViewModel(List<Booker.Models.Item> Items, int Page);
    private const int PageSize = 25;
    public PagedListViewModel ItemsList { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        var book = new Booker.Models.Book
        {
            ID = 1,
            Title = "Książka",
            Grade = "L1",
            Subject = "Matematyka",
            Level = false
        };

        var item = new Booker.Models.Item
        {
            ID = 1,
            BookID = book.ID,
            Book = book,
            DateAdded = DateTime.Today,
            Price = 21.37M,
            Description = "Lorem ipsum",
            State = "Jak nowa",
            Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
        };

        var items = new List<Booker.Models.Item>();

        for (int i = 0; i < PageSize; i++)
        {
            items.Add(item);
            item.ID++;
        }

        ItemsList = new PagedListViewModel(items, 0);

    }

    public void OnGet()
    {
    }
}