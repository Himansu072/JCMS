using JCMS.Model.Entities.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities.Officials
{
    public class WardOfficers:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Designation { get; set; }
        [ForeignKey("Ward")]
        public Int64 Wardid { get; set; }
        public Ward Ward { get; set; }
        [Required]
        [MaxLength(100)]
        public string photo { get; set; }
        [Required]
        [MaxLength(10)]
        public string Mobileno { get; set; }
        public string Email { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
    }
}
