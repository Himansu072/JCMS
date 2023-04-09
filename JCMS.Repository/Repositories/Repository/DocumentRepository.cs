using JCMS.Model.Entities.Documents;
using JCMS.Model.Entities.MainPage;
using JCMS.Model.Entities.Master;
using JCMS.Model.ViewModels;
using JCMS.Repository.Context;
using JCMS.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Repository.Repositories.Repository
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly CMSDbContext context;
        public DocumentRepository(CMSDbContext context)
        {
            this.context = context;
        }

        
        public List<Announcement> AnnouncementList(int type)
        {
            return context.Announcement.Where(a=>a.Type==type).OrderByDescending(a => a.AddedDate).ToList();
        }

        public string DeleteAnnouncement(int id)
        {
            Announcement da = context.Announcement.Where(a => a.Id == id).SingleOrDefault();
            if (da != null)
            {
                context.Remove(da);
                context.SaveChanges();
                return da.Filename;
            }

            return null;
        }

        public string DeleteTender(int id)
        {
            Tender da = context.Tender.Where(a => a.Id == id).SingleOrDefault();
            if(da != null)
            {
                context.Remove(da);
                context.SaveChanges();
                return da.fileName;
            }
            
            return null;
        }

        public int SaveAnnouncement(Announcement pg)
        {
            context.Announcement.Add(pg);
            context.SaveChanges();
            return 1;
        }

        public int SaveTender(Tender pg)
        {
            context.Tender.Add(pg);
            context.SaveChanges();
            return 1;
        }

        public List<Tender> TenderList(int type)
        {
            if(type==0)
            {
                return context.Tender.Select(a=>new Tender {Id=a.Id, Titleen=a.Titleen, openingDt= a.openingDt.Date+a.openingTime.TimeOfDay, closingDt =a.closingDt.Date+a.closeingTime.TimeOfDay,subDate = a.subDate.Date+a.subTime.TimeOfDay,fileName=a.fileName}).ToList();
            }
            else
            {
                //return context.Tender.Where(a=>a.Deleted==0).Select(a => new Tender { Id = a.Id, Titleen = a.Titleen, openingDt = a.openingDt.Date + a.openingTime.TimeOfDay, closingDt = a.closingDt.Date + a.closeingTime.TimeOfDay, subDate = a.subDate.Date + a.subTime.TimeOfDay, fileName = a.fileName }).OrderByDescending(a=>a.Id).ToList();
                return context.Tender.Where(a => a.Id == type).Select(a => new Tender { Id = a.Id, Titleen = a.Titleen, openingDt = a.openingDt.Date + a.openingTime.TimeOfDay, closingDt = a.closingDt.Date + a.closeingTime.TimeOfDay, subDate = a.subDate.Date + a.subTime.TimeOfDay, fileName = a.fileName }).OrderByDescending(a => a.Id).ToList();
            }
        }

        public int UpdateTender(Tender update)
        {
            Tender dbda = context.Tender.Where(a => a.Id == update.Id).SingleOrDefault();
            if (dbda != null)
            {
                dbda.Titleen = update.Titleen;
                dbda.closingDt = update.closingDt;
                dbda.closeingTime = update.closeingTime;
                dbda.subDate = update.subDate;
                dbda.subTime = update.subTime;
                if (update.fileName != "")
                {
                    dbda.fileName = update.fileName;
                }
                context.Update(dbda);
                context.SaveChanges();
                return 1;
            }

            return 0;
        }

        public string UpdateAnnouncement(Announcement ac)
        {
            throw new NotImplementedException();
        }

        public int AddDocuments(DocumentsEntry documentsEntry)
        {
            documentsEntry.AddedDate = DateTime.Now;
            context.documentsEntries.Add(documentsEntry);
            context.SaveChanges();
            return 1;
        }


        public List<DocumentsEntry> ViewDocuments()
        {
            return context.documentsEntries.Where(a => a.Deleted == 0).OrderByDescending(a => a.AddedDate).ToList();
        }

        public int AddNewsEvent(NewsEvent documentsEntry)
        {
            documentsEntry.AddedDate = DateTime.Now;
            context.NewsEvents.Add(documentsEntry);
            context.SaveChanges();
            return 1;
        }

        public List<NewsEvent> ViewNewsEvent()
        {
            return context.NewsEvents.Where(a => a.Deleted == 0).OrderByDescending(a=>a.Eventdate).ToList();
        }
        public List<whatsnewViewModel> ViewWtsnew()
        {
            var query = context.NewsEvents.Where(a => a.Deleted == 0 && a.iswtsnew == 1).OrderByDescending(a => a.Id).Select(x => new whatsnewViewModel { id = x.Id, type = "News", Description = x.Title, date = x.Eventdate })
        .Concat(context.Announcement.Select(x => new whatsnewViewModel { id = x.Id, type = "Announcement", Description = x.Title, date = x.AddedDate }))
        .Concat(context.Tender.Select(x => new whatsnewViewModel { id = x.Id, type = "Tender", Description = x.Titleen, date = x.AddedDate }));
            return query.OrderByDescending(a=>a.date).ToList();
        }
    }
}
