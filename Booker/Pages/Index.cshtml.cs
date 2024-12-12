using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Booker.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public record PagedListViewModel(List<Booker.Data.Item> Items, int Page);
    private const int PageSize = 25;
    public PagedListViewModel ItemsList { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        // TODO: remove this sample data and get real data from database (#13)
        var book = new Booker.Data.Book
        {
            Id = 1,
            Title = "Książka",
            Grade = "L1",
            Subject = "Matematyka",
            Level = false
        };

        var user = new Booker.Data.User
        {
            Id = 1,
            Nickname = "Franx",
            School = "ŚlTZN"
        };

        var item = new Booker.Data.Item
        {
            Id = 1,
            BookId = book.Id,
            Book = book,
            UserID = user.Id,
            User = user,
            DateTime = DateTime.Today,
            Price = 21.37M,
            Description = "Lorem ipsum",
            State = "Jak nowa",
            Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
        };

        var items = new List<Booker.Data.Item>();

        for (int i = 0; i < PageSize; i++)
        {
            items.Add(item);
            item.Id++;
        }

        ItemsList = new PagedListViewModel(items, 0);

    }

    public void OnGet()
    {
    }
}