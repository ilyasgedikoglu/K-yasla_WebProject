using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KiyaslaProje.Domain.Entities;
using KiyaslaProje.Domain.Interfaces;

namespace KiyaslaProje.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<ApplicationUser> _userRepository;

        public UserService(IRepository<ApplicationUser> userRepository)
        {
            _userRepository = userRepository;
        }

        public void Delete(ApplicationUser model)
        {
            _userRepository.Delete(model);
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            var users = _userRepository.GetAll;

            return users;
        }
    }
}
