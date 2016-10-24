using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class Admin
    {
        public int Id { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Admin()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nick = string.Empty;
            Email = string.Empty;
            Pass = string.Empty;
            FechaRegistro = DateTime.Now;
        }

        //crud

        public bool Create()
        {
            try
            {
                DALC.Admin p = new DALC.Admin();

                p.Id = Id;
                p.Nick = Nick;
                p.Email = Email;
                p.Pass = Pass;
                p.FechaRegistro = FechaRegistro;

                CommonBC.SystemLeagueEntities.Admin.Add(p);
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
                DALC.Admin p = CommonBC.SystemLeagueEntities.Admin.First(r => r.Id == Id);

                Id = p.Id;
                Nick = p.Nick;
                Email = p.Email;
                Pass = p.Pass;
                FechaRegistro = p.FechaRegistro;

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
                DALC.Admin p = CommonBC.SystemLeagueEntities.Admin.First(r => r.Id == Id);

                Nick = p.Nick;
                Email = p.Email;
                Pass = p.Pass;

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
                DALC.Admin p = CommonBC.SystemLeagueEntities.Admin.First(r => r.Id == Id);

                CommonBC.SystemLeagueEntities.Admin.Remove(p);
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
