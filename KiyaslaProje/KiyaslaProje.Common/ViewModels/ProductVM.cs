using KiyaslaProje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Common.ViewModels
{
    public class ProductVM:BaseModelVM
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public ICollection<ProductPicture> ProductPictures { get; set; }
        public string CreatorId { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
        public int CategoryId { get; set; }
    }
}
