﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booker.Data
{
    public class Book
    {         
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public ICollection<BookGrade> BookGrades { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public bool Level { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
