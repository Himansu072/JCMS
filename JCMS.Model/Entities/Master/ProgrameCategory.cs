using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities.Master
{
    public class ProgrameCategory:BaseEntity
    {
        [MaxLength(150)]
        public string CategoryName { get; set; }

        public string? CategoryContent { get; set; }

    }
}
