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
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public ProductVM GetById(int id)
        {
            var pro = _productRepository.GetById(id);

            return ProjectMapper.ConvertToVM<ProductVM>(pro);
        }

        public IEnumerable<ProductVM> GetAll()
        {
            var pros = _productRepository.GetAll;

            return ProjectMapper.ConvertToVMList<IEnumerable<ProductVM>>(pros); ;
        }

        public void Insert(ProductVM model)
        {
            _productRepository.Insert(ProjectMapper.ConvertToEntity<Product>(model));
        }

        public void Update(ProductVM model)
        {
            _productRepository.Update(ProjectMapper.ConvertToEntity<Product>(model));
        }

        public IEnumerable<ProductVM> GetAllIncluding()
        {
            var pros = _productRepository.GetAllIncluding("ProductDetails, ProductPictures");

            return ProjectMapper.ConvertToVMList<IEnumerable<ProductVM>>(pros); ;
        }
    }
}
