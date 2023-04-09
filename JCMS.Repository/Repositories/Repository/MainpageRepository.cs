using JCMS.Model.Entities.MainPage;
using JCMS.Model.Entities.Master;
using JCMS.Repository.Context;
using JCMS.Repository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Repository.Repositories.Repository
{
    public class MainpageRepository : IMainpageRepository
    {
        private CMSDbContext context;
        public MainpageRepository(CMSDbContext context)
        {
            this.context = context;           
        }

        public int checkduplicatemainpage(int status)
        {
            var dup=context.DistrictAdministration.Where(a=>a.PublishedMainPage== status && a.Deleted==0 ).ToList();
            if(dup.Any())
            {
                return dup.Count();
            }
            return 0;
        }

        public int deletedistrictAdminstration(int id)
        {
            DistrictAdministration da = context.DistrictAdministration.Where(a => a.Id ==id).SingleOrDefault();
            context.Remove(da);
            context.SaveChanges();
            return 1;
        }

        public DistrictAdministration editdistrictAdminstration(int id)
        {
            DistrictAdministration da = context.DistrictAdministration.SingleOrDefault(a => a.Id == id);
            
            return da;
        }

        public List<DistrictAdministration> GetDistrictAdministrations()
        {
            return context.DistrictAdministration.Where(a => a.Deleted == 0).ToList();
        }

        public int savedistrictAdminstration(DistrictAdministration da)
        {
            context.DistrictAdministration.Add(da);
            context.SaveChanges();
            return 1;
        }

        public int UpdatedistrictAdminstration(DistrictAdministration uda)
        {
            context.Entry(uda).State = EntityState.Modified;
            context.SaveChanges();
            return 1;
        }
        public int SaveProgrammecategory(ProgrameCategory da)
        {
            if(da.Id==0)
            {
                da.AddedDate=DateTime.Now;
                context.programeCategories.Add(da);
                context.SaveChanges();
                return 1;
            }
            else
            {
                ProgrameCategory dbda = context.programeCategories.Where(a => a.Id == da.Id).SingleOrDefault();
                if(dbda!=null)
                {
                    dbda.ModifiedDate = DateTime.Now;
                    dbda.CategoryName=da.CategoryName;
                    context.Update(dbda);
                    context.SaveChanges();
                }
                
                return 1;
            }
           
        }
        public int UpdateProgrammecontent(ProgrameCategory da)
        {
           
                ProgrameCategory dbda = context.programeCategories.Where(a => a.Id == da.Id).SingleOrDefault();
                if (dbda != null)
                {
                    dbda.ModifiedDate = DateTime.Now;
                    dbda.CategoryContent = da.CategoryContent;
                    context.Update(dbda);
                    context.SaveChanges();
                }

                return 1;
            

        }
        public List<ProgrameCategory> GetProgrammecategory()
        {
                
            return context.programeCategories.Where(a => a.Deleted == 0).ToList();
            
            
        }
        public ProgrameCategory GetProgrammecategorybyid(int id)
        {

            return context.programeCategories.Where(a => a.Deleted == 0 && a.Id==id).FirstOrDefault();

        }
    }
}
