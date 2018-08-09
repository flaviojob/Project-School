using System;
using System.Collections.Generic;
using School.Class.Domain;

namespace Escola.Class.Repository
{
    public class RepDates
    {
        public List<Dates> DatesList()
        {
            return new List<Dates>
            {
                new Dates{Id = 1, Begin = DateTime.Parse("09/08/2018"), Conclusion = DateTime.Parse("12/10/2018")},
                new Dates{Id = 2, Begin = DateTime.Parse("05/08/2018"), Conclusion = DateTime.Parse("20/08/2018")},
                new Dates{Id = 3, Begin = DateTime.Parse("20/09/2018"), Conclusion = DateTime.Parse("10/10/2018")}
            };
        }
    }
}