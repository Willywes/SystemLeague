using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Class
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Class(int id, string nombre, DateTime fechaCreacion)
        {
            Id = id;
            Nombre = nombre;
            FechaCreacion = fechaCreacion;
        }


    }
}
