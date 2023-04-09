using JCMS.Model.Entities;
using JCMS.Model.Entities.MainPage;
using JCMS.Model.Entities.Officials;
using JCMS.Model.Entities.PublicUtilities;
using JCMS.Repository.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Globalization;

namespace JCMS.Web.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class PageController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private IMainpageRepository _MainpageRepository;
        private IUploadRepository _UploadRepository;
        public PageController(IWebHostEnvironment webHostEnvironment, IMainpageRepository MainpageRepository, IUploadRepository UploadRepository)
        {
            this.webHostEnvironment = webHostEnvironment;
            _MainpageRepository=MainpageRepository;
            _UploadRepository = UploadRepository;
        }
        public IActionResult AddContent()
        {
            return View();
        }
        public IActionResult AddSlider()
        {
            return View();
        }
        public IActionResult AddGallery()
        {
            return View();
        }
        public IActionResult Achievement()
        {
            return View();
        }
        public IActionResult AddImages()
        {
            return View();
        }
        public IActionResult AddDocuments()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnPostMyUploader(IFormFile MyUploader, int Type, string name )
        {
            if(string.IsNullOrEmpty(name))
            {
                name = "Test";
            }
            if (MyUploader != null)
            {
                
                Guid newGuid = Guid.NewGuid();
                string imageName = newGuid.ToString();
                string Imagepath = imageName + MyUploader.FileName;
                if (Type != 3)
                {
                    UploadImages upg = new UploadImages();
                    upg.Name = Imagepath;
                    upg.type = Type;
                    int status = _UploadRepository.saveimage(upg);
                    if (status == 1)
                    {
                        string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "public/Banner");
                        string filePath = Path.Combine(uploadsFolder, Imagepath);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            MyUploader.CopyTo(fileStream);
                        }
                        return new ObjectResult(new { status = "success" });
                    }
                }

                else if (Type == 3 && name != null)
                {
                    UploadImages upg = new UploadImages();
                    upg.Name = Imagepath;
                    upg.Videolink = name;
                    upg.type = Type;
                    int status = _UploadRepository.saveimage(upg);
                    if (status == 1)
                    {
                        string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "public/Banner");
                        string filePath = Path.Combine(uploadsFolder, Imagepath);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            MyUploader.CopyTo(fileStream);
                        }
                        return new ObjectResult(new { status = "success" });
                    }
                }
            }
            return new ObjectResult(new { status = "fail" });

        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetUploadimagelist(int Type)
        
        {
            var data = _UploadRepository.Getimagelist(Type);
            return Json(data);
        }
        [HttpPost]
        public JsonResult DeleteUploadimage(int id)
        {
            var data = _UploadRepository.deleteimage(id);
            if(!string.IsNullOrEmpty(data))
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "public/Banner");
                string ExitingFile = Path.Combine(uploadsFolder, data);
                if(System.IO.File.Exists(ExitingFile))
                System.IO.File.Delete(ExitingFile);
            }
            return Json(new { status = "success" });
        }
        public IActionResult AddDistrictAdminstration()
        {
            return View();
        }
        [HttpPost]
        public JsonResult SubmitDistofficial(DistrictAdministration da, IFormFile MyUploader)
        {
            if (da.Id > 0)
            {
                var result= _MainpageRepository.editdistrictAdminstration(Convert.ToInt32(da.Id));
                if(result != null)
                {
                    if (da.PublishedMainPage > 0)
                    {
                        if (_MainpageRepository.checkduplicatemainpage(da.PublishedMainPage) > 1)
                        {
                            return Json(new { status = "Already Present for main page . Please uncheck!" });
                        }
                    }
                    da.Imagepath = result.Imagepath;
                    var newres=_MainpageRepository.UpdatedistrictAdminstration(da);
                    if (newres == 1)
                    {
                        return Json(new { status = "success" });
                    }
                }
                
                

                return Json(new { status = "Fail" });
            }
            else
            {



                if (MyUploader != null)
                {
                    Guid newGuid = Guid.NewGuid();
                    string imageName = newGuid.ToString();
                    da.Imagepath = imageName + MyUploader.FileName;
                    if (da.PublishedMainPage > 0)
                    {
                        if (_MainpageRepository.checkduplicatemainpage(da.PublishedMainPage) > 0)
                        {
                            return Json(new { status = "Already Present for main page . Please uncheck!" });
                        }
                    }

                    int status = _MainpageRepository.savedistrictAdminstration(da);
                    if (status == 1)
                    {
                        string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "public/Official");
                        string filePath = Path.Combine(uploadsFolder, da.Imagepath);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            MyUploader.CopyTo(fileStream);
                        }
                        return Json(new { status = "success" });
                    }
                }



                return Json(new { status = "Fail" });
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetAdminstrationlist()
        {
            var data=_MainpageRepository.GetDistrictAdministrations();
            return Json(data);
        }

        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetAdminstrationforfirst()
        {
            var data = _MainpageRepository.GetDistrictAdministrations().Where(a => a.PublishedMainPage > 0).OrderBy(x => x.PublishedMainPage).Take(2); ;
            return Json(data.ToList());
        }

        [HttpPost]
        public JsonResult DeleteAdminstrationlist(int id)
        {
            var data = _MainpageRepository.deletedistrictAdminstration(id);
            return Json(new { status = "success" });
        }

        //Public utility Category section start
        public IActionResult Category()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(string name)
        {
            if (name != null)
            {
                PublicUtilityCategory puc=new PublicUtilityCategory();
                puc.CategoryName = name;
                int status = _UploadRepository.savecategory(puc);
                if (status == 1)
                {
                   
                    return new ObjectResult(new { status = "success" });
                }
            }
            return new ObjectResult(new { status = "fail" });

        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetPublicUtilityCategory()

        {
            var data = _UploadRepository.GetCategoryList();
            return Json(data);
        }
        
        [HttpPost]
        public JsonResult DeleteCategory(int id)
        {
            var data = _UploadRepository.DeleteCategory(id);
            if (!string.IsNullOrEmpty(data))
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "public/Banner");
                string ExitingFile = Path.Combine(uploadsFolder, data);
                System.IO.File.Delete(ExitingFile);
            }
            return Json(new { status = "success" });
        }

        [HttpPost]
        public IActionResult AddPublicUtilityCategory(IFormFile MyUploader,  string name )
        {
            if (MyUploader != null && !string.IsNullOrEmpty(name))
            {
                Int64 id = _UploadRepository.CheckCategory(name);
                if (id==0)
                {
                    Guid newGuid = Guid.NewGuid();
                    string imageName = newGuid.ToString();
                    string Imagepath = imageName + MyUploader.FileName;

                    PublicUtilityCategory puc = new PublicUtilityCategory();
                    puc.CategoryName = name;
                    puc.ImageName = Imagepath;
                    puc.CattypeId = 1;
                    int status = _UploadRepository.savecategory(puc);
                    if (status == 1)
                    {
                        string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "public/Banner");
                        string filePath = Path.Combine(uploadsFolder, Imagepath);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            MyUploader.CopyTo(fileStream);
                        }
                        return new ObjectResult(new { status = "success" });
                    }

                }
                else
                {
                    return new ObjectResult(new { status = "Already exist" });

                }

            }
            return new ObjectResult(new { status = "fail" });

        }
        public IActionResult PublicUtility()
        {
            return View();
        }
        
        [HttpPost]
        public JsonResult GetPublicUtilityCategoryList()
        {
            var data = _UploadRepository.GetCategoryList();
            var listitem = new List<SelectListItem>();
            foreach(var item in data)
            {
                listitem.Add(new SelectListItem { Text = item.CategoryName, Value = item.Id.ToString() });
            }
            var newlist = listitem.OrderBy(x => x.Value).ToList();
            //List<SelectListItem> customers = (from customer in this.Context.Customers.Take(10)
            //                                  select new SelectListItem
            //                                  {
            //                                      Value = customer.CustomerID,
            //                                      Text = customer.ContactName
            //                                  }).ToList();
            return Json(newlist);
        }
        public IActionResult AddPublicUtility(string name, string address, string email, string phone, string websitename, int catid)
        {
            if (name != null)
            {
                PublicUtility pu = new PublicUtility();
                pu.Name = name;
                pu.Address = address;
                pu.Email = email;
                pu.phone = phone;
                pu.WebsiteName = websitename;
                pu.CatId = catid;

                int status = _UploadRepository.savePublicUtility(pu);
                if (status == 1)
                {

                    return new ObjectResult(new { status = "success" });
                }
            }
            return new ObjectResult(new { status = "fail" });

        }
        [HttpPost]
        public JsonResult DeletePublicUtility(int id)
        {
            var data = _UploadRepository.DeletePublicUtility(id);
            if (!string.IsNullOrEmpty(data))
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "public/Banner");
                string ExitingFile = Path.Combine(uploadsFolder, data);
                System.IO.File.Delete(ExitingFile);
            }
            return Json(new { status = "success" });
        }

        //Public utility Category section end

        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetPublicUtility()

        {
            var data = _UploadRepository.GetPublicUtilityList();
            return Json(data);
        }
        //Public utility Category section end
        // Ward officer
        public IActionResult WardOfficer()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetAllWardName()
        {
            var data = _UploadRepository.GetAllWardName();
            var listitem = new List<SelectListItem>();
            foreach (var item in data)
            {
                listitem.Add(new SelectListItem { Text = item.Wardname, Value = item.Id.ToString() });
            }
            var newlist = listitem.OrderBy(x => x.Value).ToList();
            return Json(newlist);
        }
        [HttpPost]
        public IActionResult SaveWardOfficer(string Name, string Designation, int Wardid, string Mobileno, string Email, DateTime PeriodFrom, DateTime PeriodTo, IFormFile MyUploader)
        {
            if (MyUploader != null && Name != null)
            {
                Guid newGuid = Guid.NewGuid();
                string imageName = newGuid.ToString();
                string Imagepath = imageName + MyUploader.FileName;

                WardOfficers wo = new WardOfficers();
                wo.Name = Name;
                wo.Designation= Designation;
                wo.Wardid= Wardid;
                wo.photo= Imagepath;
                wo.Mobileno= Mobileno;
                wo.Email= Email;
                wo.PeriodFrom= PeriodFrom;
                wo.PeriodTo= PeriodTo;

                int status = _UploadRepository.saveWardOfficer(wo);
                if (status == 1)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "public/Banner");
                    string filePath = Path.Combine(uploadsFolder, Imagepath);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        MyUploader.CopyTo(fileStream);
                    }
                    return new ObjectResult(new { status = "success" });
                }
            }
            return new ObjectResult(new { status = "fail" });

        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetAllWardofficer()
        {
            var data = _UploadRepository.GetAllWardoficer();
            return Json(data);
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetAllWardofficerChairmanList()
        {
            var data = _UploadRepository.GetAllWardoficer();
            return Json(data);
        }
        //
        //Counciler
        public IActionResult Counciler()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetAllCouncilName()
        {
            var data = _UploadRepository.GetAllCouncilName();
            var listitem = new List<SelectListItem>();
            foreach (var item in data)
            {
                listitem.Add(new SelectListItem { Text = item.Councilname, Value = item.Id.ToString() });
            }
            var newlist = listitem.OrderBy(x => x.Value).ToList();
            return Json(newlist);
        }
        [HttpPost]
        public IActionResult SaveCounciler(string Name, string Designation, int councilid, string Mobileno, string Email, DateTime PeriodFrom, DateTime PeriodTo, IFormFile MyUploader)
        {
            if (MyUploader != null && Name != null)
            {
                Guid newGuid = Guid.NewGuid();
                string imageName = newGuid.ToString();
                string Imagepath = imageName + MyUploader.FileName;

                Counciler co = new Counciler();
                co.Name = Name;
                co.Designation = Designation;
                co.Councilid = councilid;
                co.photo = Imagepath;
                co.Mobileno = Mobileno;
                co.Email = Email;
                co.PeriodFrom = PeriodFrom;
                co.PeriodTo = PeriodTo;

                int status = _UploadRepository.saveCounciler(co);
                if (status == 1)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "public/Banner");
                    string filePath = Path.Combine(uploadsFolder, Imagepath);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        MyUploader.CopyTo(fileStream);
                    }
                    return new ObjectResult(new { status = "success" });
                }
            }
            return new ObjectResult(new { status = "fail" });

        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetAllCounciler()
        {
            var data = _UploadRepository.GetAllCounciler();
            return Json(data);
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetAllCouncilerChairman()
        {
            var data = _UploadRepository.GetAllCouncilerChairman();
            return Json(data);
        }
        //
        //Executive Officer
        public IActionResult Executiveofcr()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult SaveExecutiveofcr(string Name, string Mobileno, string Email, DateTime PeriodFrom, DateTime PeriodTo, IFormFile MyUploader)
        {
            if (MyUploader != null && Name != null)
            {
                Guid newGuid = Guid.NewGuid();
                string imageName = newGuid.ToString();
                string Imagepath = imageName + MyUploader.FileName;

                ExecutiveOfficer eo = new ExecutiveOfficer();
                eo.Name = Name;
                eo.Designation = "Executive Officer";
                eo.photo = Imagepath;
                eo.Mobileno = Mobileno;
                eo.Email = Email;
                eo.PeriodFrom = PeriodFrom.Date;
                eo.PeriodTo = PeriodTo.Date;

                int status = _UploadRepository.saveExecutiveOfficer(eo);
                if (status == 1)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "public/Banner");
                    string filePath = Path.Combine(uploadsFolder, Imagepath);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        MyUploader.CopyTo(fileStream);
                    }
                    return new ObjectResult(new { status = "success" });
                }
            }
            return new ObjectResult(new { status = "fail" });

        }

        [HttpPost]
        public JsonResult GetAllExecutiveOfficer()
        {
            var data = _UploadRepository.GetAllExecutiveOfficer();
            return Json(data);
        }
        //

        //Services
        public IActionResult Service()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetServiceCategoryList()

        {
            var data = _UploadRepository.GetServicesList();
            return Json(data);
        }
        [HttpPost]
        public IActionResult AddServiceCategory(string name)
        {
            Int64 id = _UploadRepository.CheckCategory(name);
            if (id == 0)
            {

                string imageName = "NA";
                PublicUtilityCategory puc = new PublicUtilityCategory();
                puc.CategoryName = name;
                puc.ImageName = imageName;
                puc.CattypeId = 2;
                int status = _UploadRepository.savecategory(puc);
                if (status == 1)
                {

                    return new ObjectResult(new { status = "success" });
                }

            }
            else
            {
                return new ObjectResult(new { status = "Already exist" });

            }


            return new ObjectResult(new { status = "fail" });

        }

        //service category
        public IActionResult ServicesDetails()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetServiceDetails()
        {
            var data = _UploadRepository.GetServiceDetailsList();
            return Json(data);

        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetServiceCategoryListForDrpdown()

        {
            var data = _UploadRepository.GetServicesList();

            var listitem = new List<SelectListItem>();
            foreach (var item in data)
            {
                listitem.Add(new SelectListItem { Text = item.CategoryName, Value = item.Id.ToString() });
            }
            var newlist = listitem.OrderBy(x => x.Value).ToList();

            return Json(newlist);
        }
        [HttpPost]
        public IActionResult AddServiceDetails(string name, int catid, string description, IFormFile MyUploader, string urlname)
        {
            if (MyUploader != null && !string.IsNullOrEmpty(name))
            {
                Int64 id = 0;//_UploadRepository.CheckCategory(name);
                if (id == 0)
                {
                    Guid newGuid = Guid.NewGuid();
                    string imageName = newGuid.ToString();
                    string Imagepath = imageName + MyUploader.FileName;

                    Services sc = new Services();
                    sc.Name = name;
                    sc.Description = description;
                    sc.CatId = catid;
                    sc.UrlName = urlname;
                    sc.ImageNmae = Imagepath;
                    int status = _UploadRepository.saveServicedetail(sc);
                    if (status == 1)
                    {
                        string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "public/Banner");
                        string filePath = Path.Combine(uploadsFolder, Imagepath);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            MyUploader.CopyTo(fileStream);
                        }
                        return new ObjectResult(new { status = "success" });
                    }

                }
                else
                {
                    return new ObjectResult(new { status = "Already exist" });

                }

            }
            return new ObjectResult(new { status = "fail" });

            //
        }

        [HttpPost]
        public JsonResult DeleteServicedetails(int id)
        {
            var data = _UploadRepository.DeleteServicedetails(id);
            if (!string.IsNullOrEmpty(data))
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "public/Banner");
                string ExitingFile = Path.Combine(uploadsFolder, data);
                System.IO.File.Delete(ExitingFile);
            }
            return Json(new { status = "success" });
        }

        public IActionResult AddNewsEvent()
        {
            return View();
        }
        public IActionResult AtaGlance()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetAtaGlanceList()

        {
            var data = _UploadRepository.GetAtaGlanceList();
            return Json(data);
        }
        [HttpPost]
        public IActionResult Addataglance(string name,string value)
        {
            Int64 id = _UploadRepository.CheckAtaGlane(name);
            if (id == 0)
            {

               
                AtaGlance atg = new AtaGlance();
                atg.Name = name;
                atg.Value = value;
                int status = _UploadRepository.saveataglance(atg);
                if (status == 1)
                {

                    return new ObjectResult(new { status = "success" });
                }

            }
            else
            {
                return new ObjectResult(new { status = "Already exist" });

            }


            return new ObjectResult(new { status = "fail" });

        }
        [HttpPost]
        public JsonResult DeleteAtaGlance(int id)
        {
            var data = _UploadRepository.Deleteataglance(id);

            return Json(new { status = "success" });
        }
    }


}
