using KiyaslaProje.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Service.Services
{
    public interface ICompareService
    {
        IEnumerable<CompareVM> GetAll();
        CompareVM GetById(int id);
        void Insert(CompareVM model);
        void Delete(int id);
        void Update(CompareVM model);
    }
}
