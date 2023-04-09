using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities
{
    public  class AtaGlance:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Value { get; set; }
    }
}
