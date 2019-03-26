using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Common.ViewModels
{
    public class ComplaintVM:BaseModelVM
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Detail { get; set; }
        public string Title { get; set; }
    }
}
