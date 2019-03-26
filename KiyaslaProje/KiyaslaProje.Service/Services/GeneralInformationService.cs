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
    public class GeneralInformationService:IGeneralInformationService
    {
        private readonly IRepository<GeneralInformation> _generalInformationRepository;

        public GeneralInformationService(IRepository<GeneralInformation> generalInformationRepository)
        {
            _generalInformationRepository = generalInformationRepository;
        }

        public void Delete(int id)
        {
            _generalInformationRepository.Delete(id);
        }

        public IEnumerable<GeneralInformationVM> GetAll()
        {
            var gen = _generalInformationRepository.GetAll;

            return ProjectMapper.ConvertToVMList<IEnumerable<GeneralInformationVM>>(gen);
        }

        public GeneralInformationVM GetById(int id)
        {
            var gen = _generalInformationRepository.GetById(id);

            return ProjectMapper.ConvertToVM<GeneralInformationVM>(gen);
        }

        public void Insert(GeneralInformationVM model)
        {
            _generalInformationRepository.Insert(ProjectMapper.ConvertToEntity<GeneralInformation>(model));
        }

        public void Update(GeneralInformationVM model)
        {
            _generalInformationRepository.Update(ProjectMapper.ConvertToEntity<GeneralInformation>(model));
        }
    }
}
