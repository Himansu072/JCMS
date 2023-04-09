using JCMS.Model.Entities.PublicUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.ViewModels
{
    public class PublicUtilityViewModel
    {
        public Int64 Id {get; set;}
        public string Name { get; set; } = string.Empty;
       public string Address { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public string WebsiteName { get; set; } = string.Empty;

        public string CategoryName { get; set; } = string.Empty;    

    }
}
