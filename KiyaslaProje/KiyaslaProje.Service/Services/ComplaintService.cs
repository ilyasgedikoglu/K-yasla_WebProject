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
    public class ComplaintService : IComplaintService
    {
        private readonly IRepository<Complaint> _complaintRepository;

        public ComplaintService(IRepository<Complaint> complaintRepository)
        {
            _complaintRepository = complaintRepository;
        }

        public void Delete(int id)
        {
            _complaintRepository.Delete(id);
        }

        public IEnumerable<ComplaintVM> GetAll()
        {
            var comps = _complaintRepository.GetAll;

            return ProjectMapper.ConvertToVMList<IEnumerable<ComplaintVM>>(comps);
        }

        public ComplaintVM GetById(int id)
        {
            var com = _complaintRepository.GetById(id);

            return ProjectMapper.ConvertToVM<ComplaintVM>(com);
        }

        public void Insert(ComplaintVM model)
        {
            _complaintRepository.Insert(ProjectMapper.ConvertToEntity<Complaint>(model));
        }

        public void Update(ComplaintVM model)
        {
            _complaintRepository.Update(ProjectMapper.ConvertToEntity<Complaint>(model));
        }
    }
}
