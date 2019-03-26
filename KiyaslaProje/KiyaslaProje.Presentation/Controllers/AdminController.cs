using KiyaslaProje.Domain.Entities;
using KiyaslaProje.Infrasturcture;
using KiyaslaProje.Presentation.App_Start;
using KiyaslaProje.Service.Services;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiyaslaProje.Presentation.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUserService _userService;

        public AdminController(IUserService userService)
        {
            _userService = userService;
        }
       
        public ActionResult Index()
        {
            return View(_userService.GetAll().ToList());
        }

        public ActionResult _headerPartial()
        {
            return PartialView();
        }

        public ActionResult _sideBarPartial()
        {
            return PartialView();
        }

        public ActionResult Delete(ApplicationUser model)
        {
            _userService.Delete(model);
            return RedirectToAction("Index", "Admin");
        }
    }
}