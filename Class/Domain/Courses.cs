namespace School.Class.Domain
{
    public class Courses
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public Courses()
        {

        }
        public Courses(int id, string title)
        {
            this.Id = id;
            this.Title = title;
        }
    }
}