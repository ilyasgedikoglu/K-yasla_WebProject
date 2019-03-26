using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Domain.Entities
{
    public class CompareComment : BaseModel
    {
        public CompareComment()
        {
            Hit = 0;
        }
        public string Title { get; set; }
        public string Detail { get; set; }

        public virtual ApplicationUser Author { get; set; }
        public string AuthorId { get; set; }

        public virtual Compare Compare { get; set; }
        public int CompareId { get; set; }

        public int Hit { get; set; }
    }
}
