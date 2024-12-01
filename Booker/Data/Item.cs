using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booker.Data
{
    public class Item : Book
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("BookId")]
        public int BookId { get; set; }
        [ForeignKey("UserId")]
        public int UserID { get; set; }
        public decimal Price { get; set; }
        public DateTime DateTime { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Photo {  get; set; }
    }
}
