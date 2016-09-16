using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Player : Class
    {

        public string UserName { get; set; }
        public string Pass { get; set; }
        public Team Team { get; set; } // solo uno
        

        public Player(int id, string userName, string pass, string nombre, Team team, DateTime fechaCreacion) : base(id, nombre, fechaCreacion)
        {
            this.UserName = userName;
            this.Pass = pass;
            this.Team = Team;
        }

        public void asignarTeam(Team team)
        {
            this.Team = team;
        }
    }
}
