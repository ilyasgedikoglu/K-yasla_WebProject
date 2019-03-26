using KiyaslaProje.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Service.Services
{
    public interface IComplaintService
    {
        IEnumerable<ComplaintVM> GetAll();
        ComplaintVM GetById(int id);
        void Insert(ComplaintVM model);
        void Delete(int id);
        void Update(ComplaintVM model);
        //IEnumerable<ComplaintVM> GetAllIncluding();
    }
}
