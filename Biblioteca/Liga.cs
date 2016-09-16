using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Liga : Class
    {
        public string Descripcion { get; set; }

        public Liga(int id, string nombre, DateTime fechaCreacion, string descripcion) : base (id, nombre, fechaCreacion)
    {
            this.Descripcion = descripcion;
        }

    }
}
