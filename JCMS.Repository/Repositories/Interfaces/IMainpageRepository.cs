using JCMS.Model.Entities.MainPage;
using JCMS.Model.Entities.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Repository.Repositories.Interfaces
{
    public interface IMainpageRepository
    {
        public int savedistrictAdminstration(DistrictAdministration da);

        public List<DistrictAdministration> GetDistrictAdministrations();
        public DistrictAdministration editdistrictAdminstration(int id);
        public int UpdatedistrictAdminstration(DistrictAdministration uda);
        public int deletedistrictAdminstration(int id);
        public int checkduplicatemainpage(int status);
        public int SaveProgrammecategory(ProgrameCategory da);
        public List<ProgrameCategory> GetProgrammecategory();
        public ProgrameCategory GetProgrammecategorybyid(int id);
        public int UpdateProgrammecontent(ProgrameCategory da);
    }
}
