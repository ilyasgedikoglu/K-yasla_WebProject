using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Domain.Entities
{
    public class Category : BaseModel
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public string PicturePath { get; set; }

        public virtual ApplicationUser Creator { get; set; }
        public string CreatorId { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
