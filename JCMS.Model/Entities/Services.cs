using JCMS.Model.Entities.PublicUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities
{
        public class Services : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public string ImageNmae { get; set; }

        public string UrlName { get; set; }

        [ForeignKey("PublicUtilityCategory")]
        public Int64 CatId { get; set; }
        public PublicUtilityCategory PublicUtilityCategory { get; set; }
    }
}
