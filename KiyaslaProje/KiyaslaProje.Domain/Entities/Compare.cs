using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Domain.Entities
{
    public class Compare : BaseModel
    {
        public string Title { get; set; }

        public virtual Product Product { get; set; }
        public int Product1Id { get; set; }
        public int Product2Id { get; set; }

        public virtual ApplicationUser Creator { get; set; }
        public string CreatorId { get; set; }
    }
}
