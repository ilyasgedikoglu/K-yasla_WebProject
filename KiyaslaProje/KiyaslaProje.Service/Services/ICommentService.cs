using KiyaslaProje.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Service.Services
{
    public interface ICommentService
    {
        IEnumerable<CommentVM> GetAll();
        CommentVM GetById(int id);
        void Insert(CommentVM model);
        void Delete(int id);
        void Update(CommentVM model);
    }
}
