using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities.Master
{
    public class PageMaster
    {
        [Key]
        public int Pid { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Url { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaKeyword { get; set; }
        public string? MetaDescription { get; set; }
        public bool ActiveStatus { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
