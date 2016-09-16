using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Team : Class
    {
        public Team(int id, string nombre, DateTime fechaCreacion) : base(id, nombre, fechaCreacion)
        {
        }

        private int IdAdmin { get; set; }
    }
}
