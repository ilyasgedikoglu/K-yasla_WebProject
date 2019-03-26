using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Common.ViewModels
{
    public class CompareCommentVM:BaseModelVM
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public string AuthorId { get; set; }
        public int CompareId { get; set; }
        public int Hit { get; set; }
    }
}
