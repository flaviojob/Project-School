using System.Collections.Generic;
using Escola.Class.Domain;

namespace Escola.Class.Repository
{
    public class RepOferts
    {
        public List<Oferts> OfertsList()
        {
            return new List<Oferts>()
            {
                new Oferts
                    {Id = 1, 
                    Area = new RepAreas().AreasList()[0], 
                    Course = new RepCourses().CoursesList()[0], 
                    Date = new RepDates().DatesList()[0], 
                    Weekday = new RepWeekday().WeekdayList()[3], 
                    Hourly = new RepHourly().HourlyList()[1]},

                new Oferts
                    {Id = 2, 
                    Area = new RepAreas().AreasList()[0], 
                    Course = new RepCourses().CoursesList()[1], 
                    Date = new RepDates().DatesList()[0], 
                    Weekday = new RepWeekday().WeekdayList()[2], 
                    Hourly = new RepHourly().HourlyList()[2]},

                 new Oferts
                    {Id = 3, 
                    Area = new RepAreas().AreasList()[1], 
                    Course = new RepCourses().CoursesList()[0], 
                    Date = new RepDates().DatesList()[1], 
                    Weekday = new RepWeekday().WeekdayList()[1], 
                    Hourly = new RepHourly().HourlyList()[0]},
                
                new Oferts
                    {Id = 4, 
                    Area = new RepAreas().AreasList()[3], 
                    Course = new RepCourses().CoursesList()[0], 
                    Date = new RepDates().DatesList()[1], 
                    Weekday = new RepWeekday().WeekdayList()[0], 
                    Hourly = new RepHourly().HourlyList()[1]},


            };
        }
    }
}