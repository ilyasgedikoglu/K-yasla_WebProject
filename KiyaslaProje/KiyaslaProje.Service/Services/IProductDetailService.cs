using KiyaslaProje.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Service.Services
{
    public interface IProductDetailService
    {
        IEnumerable<ProductDetailVM> GetAll();
        ProductDetailVM GetById(int id);
        void Insert(ProductDetailVM model);
        void Delete(int id);
        void Update(ProductDetailVM model);
        IEnumerable<ProductDetailVM> GetAllIncluding();
    }
}
