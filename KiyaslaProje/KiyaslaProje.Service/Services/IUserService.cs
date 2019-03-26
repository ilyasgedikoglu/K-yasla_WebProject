using KiyaslaProje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Service.Services
{
    public interface IUserService
    {
        IEnumerable<ApplicationUser> GetAll();
        void Delete(ApplicationUser model);

    }
}
