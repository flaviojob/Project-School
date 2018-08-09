using System;

namespace School.Class.Domain
{
    public class Dates
    {
        public int Id { get; set; }
        public DateTime Begin { get; set; }
        public DateTime Conclusion { get; set; }
        public Dates()
        {

        }
        public Dates(int id, DateTime begin, DateTime conclusion)
        {
            this.Id = id;
            this.Begin = begin;
            this.Conclusion = conclusion;
        }
    }
}