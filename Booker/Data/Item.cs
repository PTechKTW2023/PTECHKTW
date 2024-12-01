using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booker.Data
{
    public class Item : Book
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserID { get; set; }
        public decimal Price { get; set; }
        public DateTime DateTime { get; set; }
        public required string Description { get; set; }
        public required string State { get; set; }
        public required string Photo {  get; set; }
    }
}
