using Microsoft.EntityFrameworkCore;

namespace Booker.Models
{
    public class Item
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        [Precision(10,2)]
        public decimal Price { get; set; }
        public DateTime DateAdded { get; set; }
        public string State { get; set; }
        public string Description {  get; set; }
        public string Photo {  get; set; }

        public Book Book { get; set; }
        

    }
}
