using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class LigaColeccion
    {
        private List<Liga> GenerarLista(List<DALC.Liga> ligaDALC)
        {
            List<Liga> liga = new List<Liga>();

            foreach (DALC.Liga item in ligaDALC)
            {
                Negocio.Liga liga1 = new Liga();
                liga1.Id = item.Id;
                liga1.Nombre = item.Nombre;
                liga1.IdTorneo = item.IdTorneo;
               

                liga.Add(liga1);
            }
            return liga;
        }

        public List<Liga> ReadAll()
        {
            var liga = CommonBC.SystemLeagueEntities.Liga;
            return GenerarLista(liga.ToList());
        }

        public int CantidadLigaPorTorneo(int Id_Torneo)
        {
            return CommonBC.SystemLeagueEntities.Liga.Count(p => p.IdTorneo == Id_Torneo);
        }

        public List<Liga> ListarLigaPorTorneo(int Id_Torneo)
        {
            var ligas = CommonBC.SystemLeagueEntities.Liga.Where(p => p.IdTorneo == Id_Torneo);
            return GenerarLista(ligas.ToList());
        }
    }
}
