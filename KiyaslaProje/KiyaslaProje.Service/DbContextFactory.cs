using KiyaslaProje.Domain.Interfaces;
using KiyaslaProje.Infrasturcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Service
{
    public class DbContextFactory
    {
        public static IDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
