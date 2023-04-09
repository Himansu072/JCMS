using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities.Master
{
    public  class PageSection
    {
        [Key]
        public int PsId { get; set; }
        [Required]
        public string Name { get; set; }

        public int Sectiontype { get; set; } //0-for only text 1 for only image 2- for text

        [ForeignKey("PageMaster")]
        public int PageId { get; set; }
        public PageMaster PageMaster { get; set; }

    }
}
