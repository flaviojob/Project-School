using School.Class.Domain;

namespace Escola.Class.Domain
{
    public class Oferts
    {
        public int Id { get; set; } 
        public Areas Area { get; set; } 
        public Courses Course {get; set; }
        public Dates Date { get; set; }
        public Weekday Weekday { get; set; }
        public Hourly Hourly { get; set; }

        public Oferts()
        {
            
        }
        public Oferts(int id, Areas area, Courses course, Dates date, Weekday weekday, Hourly hourly)
        {
            this.Id = id;
            this.Area = area;
            this.Course = course;
            this.Date = date;
            this.Weekday = weekday;
            this.Hourly = hourly;
        }
    }
}