using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class Torneo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Torneo()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre = string.Empty;

        }

        //crud

        public bool Create()
        {
            try
            {
                DALC.Torneo torneo = new DALC.Torneo();
                torneo.Id = Id;
                torneo.Nombre = Nombre;
                CommonBC.SystemLeagueEntities.Torneo.Add(torneo);
                CommonBC.SystemLeagueEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Read()
        {
            try
            {
                DALC.Torneo torneo = CommonBC.SystemLeagueEntities.Torneo.First(t => t.Id == Id);
                Id = torneo.Id;
                Nombre = torneo.Nombre;
                CommonBC.SystemLeagueEntities.Torneo.Add(torneo);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update()
        {
            try
            {
                DALC.Torneo torneo = CommonBC.SystemLeagueEntities.Torneo.First(t => t.Id == Id);
                torneo.Nombre = Nombre;
                CommonBC.SystemLeagueEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                DALC.Torneo torneo = CommonBC.SystemLeagueEntities.Torneo.First(t => t.Id == Id);
                CommonBC.SystemLeagueEntities.Torneo.Remove(torneo);
                CommonBC.SystemLeagueEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
