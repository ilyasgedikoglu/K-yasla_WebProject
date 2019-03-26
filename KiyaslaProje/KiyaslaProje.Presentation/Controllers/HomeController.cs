using KiyaslaProje.Common.ViewModels;
using KiyaslaProje.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiyaslaProje.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGeneralInformationService _generalInformationService;
        private readonly IComplaintService _complaintService;
        private readonly IComplaintService _productService;

        public HomeController(IGeneralInformationService generalInformationService, IComplaintService complaintService, IComplaintService productService)
        {
            _generalInformationService = generalInformationService;
            _complaintService = complaintService;
            _productService = productService;      
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _userHeaderPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult CreateComplaint(ComplaintVM model)
        {
            _complaintService.Insert(model);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult _userSliderPartial()
        {
            return PartialView();
        }

        //public ActionResult _compareView()
        //{
        //    ViewBag.Products = _productService.GetAll().OrderBy(i => i.Title).ToList();
        //    return PartialView();
        //}
    }
}