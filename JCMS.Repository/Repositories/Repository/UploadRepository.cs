using JCMS.Model.Entities;
using JCMS.Model.Entities.MainPage;
using JCMS.Model.Entities.Master;
using JCMS.Model.Entities.Officials;
using JCMS.Model.Entities.PublicUtilities;
using JCMS.Model.ViewModels;
using JCMS.Repository.Context;
using JCMS.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Repository.Repositories.Repository
{
    public class UploadRepository : IUploadRepository
    {
        private CMSDbContext context;
        public UploadRepository(CMSDbContext context)
        {
            this.context = context;
        }
        public string deleteimage(int id)
        {
            UploadImages da = context.UploadImages.Where(a => a.Id == id).SingleOrDefault();
            context.Remove(da);
            context.SaveChanges();
            return da.Name;
        }
        public List<UploadImages> Getimagelist(int type,int top=0)
        {
            if(top>0)
            {
                return context.UploadImages.Where(a => a.Deleted == 0 & a.type == type).OrderByDescending(a=>a.Id).Take(top).ToList();
            }
            else
            {
                return context.UploadImages.Where(a => a.Deleted == 0 & a.type == type).ToList();
            }
            
        }
        public int saveimage(UploadImages da)
        {
            context.UploadImages.Add(da);
            context.SaveChanges();
            return 1;
        }
        public int savecategory(PublicUtilityCategory puc)
        {
            context.PublicUtilityCategory.Add(puc);
            context.SaveChanges();
            return 1;
        }
        public List<PublicUtilityCategory> GetCategoryList()
        {
            return context.PublicUtilityCategory.Where(a => a.Deleted == 0 && a.CattypeId==1).ToList();
        }
        public string DeleteCategory(int id)
        {
            PublicUtilityCategory puc = context.PublicUtilityCategory.Where(a => a.Id == id).SingleOrDefault();
            context.Remove(puc);
            context.SaveChanges();
            return puc.CategoryName;
        }
        public int updatecategory(PublicUtilityCategory puc, int id)
        {
            throw new NotImplementedException();
        }
        public Int64 CheckCategory(string name)
        {
            Int64 id = 0; 
            PublicUtilityCategory puc =context.PublicUtilityCategory.Where(a=>a.CategoryName == name).FirstOrDefault();
            if(puc!=null)
            {
                id= puc.Id;
            }
            return id;
           
        }
        public int savePublicUtility(PublicUtility pu)
        {
            context.PublicUtility.Add(pu);
            context.SaveChanges();
            return 1;
        }

        public string DeletePublicUtility(int id)
        {
            PublicUtility pu = context.PublicUtility.Where(a => a.Id == id).SingleOrDefault();
            context.Remove(pu);
            context.SaveChanges();
            return pu.Name;
        }

        public List<PublicUtilityViewModel> GetPublicUtilityList()
        {           
           return context.PublicUtility.Join(context.PublicUtilityCategory, pa=>pa.CatId, pac => pac.Id, (pa, pac) => new { pa, pac }).Where(a => a.pa.Deleted == 0).Select(a=>new PublicUtilityViewModel {Id=a.pa.Id,Name=a.pa.Name, Address=a.pa.Address, Email=a.pa.Email==null?"":a.pa.Email, phone=a.pa.phone==null?"":a.pa.phone!, WebsiteName=a.pa.WebsiteName == null ? "" : a.pa.WebsiteName!, CategoryName=a.pac.CategoryName }).ToList();
        }

        public List<PageMaster> GetPageMasters()
        {
            var plist = context.PageMaster.ToList();
            return plist;
        }

        public int SavePageContent(Page pg)
        {
            Page puc = context.Page.Where(a => a.Pid == pg.Pid && a.ActiveStatus == true).FirstOrDefault();
            if(puc!=null)
            {
               puc.Description=pg.Description;
                context.Update(puc);
                context.SaveChanges();
                return 1;
            }
            else
            {
                context.Page.Add(pg);
                context.SaveChanges();
                return 1;
            }
           
        }

        public Page GetPageContent(int Pid)
        {
            Page puc = context.Page.Where(a => a.Pid == Pid && a.ActiveStatus==true ).FirstOrDefault();
            return puc;
        }
        public List<Ward> GetAllWardName()
        {
            return context.Ward.Where(a => a.Deleted == 0).ToList();
        }

        public int saveWardOfficer(WardOfficers wo)
        {
            context.WardOfficers.Add(wo);
            context.SaveChanges();
            return 1;

        }
        public List<WardOfficers> GetAllWardoficer()
        {
            return context.WardOfficers.Where(a => a.Deleted == 0).ToList();
        }
        public List<Model.Entities.Master.Council> GetAllCouncilName()
        {
            return context.Council.Where(a => a.Deleted == 0).ToList();
        }
        public int saveCounciler(Model.Entities.Officials.Counciler co)
        {
            context.Councilers.Add(co);
            context.SaveChanges();
            return 1;
        }
        List<Model.Entities.Officials.Counciler> IUploadRepository.GetAllCounciler()
        {
            return context.Councilers.Where(a => a.Deleted == 0).ToList();

        }
        public int saveExecutiveOfficer(Model.Entities.Officials.ExecutiveOfficer eo)
        {
            context.ExecutiveOfficers.Add(eo);
            context.SaveChanges();
            return 1;
        }
        public List<Model.Entities.Officials.ExecutiveOfficer> GetAllExecutiveOfficer()
        {
            return context.ExecutiveOfficers.Where(a => a.Deleted == 0).ToList();
        }
        public List<PublicUtilityCategory> GetServicesList()
        {
            return context.PublicUtilityCategory.Where(a => a.Deleted == 0 && a.CattypeId == 2).ToList();
        }

        public List<JCMS.Model.Entities.Services> GetServiceDetailsList()
        {
            return context.Service.Where(a => a.Deleted == 0).ToList();
            

        }

        public int saveServicedetail(Model.Entities.Services sc)
        {

            context.Service.Add(sc);
            context.SaveChanges();
            return 1;
        }

        public string DeleteServicedetails(int id)
        {
            JCMS.Model.Entities.Services sc = context.Service.Where(a => a.Id == id).SingleOrDefault();
            context.Remove(sc);
            context.SaveChanges();
            return sc.Name;
        }
        //public List<PublicUtilityViewModel> GetServiceTypeList()
        //{
        //    return context.Service.Join(context.PublicUtilityCategory, pa => pa.CatId, pac => pac.Id, (pa, pac) => new { pa, pac }).Where(a => a.pa.Deleted == 0).Select(a => new PublicUtilityViewModel { Id = a.pa.Id, Name = a.pa.Name, Address = a.pa.Address, Email = a.pa.Email == null ? "" : a.pa.Email, phone = a.pa.phone == null ? "" : a.pa.phone!, WebsiteName = a.pa.WebsiteName == null ? "" : a.pa.WebsiteName!, CategoryName = a.pac.CategoryName }).ToList();

        //}
        public Int64 CheckAtaGlane(string name)
        {
            Int64 id = 0;
            AtaGlance atg = context.AtaGlances.Where(a => a.Name == name).FirstOrDefault();
            if (atg != null)
            {
                id = atg.Id;
            }
            return id;

        }
        public int saveataglance(AtaGlance atg)
        {
            context.AtaGlances.Add(atg);
            context.SaveChanges();
            return 1;

        }

        public List<AtaGlance> GetAtaGlanceList()
        {
            return context.AtaGlances.Where(a => a.Deleted == 0 ).ToList();
        }

        public string Deleteataglance(int id)
        {
            JCMS.Model.Entities.AtaGlance sc = context.AtaGlances.Where(a => a.Id == id).SingleOrDefault();
            context.Remove(sc);
            context.SaveChanges();
            return sc.Name;
        }

        public List<Counciler> GetAllCouncilerChairman()
        {
            return context.Councilers.Where(a => a.Deleted == 0 && a.Designation== "Chairperson").ToList();
        }

        public List<WardOfficers> GetAllWardoficerChairmanList()
        {
            return context.WardOfficers.Where(a => a.Deleted == 0 && a.Designation== "Chairperson").ToList();
        }
    }

}
