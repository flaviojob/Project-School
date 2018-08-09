using System;

namespace School.Class.Domain
{
    public class Hourly
    {
        public int Id { get; set; } 
        public DateTime Enter { get; set; }   
        public DateTime Exit { get; set; }
        public Hourly()
        {

        }
        public Hourly(int id, DateTime enter, DateTime exit)
        {
            this.Id = id;
            this.Enter = enter;
            this.Exit = exit;
        }
    }
}