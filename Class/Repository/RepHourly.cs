using System;
using System.Collections.Generic;
using School.Class.Domain;

namespace Escola.Class.Repository
{
    public class RepHourly
    {
        public List<Hourly> HourlyList()
        {
                return new List<Hourly>()
                {
                    new Hourly {Id = 1, Enter = DateTime.Parse("8:30"), Exit = DateTime.Parse("12:30")},
                    new Hourly {Id = 2, Enter = DateTime.Parse("13:30"), Exit = DateTime.Parse("17:30")},
                    new Hourly {Id = 3, Enter = DateTime.Parse("19:00"), Exit = DateTime.Parse("22:30")},
                    new Hourly {Id = 1, Enter = DateTime.Parse("8:30"), Exit = DateTime.Parse("17:30")},
                };
        }
    }
}