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
    public class ProductDetailService : IProductDetailService
    {
        private readonly IRepository<ProductDetail> _productDetailRepository;

        public ProductDetailService(IRepository<ProductDetail> productDetailRepository)
        {
            _productDetailRepository = productDetailRepository;
        }

        public void Delete(int id)
        {
            _productDetailRepository.Delete(id);
        }

        public IEnumerable<ProductDetailVM> GetAll()
        {
            var prods = _productDetailRepository.GetAll;

            return ProjectMapper.ConvertToVMList<IEnumerable<ProductDetailVM>>(prods);
        }

        public IEnumerable<ProductDetailVM> GetAllIncluding()
        {
            var prods = _productDetailRepository.GetAllIncluding("Product");

            return ProjectMapper.ConvertToVMList<IEnumerable<ProductDetailVM>>(prods);
        }

        public ProductDetailVM GetById(int id)
        {
            var prod = _productDetailRepository.GetById(id);
            //prod = prod.Where(i => i.ProductId == id);

            return ProjectMapper.ConvertToVM<ProductDetailVM>(prod);
        }

        public void Insert(ProductDetailVM model)
        {
            _productDetailRepository.Insert(ProjectMapper.ConvertToEntity<ProductDetail>(model));
        }

        public void Update(ProductDetailVM model)
        {
            _productDetailRepository.Update(ProjectMapper.ConvertToEntity<ProductDetail>(model));
        }
    }
}
