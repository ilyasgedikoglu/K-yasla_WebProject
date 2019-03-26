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
    public class CommentService : ICommentService
    {
        private readonly IRepository<Comment> _commentRepository;

        public CommentService(IRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void Delete(int id)
        {
            _commentRepository.Delete(id);
        }

        public IEnumerable<CommentVM> GetAll()
        {
            var coms = _commentRepository.GetAllIncluding("Product");

            return ProjectMapper.ConvertToVMList<IEnumerable<CommentVM>>(coms); ;
        }

        public CommentVM GetById(int id)
        {
            var com = _commentRepository.GetById(id);

            return ProjectMapper.ConvertToVM<CommentVM>(com);
        }

        public void Insert(CommentVM model)
        {
            _commentRepository.Insert(ProjectMapper.ConvertToEntity<Comment>(model));
        }

        public void Update(CommentVM model)
        {
            _commentRepository.Update(ProjectMapper.ConvertToEntity<Comment>(model));
        }
    }
}
