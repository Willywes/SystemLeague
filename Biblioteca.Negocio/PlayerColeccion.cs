using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class PlayerColeccion
    {
        private List<Player> GenerarLista(List<DALC.Player> playerDALC)
        {
            List<Player> player = new List<Player>();

            foreach (DALC.Player item in playerDALC)
            {
                Negocio.Player player1 = new Player();
                player1.Id = item.Id;
                player1.Nick = item.Nick;
                player1.FechaRegistro = item.FechaRegistro;
                player1.Email = item.Email;
                player1.IdTeam = item.IdTeam;

                player.Add(player1);
            }
            return player;
        }

        public List<Player> ReadAll()
        {
            var player = CommonBC.SystemLeagueEntities.Player;
            return GenerarLista(player.ToList());
        }

        public  int CantidadJugadoresPorTeam(int id_Team)
        {
           return CommonBC.SystemLeagueEntities.Player.Count(p => p.IdTeam == id_Team);
        }

        public List<Player> ListarJugadoresPorTeam(int id_Team)
        {
            var player = CommonBC.SystemLeagueEntities.Player.Where(p => p.IdTeam == id_Team);
            return GenerarLista(player.ToList());
        }
        public void ComprobarLimiteTeam(int id_Team)
        {
            if (CantidadJugadoresPorTeam(int id_Team) == 7)
            {
                throw new ArgumentException("Capacidad máxima del team completa.");
            }
        }
    }
}
}
