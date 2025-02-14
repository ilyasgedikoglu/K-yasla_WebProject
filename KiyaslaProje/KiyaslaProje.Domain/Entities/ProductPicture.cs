﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Domain.Entities
{
    public class ProductPicture : BaseModel
    {
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }

        public string PPicturePath { get; set; }
        public string AltText { get; set; }
    }
}
