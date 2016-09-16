using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Team : Class
    {

        public Player PlayerAdmin { get; set; }
        public string PassTeam { get; set; }
        public List<Player> ListaJugadores { get; set; }

        public Team(int id, string nombre, DateTime fechaCreacion, Player playerAdmin, string passTeam) : base(id, nombre, fechaCreacion)
        {
            this.PlayerAdmin = playerAdmin;
            this.PassTeam = passTeam;
            ListaJugadores = new List<Player>();
        }

        public string agregarJugadores(Player player)
        {
            if (ListaJugadores.Count < 7)
            {
                foreach (var item in ListaJugadores)
                {
                    if (item.Id == player.Id)
                    {
                        return "Uds ya esta en este team";
                    }
                }
                //if (player.Team != null )
                //{
                //    return "Ud. ya pertence a otro team";
                //}

                ListaJugadores.Add(player);
                
                return string.Format("Jugador {0} agregadado", player.Nombre.ToString());
                
            }
            
            return "Team lleno";
        }

        
        
    }
}
