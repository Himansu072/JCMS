using JCMS.Model.Entities;
using JCMS.Model.Entities.MainPage;
using JCMS.Model.Entities.Master;
using JCMS.Model.Entities.Officials;
using JCMS.Model.Entities.PublicUtilities;
using JCMS.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Repository.Repositories.Interfaces
{
    public interface IUploadRepository
    {
        //-----For slider,gallery,achivments.
        public int saveimage(UploadImages da);
        public List<UploadImages> Getimagelist(int type,int top=0);
        public string deleteimage(int id);
        //--------------------------------------------------

        //-----------category
        public int savecategory(PublicUtilityCategory puc);
        public List<PublicUtilityCategory> GetCategoryList();
        public string DeleteCategory(int id);
        public int updatecategory(PublicUtilityCategory puc, int id);
        public Int64 CheckCategory(string name);
        public int savePublicUtility(PublicUtility pu);
        public string DeletePublicUtility(int id);
        public List<PublicUtilityViewModel> GetPublicUtilityList();
        //-----------category

        public List<PageMaster> GetPageMasters();
        public int SavePageContent(Page pg);
        public Page GetPageContent(int Pid);

        //--ward
        public List<Ward> GetAllWardName();
        public int saveWardOfficer(WardOfficers wo);
        public List<WardOfficers> GetAllWardoficer();
        public List<WardOfficers> GetAllWardoficerChairmanList();
        //--ward end
        //--council
        public List<Council> GetAllCouncilName();
        public int saveCounciler(Counciler co);
        public List<Counciler> GetAllCounciler();
        public List<Counciler> GetAllCouncilerChairman();
        //
        //Executive Officer
        public int saveExecutiveOfficer(ExecutiveOfficer eo);
        public List<ExecutiveOfficer> GetAllExecutiveOfficer();
        //
        public List<PublicUtilityCategory> GetServicesList();
        public List<JCMS.Model.Entities.Services> GetServiceDetailsList();
        public int saveServicedetail(Services sc);
        public string DeleteServicedetails(int id);
        public Int64 CheckAtaGlane(string name);
        public int saveataglance(AtaGlance atg);
        public List<AtaGlance> GetAtaGlanceList();
        public string Deleteataglance(int id);
    }
}
