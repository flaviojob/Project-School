using System.Collections.Generic;
using School.Class.Domain;

namespace Escola.Class.Repository
{
    public class RepWeekday
    {
        public List<Weekday> WeekdayList()
        {
            return new List<Weekday>()
            {
                new Weekday {Id = 1, Day = "2ª-4ª-6ª"},
                new Weekday {Id = 2, Day = "3ª-5ª"},
                new Weekday {Id = 3, Day = "2ª-3ª-4ª-5ª-6ª"},
                new Weekday {Id = 4, Day = "Sábado"}
            };
        }
    }
}