using KiyaslaProje.Common.ViewModels;
using KiyaslaProje.Infrasturcture;
using KiyaslaProje.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiyaslaProje.Presentation.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;

        public ProductController(IProductService productService, ICategoryService categoryService, IUserService userService)
        {
            _userService = userService;
            _categoryService = categoryService;
            _productService = productService;

            ViewBag.Users = _userService.GetAll().ToList();
            ViewBag.Categories = _categoryService.GetAll().OrderBy(i => i.Title).ToList();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var prods = _productService.GetAllIncluding();
            return View(prods);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductVM model)
        {
            _productService.Insert(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var cat = _productService.GetById(id);
            return View(cat);
        }

        [HttpPost]
        public ActionResult Edit(ProductVM model)
        {
            _productService.Update(model);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}