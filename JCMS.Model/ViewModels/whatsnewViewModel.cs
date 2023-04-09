using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.ViewModels
{
    public class whatsnewViewModel
    {
        public long id { get; set; }
        public string type { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? detaillink { get; set; }
        public DateTime? date { get; set; }
    }
}
