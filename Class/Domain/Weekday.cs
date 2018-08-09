namespace School.Class.Domain
{
    public class Weekday
    {
        public int Id { get; set; } 
        public string Day { get; set; } 
        public Weekday()
        {

        }
        public Weekday (int id, string day)
        {
            this.Id = id;
            this.Day = day;
        }
    }
}