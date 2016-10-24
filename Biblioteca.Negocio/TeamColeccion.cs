using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class TeamColeccion
    {
        private List<Team> GenerarLista(List<DALC.Team> teamDALC)
        {
            List<Team> team = new List<Team>();

            foreach (DALC.Team item in teamDALC)
            {
                Negocio.Team team1 = new Team();
                team1.Id = item.Id;
                team1.Nombre = item.Nombre;
                team1.IdLiga = item.IdLiga;

                team.Add(team1);
            }
            return team;
        }

        public List<Team> ReadAll()
        {
            var team = CommonBC.SystemLeagueEntities.Team;
            return GenerarLista(team.ToList());
        }

        public int CantidadTeamPorLiga(int Id_Liga)
        {
            return CommonBC.SystemLeagueEntities.Team.Count(p => p.IdLiga == Id_Liga);
        }

        public List<Team> ListarTeamPorLiga(int Id_Liga)
        {
            var teams = CommonBC.SystemLeagueEntities.Team.Where(p => p.IdLiga == Id_Liga);
            return GenerarLista(teams.ToList());
        }

        
    }
}
