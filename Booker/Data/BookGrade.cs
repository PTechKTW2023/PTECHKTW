namespace Booker.Data
{
    public class BookGrade
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
