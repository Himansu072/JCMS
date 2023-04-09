using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities.Documents
{
    public class Tender : BaseEntity
    {
        public string Titleen { get; set; }
        public DateTime openingDt { get; set; }
        public DateTime openingTime { get; set; }
        public DateTime closingDt { get; set; }
        public DateTime closeingTime { get; set; }
        public DateTime subDate { get; set; }
        public DateTime subTime { get; set; }
        public string fileName { get; set; }=string.Empty;
        public int iswtsnew { get; set; } = 0;

    }
}
