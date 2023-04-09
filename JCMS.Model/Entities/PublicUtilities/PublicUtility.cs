using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities.PublicUtilities
{
    
    public class PublicUtility : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
       
        public string? Email { get; set; }
        public string? phone { get; set; }
        public string? WebsiteName { get; set; }
        [ForeignKey("PublicUtilityCategory")]
        public Int64 CatId { get; set; }
        public PublicUtilityCategory PublicUtilityCategory { get; set; }

    }
}
