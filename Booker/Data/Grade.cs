namespace Booker.Data
{
    public class Grade
    {
        public string Id { get; set; }
        public string GradeNumber { get; set; }

        public ICollection<BookGrade> BookGrades { get; set; }
    }
}
