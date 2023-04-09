using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities.MainPage
{
    public class DistrictAdministration:BaseEntity
    {
       

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(80)]
        public string? Position { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Address { get; set; }

       
        [MaxLength(10)]
        public string? Mobile { get; set; }

        [MaxLength(65)]
        public string? Email { get; set; }=String.Empty;

        [Required]
        public string? Imagepath { get; set; }

        [DefaultValue(0)]
        public int PublishedMainPage { get; set; }
    }
}
