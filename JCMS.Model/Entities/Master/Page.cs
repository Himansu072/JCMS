using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities.Master
{
    public partial class Page
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("PageMaster")]
        public int Pid { get; set; }
        public PageMaster? PageMaster { get; set; }

        //[ForeignKey("PageSection")]
        //public int PsId { get; set; }

        //public PageSection? PageSection { get; set; }

        public string? Description { get; set; }

        //public string? imageurl { get; set; }
        public DateTime AddedOn { get; set; } = DateTime.Now;
        [Required]
        public bool ActiveStatus { get; set; } =true;
        public int languageType { get; set; }=0;
    }


}
