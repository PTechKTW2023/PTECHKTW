namespace Booker.Data
{
    public class Grade
    {
        public int Id { get; set; }
        public string GradeNumber { get; set; }

        public ICollection<BookGrade> BookGrades { get; set; }
    }
}
