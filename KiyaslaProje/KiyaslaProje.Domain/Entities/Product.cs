using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Domain.Entities
{
    public class Product : BaseModel
    {
        public string Title { get; set; }
        public string Detail { get; set; }

        public ICollection<ProductPicture> ProductPictures { get; set; }

        public virtual ApplicationUser Creator { get; set; }
        public string CreatorId { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }

        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
