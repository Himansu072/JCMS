using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities.Documents
{
    public  class NewsEvent:BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ImageName { get; set; }
        public DateTime Eventdate { get; set; }
        public int iswtsnew { get; set; } = 0;
    }
}
