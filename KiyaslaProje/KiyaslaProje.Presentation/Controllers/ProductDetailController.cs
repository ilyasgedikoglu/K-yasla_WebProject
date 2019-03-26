using KiyaslaProje.Common.ViewModels;
using KiyaslaProje.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiyaslaProje.Presentation.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly IProductDetailService _productDetailService;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;

        public ProductDetailController(IProductDetailService productDetailService, IUserService userService, ICategoryService categoryService, IProductService productService)
        {
            _userService = userService;
            _productDetailService = productDetailService;
            _productService = productService;
            _categoryService = categoryService;

            ViewBag.Users = _userService.GetAll().ToList();
            ViewBag.Categories = _categoryService.GetAll().OrderBy(i => i.Title).ToList();
            ViewBag.Products = _productService.GetAll().OrderBy(i => i.Title).ToList();
        }

        public ActionResult Index()
        {
            var detail = _productDetailService.GetAllIncluding().OrderByDescending(i => i.CreatedDate).ToList();
            return View(detail);
        }

        [HttpGet]
        public ActionResult GetById(int id)
        {
            var pdetails = _productDetailService.GetAllIncluding().Where(i=>i.ProductId==id).FirstOrDefault();
            return View(pdetails);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductDetailVM model)
        {
            _productDetailService.Insert(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var prod = _productDetailService.GetById(id);
            return View(prod);
        }

        [HttpPost]
        public ActionResult Edit(ProductDetailVM model)
        {
            _productDetailService.Update(model);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _productDetailService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}