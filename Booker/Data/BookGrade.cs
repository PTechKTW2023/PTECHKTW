namespace Booker.Data
{
    public class BookGrade
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public string GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
