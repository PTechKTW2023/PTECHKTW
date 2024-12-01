using System.ComponentModel.DataAnnotations;

namespace Booker.Data
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
       
        public required string Title { get; set; }
        //Should it be string or char for now?
        public required char[] Grade { get; set; }
        public required string Subject { get; set; }
        public required bool Level { get; set; }
    }
}
