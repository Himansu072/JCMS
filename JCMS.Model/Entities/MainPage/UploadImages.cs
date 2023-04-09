using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities.MainPage
{
    public class UploadImages : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        public string? Videolink { get; set; }
        [Required]
        public int type { get; set; }
        public string caption { get; set; }
    }
}
