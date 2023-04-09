using JCMS.Repository.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JCMS.Web.Controllers
{
    [Authorize]
    public class DataController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private IUploadRepository _UploadRepository;
        private IDocumentRepository _DocumentRepository;
        public DataController(IWebHostEnvironment webHostEnvironment,  IUploadRepository UploadRepository, IDocumentRepository documentRepository)
        {
            this.webHostEnvironment = webHostEnvironment;
            _UploadRepository = UploadRepository;
            _DocumentRepository = documentRepository;
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetUploadimagelist(int Type)

        {
            var data = _UploadRepository.Getimagelist(Type,6);
            return Json(data);
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetWtsnewlist()

        {
            var data = _DocumentRepository.ViewWtsnew();
            return Json(data);
        }
    }
}
