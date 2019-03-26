using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Domain.Entities
{
    public class Complaint:BaseModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Detail { get; set; }
        public string Title { get; set; }
    }
}
