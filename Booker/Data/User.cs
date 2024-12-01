using System.ComponentModel.DataAnnotations;

namespace Booker.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public required string Email { get; set; }
        //We didn't know what to use. Let us know and change if there is a better option.
        public HashCode Password { get; set; }
        public required string Nickname { get; set; }
        public required string School { get; set; }
        public string? Photo {  get; set; }

    }
}
