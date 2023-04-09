using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities.Documents
{
    public class DocumentsEntry: BaseEntity
    {
        public string Title { get; set; }
        [MaxLength(29)]
        public string Language { get; set; }

        public string FileName { get; set; }
        public int iswtsnew { get; set; } = 0;
    }
}
