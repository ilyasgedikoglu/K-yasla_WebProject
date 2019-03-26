using KiyaslaProje.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Service.Services
{
    public interface IProductService
    {
        IEnumerable<ProductVM> GetAll();
        ProductVM GetById(int id);
        void Insert(ProductVM model);
        void Delete(int id);
        void Update(ProductVM model);
        IEnumerable<ProductVM> GetAllIncluding();
    }
}
