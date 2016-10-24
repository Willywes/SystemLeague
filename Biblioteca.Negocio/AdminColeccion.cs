using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class AdminColeccion
    {
        private List<Admin> GenerarLista(List<DALC.Admin> adminDALC)
        {
            List<Admin> admin = new List<Admin>();

            foreach (DALC.Admin item in adminDALC)
            {
                Negocio.Admin admin1 = new Admin();
                admin1.Id = item.Id;
                admin1.Nick = item.Nick;
                admin1.FechaRegistro = item.FechaRegistro;
                admin1.Email = item.Email;
                

                admin.Add(admin1);
            }
            return admin;
        }

        public List<Admin> ReadAll()
        {
            var admin = CommonBC.SystemLeagueEntities.Admin;
            return GenerarLista(admin.ToList());
        }

}
