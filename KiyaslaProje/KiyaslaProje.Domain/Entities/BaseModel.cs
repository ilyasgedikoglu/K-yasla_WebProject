using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Domain.Entities
{
    public class BaseModel
    {
        public BaseModel()
        {
            CreatedDate = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
