using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KiyaslaProje.Common.Mappers;
using KiyaslaProje.Common.ViewModels;
using KiyaslaProje.Domain.Entities;
using KiyaslaProje.Domain.Interfaces;

namespace KiyaslaProje.Service.Services
{
    public class ProductPictureService : IProductPictureService
    {
        private readonly IRepository<ProductPicture> _productPictureRepository;

        public ProductPictureService(IRepository<ProductPicture> productPictureRepository)
        {
            _productPictureRepository = productPictureRepository;
        }

        public void Delete(int id)
        {
            _productPictureRepository.Delete(id);
        }

        public IEnumerable<ProductPictureVM> GetAll()
        {
            var props = _productPictureRepository.GetAll;

            return ProjectMapper.ConvertToVMList<IEnumerable<ProductPictureVM>>(props);
        }

        public IEnumerable<ProductPictureVM> GetAllIncluding()
        {
            var props = _productPictureRepository.GetAllIncluding("Products");

            return ProjectMapper.ConvertToVMList<IEnumerable<ProductPictureVM>>(props);
        }

        public ProductPictureVM GetById(int id)
        {
            var prop = _productPictureRepository.GetById(id);

            return ProjectMapper.ConvertToVM<ProductPictureVM>(prop);
        }

        public void Insert(ProductPictureVM model)
        {
            _productPictureRepository.Insert(ProjectMapper.ConvertToEntity<ProductPicture>(model));
        }

        public void Update(ProductPictureVM model)
        {
            _productPictureRepository.Update(ProjectMapper.ConvertToEntity<ProductPicture>(model));
        }
    }
}
