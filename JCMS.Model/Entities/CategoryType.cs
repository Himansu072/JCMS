using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities
{
    public class CategoryType : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
