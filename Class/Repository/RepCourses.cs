using System.Collections.Generic;
using School.Class.Domain;

namespace Escola.Class.Repository
{
    public class RepCourses
    {
        public List<Courses> CoursesList()
        {
            return new List<Courses>()
            {
                new Courses {Id = 1, Title = "Auxiliar Office"},
                new Courses {Id = 2, Title = "Business Plan"},
                new Courses {Id = 3, Title = "Depilation"},
                new Courses {Id = 4, Title = "Facil Depilation with Line"},
                new Courses {Id = 5, Title = "Basic in Exterior Business"},
                new Courses {Id = 6, Title = "Exportation:Rotinas e Procedures"},
                new Courses {Id = 7, Title = "Html5 e CSS3"},
                new Courses {Id = 8, Title = "Sketchup Pro"},
                new Courses {Id = 9, Title = "How to Speak in Public"},
                new Courses {Id = 10, Title = "Digital Pulicity and Interactive"},
                new Courses {Id = 11, Title = "Internal Comunication and Endomarketing"},
                new Courses {Id = 12, Title = "The Art to Make Parties and Thematic Events"},
            };
        }
    }
}