using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class Liga
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdTeam { get; set; }

        public Liga()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre = string.Empty;
            IdTeam = 0;
        }

        //crud

        public bool Create()
        {
            try
            {
                DALC.Liga liga = new DALC.Liga();
                liga.Id = Id;
                liga.Nombre = Nombre;
                liga.IdTeam = IdTeam;
                CommonBC.SystemLeagueEntities.Liga.Add(liga);
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
                DALC.Liga liga = CommonBC.SystemLeagueEntities.Liga.First(t => t.Id == Id);
                Id = liga.Id;
                Nombre = liga.Nombre;
                IdTeam = liga.IdTeam;
                CommonBC.SystemLeagueEntities.Liga.Add(liga);
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
                DALC.Liga liga = CommonBC.SystemLeagueEntities.Liga.First(t => t.Id == Id);
                liga.Nombre = Nombre;
                liga.IdTeam = IdTeam;
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
                DALC.Liga liga = CommonBC.SystemLeagueEntities.Liga.First(t => t.Id == Id);
                CommonBC.SystemLeagueEntities.Liga.Remove(liga);
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
