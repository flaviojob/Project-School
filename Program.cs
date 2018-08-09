using System;
using Escola.Class.Repository;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oferts Avaible!");
            Console.WriteLine("--------------------------");
            RepOferts rp = new RepOferts();
            var lst = rp.OfertsList();
            foreach( var i in lst)
            {
                Console.WriteLine
                (
                    i.Area.Title+"\n"+
                    i.Course.Title+"\n"+
                    i.Date.Begin.ToShortDateString()+" a "+i.Date.Conclusion.ToLongDateString()+"\t"+
                    i.Weekday.Day+"\t"+
                    i.Hourly.Enter.ToShortTimeString()+" às"+i.Hourly.Exit.ToLongTimeString()

                );
            }
        }
    }
}
