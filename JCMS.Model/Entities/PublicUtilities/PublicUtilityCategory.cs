using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities.PublicUtilities
{
    public  class PublicUtilityCategory: BaseEntity
    {
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public string ImageName { get; set; }

        [ForeignKey("CategoryType")]
        public Int64 CattypeId { get; set; }
        public CategoryType CategoryType { get; set; }
    }
  
}
