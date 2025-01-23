using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booker.Data
{
    public class Item
    {
        public int Id { get; set; }
        public int BookId { get; set; }        
        public Book Book { get; set; }
        public int UserId { get; set; }    
        public User User { get; set; }
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
