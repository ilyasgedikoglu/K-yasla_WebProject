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
    public class CompareService : ICompareService
    {
        private readonly IRepository<Compare> _compareRepository;

        public CompareService(IRepository<Compare> compareRepository)
        {
            _compareRepository = compareRepository;
        }

        public void Delete(int id)
        {
            _compareRepository.Delete(id);
        }

        public IEnumerable<CompareVM> GetAll()
        {
            var coms = _compareRepository.GetAll;

            return ProjectMapper.ConvertToVMList<IEnumerable<CompareVM>>(coms);
        }

        public CompareVM GetById(int id)
        {
            var com = _compareRepository.GetById(id);

            return ProjectMapper.ConvertToVM<CompareVM>(com);
        }

        public void Insert(CompareVM model)
        {
            _compareRepository.Insert(ProjectMapper.ConvertToEntity<Compare>(model));
        }

        public void Update(CompareVM model)
        {
            _compareRepository.Update(ProjectMapper.ConvertToEntity<Compare>(model));
        }

        public IEnumerable<CompareVM> GetAllIncluding()
        {
            var coms = _compareRepository.GetAllIncluding("Products");

            return ProjectMapper.ConvertToVMList<IEnumerable<CompareVM>>(coms);
        }
    }
}
