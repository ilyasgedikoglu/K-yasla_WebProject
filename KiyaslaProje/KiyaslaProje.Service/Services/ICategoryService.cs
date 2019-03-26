using KiyaslaProje.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Service.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryVM> GetAll();
        CategoryVM GetById(int id);
        void Insert(CategoryVM model);
        void Delete(int id);
        void Update(CategoryVM model);
        IEnumerable<CategoryVM> GetAllIncluding();
    }
}
