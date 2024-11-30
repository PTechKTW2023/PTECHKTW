using System.ComponentModel.DataAnnotations.Schema;

namespace Booker.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }

        //[Column(TypeName = "char(2)")]
        public string Grade { get; set; }
        public string Subject { get; set; }
        public bool? Level { get; set; }

        public ICollection<Item> Items { get; set; }

        public string GradeFullName()
        {
            var type = "";
            if (Grade[0] == 'L')
                type = "liceum/technikum";
            else if (Grade[0] == 'S')
                type = "rok studiów";

            return Grade[1] + ". " + type;
        }

        public string LevelFullName()
        {
            if (!Level.HasValue)
                return "";
            if (Level.Value)
                return "Rozszerzony";
            return "Podstawowy";
        }
    }
}
