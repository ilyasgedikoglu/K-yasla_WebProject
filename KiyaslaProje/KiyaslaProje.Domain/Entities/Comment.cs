using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Domain.Entities
{
    public class Comment : BaseModel
    {
        public Comment()
        {
            Hit = 0;
        }
        public string Title { get; set; }
        public string Detail { get; set; }

        public virtual ApplicationUser Author { get; set; }
        public string AuthorId { get; set; }

        public virtual Product Product { get; set; }
        public int ProductId { get; set; }

        public int Hit { get; set; }
    }
}
