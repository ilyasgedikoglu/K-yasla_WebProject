using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Common.ViewModels
{
    public class CompareVM:BaseModelVM
    {
        public string Title { get; set; }
        public int Product1Id { get; set; }
        public int Product2Id { get; set; }
        public string CreatorId { get; set; }
    }
}
