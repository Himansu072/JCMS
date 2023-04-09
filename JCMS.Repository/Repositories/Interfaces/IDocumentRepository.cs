using JCMS.Model.Entities.Documents;
using JCMS.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCMS.Repository.Repositories.Interfaces
{
    public interface IDocumentRepository
    {
        public int SaveTender(Tender pg);
        public List<Tender> TenderList(int type);
        public string DeleteTender(int id);
        public int UpdateTender(Tender pg);

        public int SaveAnnouncement(Announcement pg);
        public List<Announcement> AnnouncementList(int type);

        public string UpdateAnnouncement(Announcement ac);
        public string DeleteAnnouncement(int id);
        public int AddDocuments(DocumentsEntry documentsEntry);
        public List<DocumentsEntry> ViewDocuments();

        public int AddNewsEvent(NewsEvent documentsEntry);
        public List<NewsEvent> ViewNewsEvent();
        public List<whatsnewViewModel> ViewWtsnew();
    }
}
