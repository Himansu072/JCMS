using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities.Documents
{
    public class Announcement:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Filename { get; set; }
        public int Type { get; set; }
        public int iswtsnew { get; set; } = 0;
    }
}
