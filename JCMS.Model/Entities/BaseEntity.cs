using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Model.Entities
{
    public class BaseEntity
    {
        public Int64 Id
        {
            get;
            set;
        }
        public DateTime AddedDate
        {
            get;
            set;
        }=DateTime.Now;
        public DateTime? ModifiedDate
        {
            get;
            set;
        }
        public int Deleted
        {
            get;
            set;
        } = 0;
        public DateTime? DeletedDate
        {
            get;
            set;
        }
    }
}
