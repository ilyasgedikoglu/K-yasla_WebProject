using KiyaslaProje.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Service.Services
{
    public interface IProductPictureService
    {
        IEnumerable<ProductPictureVM> GetAll();
        ProductPictureVM GetById(int id);
        void Insert(ProductPictureVM model);
        void Delete(int id);
        void Update(ProductPictureVM model);
        IEnumerable<ProductPictureVM> GetAllIncluding();
    }
}
