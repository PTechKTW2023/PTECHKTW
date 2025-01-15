﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Booker.Data
{
    public class User : IdentityUser
    {
        [Required]
        public string School { get; set; }
        public string? Photo {  get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
