using KiyaslaProje.Common.Mappers;
using KiyaslaProje.Common.ViewModels;
using KiyaslaProje.Domain.Entities;
using KiyaslaProje.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }

        public CategoryVM GetById(int id)
        {
            var cat = _categoryRepository.GetById(id);

            return ProjectMapper.ConvertToVM<CategoryVM>(cat);
        }

        public IEnumerable<CategoryVM> GetAll()
        {
            var cats = _categoryRepository.GetAll;

            return ProjectMapper.ConvertToVMList<IEnumerable<CategoryVM>>(cats);
        }

        public void Insert(CategoryVM model)
        {
            _categoryRepository.Insert(ProjectMapper.ConvertToEntity<Category>(model));
        }

        public void Update(CategoryVM model)
        {
            _categoryRepository.Update(ProjectMapper.ConvertToEntity<Category>(model));
        }

        public IEnumerable<CategoryVM> GetAllIncluding()
        {
            var cats = _categoryRepository.GetAllIncluding("Products");

            return ProjectMapper.ConvertToVMList<IEnumerable<CategoryVM>>(cats); ;
        }
    }
}
