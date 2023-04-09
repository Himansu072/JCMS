using JCMS.Model.Entities;
using JCMS.Model.Entities.Documents;
using JCMS.Model.Entities.MainPage;
using JCMS.Model.Entities.Master;
using JCMS.Model.Entities.Officials;
using JCMS.Model.Entities.PublicUtilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Repository.Context
{
    public class CMSDbContext:DbContext
    {
        public DbSet<Menu> Menu { get; set; }

        public DbSet<PageMaster> PageMaster { get; set; }

        //public DbSet<PageSection> PageSection { get; set; }
        public DbSet<UploadImages> UploadImages { get; set; }
        public DbSet<DistrictAdministration> DistrictAdministration { get; set; }
        public DbSet<Page> Page { get; set; }
        public DbSet<PublicUtilityCategory> PublicUtilityCategory { get; set; }
        public DbSet<PublicUtility> PublicUtility { get; set; }
        public DbSet<CategoryType> CategoryType { get; set; }
        public DbSet<Ward> Ward { get; set; }
        public DbSet<WardOfficers> WardOfficers { get; set; }
        public DbSet<Council> Council { get; set; }
        public DbSet<Counciler> Councilers { get; set; }
        public DbSet<ExecutiveOfficer> ExecutiveOfficers { get; set; }
        public DbSet<Announcement> Announcement { get; set; }
        public DbSet<Tender> Tender { get; set; }
        public DbSet<ProgrameCategory> programeCategories { get; set; }
        public DbSet<Services> Service { get; set; }
        public DbSet<DocumentsEntry> documentsEntries { get; set;}

        public DbSet<NewsEvent> NewsEvents { get; set; }
        public DbSet<AtaGlance> AtaGlances { get; set; }
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PageMaster>().HasData(
                new PageMaster
                {
                    Pid = 1,
                    Name = "AboutUs",
                    ActiveStatus=false
                },
                new PageMaster
                {
                    Pid=2,
                    Name = "Mission",
                    ActiveStatus = false

                },
                new PageMaster
                {
                    Pid = 3,
                    Name = "Demography",
                    ActiveStatus = false

                },
                new PageMaster
                {
                    Pid = 4,
                    Name = "RTI",
                    ActiveStatus = false

                }
                );
            builder.Entity<CategoryType>().HasData(
                new CategoryType
                {
                    Id = 1,
                    Name = "PublicUtility",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Deleted=0
                },
                new CategoryType
                {
                    Id = 2,
                    Name = "Services",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Deleted = 0

                },
                new CategoryType
                {
                    Id = 3,
                    Name = "Documents",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Deleted = 0

                }
                );
            builder.Entity<Council>().HasData(
                new Council
                {
                    Id = 1,
                    Councilname = "Council1",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Deleted = 0
                },
                new Council
                {
                    Id = 2,
                    Councilname = "Council2",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Deleted = 0

                },
                new Council
                {
                    Id = 3,
                    Councilname = "Council3",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Deleted = 0

                }
                );
            builder.Entity<Ward>().HasData(
                new Ward
                {
                    Id = 1,
                    Wardname = "Ward-1",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Deleted = 0
                },
                new Ward
                {
                    Id = 2,
                    Wardname = "Ward-2",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Deleted = 0

                },
                new Ward
                {
                    Id = 3,
                    Wardname = "Ward-3",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Deleted = 0

                }
                );
        }
    }
}
