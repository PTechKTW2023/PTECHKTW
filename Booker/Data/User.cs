using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booker.Data
{
    public class User
    {
        
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
        [Required]
        public string Nickname { get; set; }
        [Required]
        public string School { get; set; }
        public string? Photo {  get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
