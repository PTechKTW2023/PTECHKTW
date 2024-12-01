using System.ComponentModel.DataAnnotations;

namespace Booker.Data
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        //Should it be string or char for now?
        [Required]
        public char[] Grade { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public bool Level { get; set; }
    }
}
