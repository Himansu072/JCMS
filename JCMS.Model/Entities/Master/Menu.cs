using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities.Master
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public int ParentId { get; set; }
        [Required]
        public string? Name { get; set; }

        public string? Url { get; set; }
        public string linkIcon { get; set; }
        [Required]
        public int MenuType { get; set; }
        public string Role { get; set; }
        public int languageType { get; set; }

    }
}
