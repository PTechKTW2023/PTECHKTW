using System.ComponentModel.DataAnnotations;

namespace Booker.Data
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        //Should it be string or char for now?
        [Required]
        public string Grade { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public bool Level { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
