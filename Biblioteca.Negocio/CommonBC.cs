using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DALC;

namespace Biblioteca.Negocio
{
    public class CommonBC
    {
        private static SystemLeagueEntities _systemLeagueEntities;

        public static SystemLeagueEntities SystemLeagueEntities
        {
            get
            {
                if (_systemLeagueEntities == null)
                {
                    _systemLeagueEntities = new SystemLeagueEntities();
                }
                return _systemLeagueEntities;
            }

        }
    }
}
