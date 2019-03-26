using KiyaslaProje.Common.ViewModels;
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
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;

        public CategoryController(ICategoryService categoryService, IUserService userService)
        {
            _userService = userService;
            _categoryService = categoryService;
            ViewBag.Users = _userService.GetAll().ToList();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var cats = _categoryService.GetAllIncluding();
            return View(cats);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CategoryVM model)
        {
            _categoryService.Insert(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var cat = _categoryService.GetById(id);
            return View(cat);
        }

        [HttpPost]
        public ActionResult Edit(CategoryVM model)
        {
            _categoryService.Update(model);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}