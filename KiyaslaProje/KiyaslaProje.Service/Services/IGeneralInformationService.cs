using KiyaslaProje.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Service.Services
{
    public interface IGeneralInformationService
    {
        IEnumerable<GeneralInformationVM> GetAll();
        GeneralInformationVM GetById(int id);
        void Insert(GeneralInformationVM model);
        void Delete(int id);
        void Update(GeneralInformationVM model);

    }
}
