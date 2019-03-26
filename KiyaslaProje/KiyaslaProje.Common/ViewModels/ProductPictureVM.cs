using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Common.ViewModels
{
    public class ProductPictureVM:BaseModelVM
    {
        public int ProductId { get; set; }
        public string PPicturePath { get; set; }
        public string AltText { get; set; }
    }
}
