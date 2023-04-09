using JCMS.Core;
using JCMS.Model.Entities.Documents;
using JCMS.Model.Entities.Master;
using JCMS.Repository.Repositories.Interfaces;
using JCMS.Repository.Repositories.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;

namespace JCMS.Web.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class ContentController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IUploadRepository _UploadRepository;
        private readonly IDocumentRepository _DocumentRepository;
        private readonly IMainpageRepository _mainpageRepository;

        public ContentController(IWebHostEnvironment webHostEnvironment, IUploadRepository UploadRepository, IDocumentRepository documentRepository,IMainpageRepository mainpageRepository)
        {
            this.webHostEnvironment = webHostEnvironment;
            _UploadRepository = UploadRepository;
            _DocumentRepository = documentRepository;
            _mainpageRepository = mainpageRepository;
        }
        public IActionResult AddContent()
        {
            return View();
        }
       
        [HttpPost]
        public JsonResult GetPagemaster()

        {
            var data = _UploadRepository.GetPageMasters();
            return Json(data);
        }
        [HttpPost]
        public IActionResult Addpagecontent(Page pg)
        {
            if (pg != null)
            {                
                int status = _UploadRepository.SavePageContent(pg);
                if (status == 1)
                {

                    return new ObjectResult(new { status = "success" });
                }
            }
            return new ObjectResult(new { status = "fail" });

        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetPageContent(int pid)

        {
            var data = _UploadRepository.GetPageContent(pid);
            return Json(data);
        }

        public IActionResult AddTender()
        {
            return View();
        }
        [HttpPost]
        public IActionResult insertTenderDetails(IFormFile PDF)
        {
            
            try
            {
                
                IFormFile file = PDF;
                if (file == null || file.Length == 0)
                {
                    return Content(new AjaxResult { state = ResultType.success.ToString(), message = "Please choose a pdf file." }.ToJson());
                }
                Random rnd = new Random();
                int num = rnd.Next();
                string filenameData = num.ToString()+file.FileName;
                string sFileExtension = Path.GetExtension(file.FileName).ToLower();
                if (sFileExtension != ".pdf")
                {
                    return Content(new AjaxResult { state = ResultType.warning.ToString(), message = "Please choose a valid pdf file format." }.ToJson());
                }
                Tender RegdInfo = JsonConvert.DeserializeObject<Tender>(Request.Form["RegdInfo"].ToString());
                string folderName = string.Empty;
                string filePath = string.Empty;

                folderName = "WebSite/download";
                string webRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                // string webRootPath = _options.WebFilePathUpload;
                string newPath = Path.Combine(webRootPath, folderName);
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                string fullPath = Path.Combine(newPath + @"/" + filenameData);
                filePath = Path.Combine(folderName + @"/" + filenameData);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                    stream.Position = 0;
                    
                }
                RegdInfo.fileName = filenameData;
                var retVal = _DocumentRepository.SaveTender(RegdInfo);
                if (retVal == 1)
                {
                    return Content(new AjaxResult { state = ResultType.success.ToString(), message = "Record added successfully." }.ToJson());
                }
                else
                {
                    return Content(new AjaxResult { state = ResultType.error.ToString(), message = "Error occured while showing" }.ToJson());
                }
                
            }
            catch (Exception ex)
            {
                return Content(new AjaxResult { state = ResultType.error.ToString(), message = ex.Message, data = null }.ToJson());
            }
        }

        [HttpPost]
        public IActionResult UpdateTenderDetails(IFormFile PDF)
        {

            try
            {
                
                IFormFile file = PDF;
                if (file == null || file.Length == 0)
                {
                   
                    Tender RegdInfo1 = JsonConvert.DeserializeObject<Tender>(Request.Form["RegdInfo"].ToString());
                    var Val = _DocumentRepository.UpdateTender(RegdInfo1);
                    if (Val == 1)
                    {
                        return Content(new AjaxResult { state = ResultType.success.ToString(), message = "Record Updated successfully." }.ToJson());
                    }
                    else
                    {
                        return Content(new AjaxResult { state = ResultType.error.ToString(), message = "Error occured while showing" }.ToJson());
                    }
                    
                    
                }
                Random rnd = new Random();
                int num = rnd.Next();
                string filenameData = num.ToString() + file.FileName;
                string sFileExtension = Path.GetExtension(file.FileName).ToLower();
                if (sFileExtension != ".pdf")
                {
                    return Content(new AjaxResult { state = ResultType.warning.ToString(), message = "Please choose a valid pdf file format." }.ToJson());
                }
                Tender RegdInfo = JsonConvert.DeserializeObject<Tender>(Request.Form["RegdInfo"].ToString());
                string folderName = string.Empty;
                string filePath = string.Empty;
                folderName = "WebSite/download";
                string webRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                // string webRootPath = _options.WebFilePathUpload;
                string newPath = Path.Combine(webRootPath, folderName);
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                string fullPath = Path.Combine(newPath + @"/" + filenameData);
                filePath = Path.Combine(folderName + @"/" + filenameData);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                    stream.Position = 0;

                }
                RegdInfo.fileName = filenameData;
                var retVal = _DocumentRepository.UpdateTender(RegdInfo);
                if (retVal == 1)
                {
                    return Content(new AjaxResult { state = ResultType.success.ToString(), message = "Record Updated successfully." }.ToJson());
                }
                else
                {
                    return Content(new AjaxResult { state = ResultType.error.ToString(), message = "Error occured while showing" }.ToJson());
                }
                
            }
            catch (Exception ex)
            {
                return Content(new AjaxResult { state = ResultType.error.ToString(), message = ex.Message, data = null }.ToJson());
            }
        }


        [HttpPost]
        public JsonResult GetTenderList()

        {
            var data = _DocumentRepository.TenderList(0);
            return Json(data);
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetselectedTenderList(int id)

        {
            var data = _DocumentRepository.TenderList(id);
            return Json(data);
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetTenderListpublic()

        {
            var data = _DocumentRepository.TenderList(1);
            return Json(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "SuperAdmins")]
        public IActionResult DelTenderList(int id)

        {
            var data = _DocumentRepository.DeleteTender(id);
            if (!string.IsNullOrEmpty(data))
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "WebSite/download");
                string ExitingFile = Path.Combine(uploadsFolder, data);
                if (System.IO.File.Exists(ExitingFile))
                    System.IO.File.Delete(ExitingFile);
            
                return Content(new AjaxResult { state = ResultType.success.ToString(), message = "Record deleted successfully." }.ToJson());
            }
            else
            {
                return Content(new AjaxResult { state = ResultType.error.ToString(), message = "Error occured while Deleting" }.ToJson());
            }
        }
        public IActionResult AddNotice()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetNoticeList()

        {
            var data = _DocumentRepository.AnnouncementList(3);
            return Json(data);
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetNoticeListpublic()

        {
            var data = _DocumentRepository.AnnouncementList(3).OrderByDescending(a=>a.Id).Take(10);
            return Json(data);
        }
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult insertAnnouncementDetails(IFormFile PDF)
        {

            try
            {

                IFormFile file = PDF;
                if (file == null || file.Length == 0)
                {
                    return Content(new AjaxResult { state = ResultType.success.ToString(), message = "Please choose a pdf file." }.ToJson());
                }
                Random rnd = new Random();
                int num = rnd.Next();
                string filenameData = num.ToString() + file.FileName;
                string sFileExtension = Path.GetExtension(file.FileName).ToLower();
                if (sFileExtension != ".pdf")
                {
                    return Content(new AjaxResult { state = ResultType.warning.ToString(), message = "Please choose a valid pdf file format." }.ToJson());
                }
                Announcement RegdInfo = JsonConvert.DeserializeObject<Announcement>(Request.Form["RegdInfo"].ToString());
                string folderName = string.Empty;
                string filePath = string.Empty;

                folderName = "WebSite/download";
                string webRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                // string webRootPath = _options.WebFilePathUpload;
                string newPath = Path.Combine(webRootPath, folderName);
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                string fullPath = Path.Combine(newPath + @"/" + filenameData);
                filePath = Path.Combine(folderName + @"/" + filenameData);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                    stream.Position = 0;

                }
                RegdInfo.Filename = filenameData;
                var retVal = _DocumentRepository.SaveAnnouncement(RegdInfo);
                if (retVal == 1)
                {
                    return Content(new AjaxResult { state = ResultType.success.ToString(), message = "Record added successfully." }.ToJson());
                }
                else
                {
                    return Content(new AjaxResult { state = ResultType.error.ToString(), message = "Error occured while showing" }.ToJson());
                }

            }
            catch (Exception ex)
            {
                return Content(new AjaxResult { state = ResultType.error.ToString(), message = ex.Message, data = null }.ToJson());
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetAnnouncementList()

        {
            var data = _DocumentRepository.AnnouncementList(1);
            return Json(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "SuperAdmins")]
        public IActionResult DelAnnouncementList(int id)

        {
            var data = _DocumentRepository.DeleteAnnouncement(id);
            if (!string.IsNullOrEmpty(data))
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "WebSite/download");
                string ExitingFile = Path.Combine(uploadsFolder, data);
                if (System.IO.File.Exists(ExitingFile))
                    System.IO.File.Delete(ExitingFile);

                return Content(new AjaxResult { state = ResultType.success.ToString(), message = "Record deleted successfully." }.ToJson());
            }
            else
            {
                return Content(new AjaxResult { state = ResultType.error.ToString(), message = "Error occured while Deleting" }.ToJson());
            }
        }
        public IActionResult AddAdvertisement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult insertAdverisementDetails(IFormFile PDF)
        {

            try
            {

                IFormFile file = PDF;
                if (file == null || file.Length == 0)
                {
                    return Content(new AjaxResult { state = ResultType.success.ToString(), message = "Please choose a pdf file." }.ToJson());
                }
                Random rnd = new Random();
                int num = rnd.Next();
                string filenameData = num.ToString() + file.FileName;
                string sFileExtension = Path.GetExtension(file.FileName).ToLower();
                if (sFileExtension != ".pdf")
                {
                    return Content(new AjaxResult { state = ResultType.warning.ToString(), message = "Please choose a valid pdf file format." }.ToJson());
                }
                Announcement RegdInfo = JsonConvert.DeserializeObject<Announcement>(Request.Form["RegdInfo"].ToString());
                string folderName = string.Empty;
                string filePath = string.Empty;

                folderName = "WebSite/Advertise";
                string webRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                // string webRootPath = _options.WebFilePathUpload;
                string newPath = Path.Combine(webRootPath, folderName);
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                string fullPath = Path.Combine(newPath + @"/" + filenameData);
                filePath = Path.Combine(folderName + @"/" + filenameData);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                    stream.Position = 0;

                }
                RegdInfo.Filename = filenameData;
                var retVal = _DocumentRepository.SaveAnnouncement(RegdInfo);
                if (retVal == 1)
                {
                    return Content(new AjaxResult { state = ResultType.success.ToString(), message = "Record added successfully." }.ToJson());
                }
                else
                {
                    return Content(new AjaxResult { state = ResultType.error.ToString(), message = "Error occured while showing" }.ToJson());
                }

            }
            catch (Exception ex)
            {
                return Content(new AjaxResult { state = ResultType.error.ToString(), message = ex.Message, data = null }.ToJson());
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetAdverisementList()

        {
            var data = _DocumentRepository.AnnouncementList(2);
            return Json(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "SuperAdmins")]
        public IActionResult DelAdverisementList(int id)

        {
            var data = _DocumentRepository.DeleteAnnouncement(id);
            if (!string.IsNullOrEmpty(data))
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "WebSite/Advertise");
                string ExitingFile = Path.Combine(uploadsFolder, data);
                if (System.IO.File.Exists(ExitingFile))
                    System.IO.File.Delete(ExitingFile);

                return Content(new AjaxResult { state = ResultType.success.ToString(), message = "Record deleted successfully." }.ToJson());
            }
            else
            {
                return Content(new AjaxResult { state = ResultType.error.ToString(), message = "Error occured while Deleting" }.ToJson());
            }
        }

        public IActionResult AddPrograme()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPogrameCategory(ProgrameCategory pg)
        {
            if (pg != null)
            {
                int status = _mainpageRepository.SaveProgrammecategory(pg);
                if (status == 1)
                {

                    return new ObjectResult(new { status = "success" });
                }
            }
            return new ObjectResult(new { status = "fail" });

        }
        [HttpPost]
        public IActionResult AddPogramecontent(ProgrameCategory pg)
        {
            if (pg != null)
            {
                int status = _mainpageRepository.UpdateProgrammecontent(pg);
                if (status == 1)
                {

                    return new ObjectResult(new { status = "success" });
                }
            }
            return new ObjectResult(new { status = "fail" });

        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetPogrameCategory()

        {
            var data = _mainpageRepository.GetProgrammecategory();
            return Json(data);
        }

        [HttpPost]
        [AllowAnonymous]
        public JsonResult GetPogrameCategoryid(int id)

        {
            var data = _mainpageRepository.GetProgrammecategorybyid(id);
            return Json(data);
        }

        
        public IActionResult AddDocument()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDocument(IFormFile PDF)
        {
            IFormFile file = PDF;
            if (file == null || file.Length == 0)
            {
                return Content(new AjaxResult { state = ResultType.success.ToString(), message = "Please choose a pdf file." }.ToJson());
            }
            Random rnd = new Random();
            int num = rnd.Next();
            string filenameData = num.ToString() + file.FileName;
            string sFileExtension = Path.GetExtension(file.FileName).ToLower();
            if (sFileExtension != ".pdf")
            {
                return Content(new AjaxResult { state = ResultType.warning.ToString(), message = "Please choose a valid pdf file format." }.ToJson());
            }
            DocumentsEntry RegdInfo = JsonConvert.DeserializeObject<DocumentsEntry>(Request.Form["RegdInfo"].ToString());
            string folderName = string.Empty;
            string filePath = string.Empty;

            folderName = "WebSite/download";
            string webRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            string newPath = Path.Combine(webRootPath, folderName);
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }
            string fullPath = Path.Combine(newPath + @"/" + filenameData);
            filePath = Path.Combine(folderName + @"/" + filenameData);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
                stream.Position = 0;

            }
            RegdInfo.FileName = filenameData;

                int status = _DocumentRepository.AddDocuments(RegdInfo);
                if (status == 1)
                {

                    return new ObjectResult(new { status = "success" });
                }
            
            return new ObjectResult(new { status = "fail" });

        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetDocument()

        {
            var data = _DocumentRepository.ViewDocuments();
            return Json(data);
        }

        [HttpPost]
        public IActionResult AddNewevent(IFormFile PDF)
        {
            IFormFile file = PDF;
            if (file == null || file.Length == 0)
            {
                return Content(new AjaxResult { state = ResultType.success.ToString(), message = "Please choose a image file." }.ToJson());
            }
            Random rnd = new Random();
            int num = rnd.Next();
            string filenameData = num.ToString() + file.FileName;
            string sFileExtension = Path.GetExtension(file.FileName).ToLower();
            if (sFileExtension == ".jpg" || sFileExtension == ".png" || sFileExtension == ".jpeg")
            {
                //return Content(new AjaxResult { state = ResultType.warning.ToString(), message = "Please choose a jpg or png file format." }.ToJson());
            }
            else
            {
                return Content(new AjaxResult { state = ResultType.warning.ToString(), message = "Please choose a jpg or png file format." }.ToJson());
            }
            NewsEvent RegdInfo = JsonConvert.DeserializeObject<NewsEvent>(Request.Form["RegdInfo"].ToString());
            string folderName = string.Empty;
            string filePath = string.Empty;

            folderName = "WebSite/download";
            string webRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            string newPath = Path.Combine(webRootPath, folderName);
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }
            string fullPath = Path.Combine(newPath + @"/" + filenameData);
            filePath = Path.Combine(folderName + @"/" + filenameData);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
                stream.Position = 0;

            }
            RegdInfo.ImageName = filenameData;

            int status = _DocumentRepository.AddNewsEvent(RegdInfo);
            if (status == 1)
            {

                return new ObjectResult(new { status = "success" });
            }

            return new ObjectResult(new { status = "fail" });

        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetNewsevent()
        {
            var data = _DocumentRepository.ViewNewsEvent();
            return Json(data);
        }

    }
}
