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
    public class CompareCommentService : ICompareCommentService
    {
        private readonly IRepository<CompareComment> _compareCommentRepository;

        public CompareCommentService(IRepository<CompareComment> compareCommentRepository)
        {
            _compareCommentRepository = compareCommentRepository;
        }

        public void Delete(int id)
        {
            _compareCommentRepository.Delete(id);
        }

        public IEnumerable<CompareCommentVM> GetAll()
        {
            var coms = _compareCommentRepository.GetAll;

            return ProjectMapper.ConvertToVMList<IEnumerable<CompareCommentVM>>(coms);
        }

        public CompareCommentVM GetById(int id)
        {
            var com = _compareCommentRepository.GetById(id);

            return ProjectMapper.ConvertToVM<CompareCommentVM>(com);
        }

        public void Insert(CompareCommentVM model)
        {
            _compareCommentRepository.Insert(ProjectMapper.ConvertToEntity<CompareComment>(model));
        }

        public void Update(CompareCommentVM model)
        {
            _compareCommentRepository.Update(ProjectMapper.ConvertToEntity<CompareComment>(model));
        }

        public IEnumerable<CompareCommentVM> GetAllIncluding()
        {
            var coms = _compareCommentRepository.GetAllIncluding("Compares");

            return ProjectMapper.ConvertToVMList<IEnumerable<CompareCommentVM>>(coms); ;
        }
    }
}
