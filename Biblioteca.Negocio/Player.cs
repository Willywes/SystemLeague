using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class Player
    {
        public int Id { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdTeam { get; set; }

        public Player()
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
            IdTeam = 0;
        }

        //crud

        public bool Create()
        {
            try
            {
                DALC.Player p = new DALC.Player();

                p.Id = Id;
                p.Nick = Nick;
                p.Email = Email;
                p.Pass = Pass;
                p.FechaRegistro = FechaRegistro;
                p.IdTeam = IdTeam;

                CommonBC.SystemLeagueEntities.Player.Add(p);
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
                DALC.Player p = CommonBC.SystemLeagueEntities.Player.First(r => r.Id == Id);

                Id = p.Id;
                Nick = p.Nick;
                Email = p.Email;
                Pass = p.Pass;
                FechaRegistro = p.FechaRegistro;
                IdTeam = p.IdTeam;

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
                DALC.Player p = CommonBC.SystemLeagueEntities.Player.First(r => r.Id == Id);

                Nick = p.Nick;
                Email = p.Email;
                Pass = p.Pass;
                IdTeam = p.IdTeam;

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
                DALC.Player p = CommonBC.SystemLeagueEntities.Player.First(r => r.Id == Id);

                CommonBC.SystemLeagueEntities.Player.Remove(p);
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
