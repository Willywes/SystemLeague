﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class Team
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdLiga { get; set; }

        public Team()
        {
            Init();
        }

        private void Init()
        {
            Id = 0;
            Nombre = string.Empty;
            IdLiga = 0;
        }

        //crud

        public bool Create()
        {
            try
            {
                DALC.Team team = new DALC.Team();
                team.Id = Id;
                team.Nombre = Nombre;
                team.IdLiga = IdLiga;
                CommonBC.SystemLeagueEntities.Team.Add(team);
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
                DALC.Team team = CommonBC.SystemLeagueEntities.Team.First(t => t.Id == Id);
                Id = team.Id;
                Nombre = team.Nombre;
                IdLiga = team.IdLiga;
                CommonBC.SystemLeagueEntities.Team.Add(team);
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
                DALC.Team team = CommonBC.SystemLeagueEntities.Team.First(t => t.Id == Id);
                team.Nombre = Nombre;
                team.IdLiga = IdLiga;
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
                DALC.Team team = CommonBC.SystemLeagueEntities.Team.First(t => t.Id == Id);
                CommonBC.SystemLeagueEntities.Team.Remove(team);
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


