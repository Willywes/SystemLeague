using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class TorneoColeccion
    {
        private List<Torneo> GenerarLista(List<DALC.Torneo> torneoDALC)
        {
            List<Torneo> torneo = new List<Torneo>();

            foreach (DALC.Torneo item in torneoDALC)
            {
                Negocio.Torneo torneo1 = new Torneo();
                torneo1.Id = item.Id;
                torneo1.Nombre = item.Nombre;
                torneo1.IdLiga = item.IdLiga;

                torneo.Add(torneo1);
            }
            return torneo;
        }

        public List<Torneo> ReadAll()
        {
            var torneo = CommonBC.SystemLeagueEntities.Torneo;
            return GenerarLista(torneo.ToList());
        }
    }
}
