using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ListaJugador :List<Jugador>
    {
        public static int count { get; set; }
        public ListaJugador()
        {
            count = 100;
        }
        public Jugador CargarJugador(ListaJugador lista, string nickname)
        {
            
            if (lista.Exists(n => n.Nickname.Equals(nickname)))
            {
                foreach (var item in lista)
                {
                    if (item.Nickname.Equals(nickname))
                    {
                        return item;
                    }
                }
            }
            return null;
        }
            
        public bool ComprobarNick(ListaJugador Lista, string nickname)
        {
            if (Lista.Exists(n => n.Nickname.Equals(nickname)))
            {
                return true;
            }
            return false;
        }

        public bool Eliminar(ListaJugador Coleccion,
           string nick)
        {
            if (Coleccion.Exists(c => c.Nickname.Equals(nick)))
            {
                Coleccion.Remove(Coleccion.First(n => n.Nickname.Equals(nick)));
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Modificar(ListaJugador Coleccion,
            string nickname, string password, string email)
        {
            if (Coleccion.Exists(c => c.Nickname.Equals(nickname)))
            {
                Coleccion.First(n => n.Nickname.Equals(nickname)).Nickname = nickname;
                Coleccion.First(n => n.Nickname.Equals(nickname)).Mail = email;
                Coleccion.First(n => n.Nickname.Equals(nickname)).Contrasena = password;
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
