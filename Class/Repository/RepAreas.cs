using System.Collections.Generic;
using School.Class.Domain;

namespace Escola.Class.Repository
{
    public class RepAreas
    {
        public List<Areas> AreasList(){
                return new List<Areas>()
                {
                    new Areas{Id = 1, Title = "Geral Administration"},
                    new Areas{Id = 2, Title = "Estetic"},
                    new Areas{Id = 3, Title = "Exterior Business"},
                    new Areas{Id = 4, Title = "Grafic Computation and Internet"},
                    new Areas{Id = 5, Title = "Social Comunication"},
                    new Areas{Id = 6, Title = "Lounge"}
                };
        }
    }
}