using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Temporada : Class
    {

        public Liga Liga { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaClausura { get; set; }

        public Temporada(int id, string nombre, DateTime fechaCreacion, Liga liga, DateTime fechaInicio, DateTime fechaClausura) : base(id, nombre, fechaCreacion)
        {
            this.Liga = liga;
            this.FechaCreacion = fechaCreacion;
            this.FechaClausura = fechaClausura;
        }


    }
}
