using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Contrasena { get; set; }
        public string Mail { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdTeam { get; set; }

        public Jugador()
        {
            Init();
        }

        public Jugador(int id, string nickname, string contrasena, string mail)
        {
            Id = id;
            Nickname = nickname;
            Contrasena = contrasena;
            Mail = mail;
            FechaRegistro = DateTime.Now;
            IdTeam = -1;
        }

        private void Init()
        {
            Id = 0;
            Nickname = string.Empty;
            Contrasena = string.Empty;
            Mail = string.Empty;
            FechaRegistro = DateTime.Now;
            IdTeam = -1; // -1 es ningun team
        }
    }
}
