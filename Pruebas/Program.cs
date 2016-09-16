using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            // creando liga

            Liga ligaDuoc = new Liga(1, "Liga Duoc", DateTime.Now, "La Liga de Lol de Duoc");

            // temporada

            Temporada temporada1 = new Temporada(1, "Season #1", DateTime.Now, ligaDuoc, new DateTime(2016, 10, 1), new DateTime(2016, 11, 1));

            // 

            Player ale = new Player(12, "willywes", "1230", "Alejandro Isla", null,DateTime.Now);

            Player fabian = new Player(13, "fabiansito", "1230", "Fabian Isla", null, DateTime.Now);

            

            Team team1 = new Team(1, "Team 1", DateTime.Now, ale, "123");

            //ale.Team = team1;
            //fabian.Team = team1;

            //team1.ListaJugadores.Add(ale);
            //team1.ListaJugadores.Add(fabian);
          
            
            Console.WriteLine(team1.agregarJugadores(ale));
            Console.WriteLine(team1.agregarJugadores(ale));
            Console.WriteLine(team1.agregarJugadores(fabian));
            Console.WriteLine(team1.agregarJugadores(fabian));
            Console.WriteLine(team1.agregarJugadores(fabian));
            Console.WriteLine(team1.agregarJugadores(ale));
            Console.WriteLine(team1.agregarJugadores(ale));
            Console.WriteLine(team1.agregarJugadores(ale));
            Console.WriteLine(team1.agregarJugadores(ale));

            foreach (var i in team1.ListaJugadores)
            {
                Console.WriteLine(i.Id);
            }

            //Console.WriteLine(ale.Team.Nombre.ToString());
            //Console.WriteLine(fabian.Team.Nombre);

            Console.WriteLine(temporada1.Liga.Nombre);
            Console.WriteLine(temporada1.Liga.FechaCreacion);
            Console.WriteLine(temporada1.Nombre);
            Console.ReadKey();
        }
    }
}
