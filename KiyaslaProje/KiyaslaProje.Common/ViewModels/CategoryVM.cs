using KiyaslaProje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Common.ViewModels
{
    public class CategoryVM : BaseModelVM
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public string PicturePath { get; set; }
        public string CreatorId { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
