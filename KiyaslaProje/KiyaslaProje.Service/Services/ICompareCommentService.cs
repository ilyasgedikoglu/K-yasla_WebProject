using KiyaslaProje.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Service.Services
{
    public interface ICompareCommentService
    {
        IEnumerable<CompareCommentVM> GetAll();
        CompareCommentVM GetById(int id);
        void Insert(CompareCommentVM model);
        void Delete(int id);
        void Update(CompareCommentVM model);
    }
}
