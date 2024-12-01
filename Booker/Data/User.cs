using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booker.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public  string Email { get; set; }
        //We didn't know what to use. Let us know and change if there is a better option.
        public HashCode Password { get; set; }
        [Required]
        public  string Nickname { get; set; }
        [Required]
        [ForeignKey("School")]
        public  string School { get; set; }
        public string? Photo {  get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
