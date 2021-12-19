using System.Reflection.PortableExecutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace WebBanMayTinh.Controllers
{
    [Route("admin/brand")]
    public class BrandController : Controller
    {
    
        private readonly IWebHostEnvironment _enviroment;
        // // private readonly ProductService _productService; 
        public BrandController(IWebHostEnvironment enviroment)
        {
            _enviroment = enviroment;
            // _productService = productService;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            var newBrand = (from a in context.Brands
                          select a).ToList();
            var alertStoreBrand = -1;
            var alertUpdateBrand = -1;
            var alertDeleteBrand = -1;
            if(HttpContext.Session.GetInt32("alertStoreBrand") != null) {
                alertStoreBrand = (int)HttpContext.Session.GetInt32("alertStoreBrand");
                HttpContext.Session.Remove("alertStoreBrand");
            }
            if(HttpContext.Session.GetInt32("alertUpdateBrand") != null) {
                alertUpdateBrand = (int)HttpContext.Session.GetInt32("alertUpdateBrand");
                HttpContext.Session.Remove("alertUpdateBrand");
            }
            if(HttpContext.Session.GetInt32("alertDeleteBrand") != null) {
                alertDeleteBrand = (int)HttpContext.Session.GetInt32("alertDeleteBrand");
                HttpContext.Session.Remove("alertDeleteBrand");
            }
            ViewData["alertStoreBrand"] =  alertStoreBrand;  
            ViewData["alertUpdateBrand"] =  alertUpdateBrand;  
            ViewData["alertDeleteBrand"] =  alertDeleteBrand;
            ViewData["brand"] = newBrand;              
            return View();
        }


        [Route("create")]
        [HttpGet]
        public IActionResult Create()
        {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            return View();
        }


        [Route("store")]
        [HttpPost]
        public IActionResult Store()
        {
            var context = new Models.sanphamContext();
            var newProduct = context.Brands;

            // // [Checks File]
            var imageUploads = Request.Form.Files["imageBrand"];
            var getNameImage = "defaulse.jpg";
            if (Request.Form.Files["imageBrand"] != null) {
                var newNameUploads = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + imageUploads.FileName;
                var fileUploads = Path.Combine (_enviroment.ContentRootPath,"wwwroot", "uploads","brands" ,newNameUploads);
                using var fileStream = new FileStream (fileUploads, FileMode.Create);
                imageUploads.CopyTo(fileStream);
                getNameImage = newNameUploads;
            }

            // // [Uploads Data]
            var data = new Models.Brand{
                Name = Request.Form["name"],
                Image = getNameImage
            };
            newProduct.Add(data);
            context.SaveChanges();
            HttpContext.Session.SetInt32("alertStoreBrand",0);
            return RedirectToAction(actionName: "Index", controllerName: "Brand");
        }

        [Route("edit/{id}")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            var brand = context.Brands.Find(id);
            ViewData["brand"] = brand;
            return View();
        }

        [Route("update/{id?}")]
        [HttpPost]
        public IActionResult Update(int? id)
        {
            var context = new Models.sanphamContext();
            var newProduct = context.Brands;

            // [Checks File]
            var imageUploads = Request.Form.Files["imageBrand"];
            var getNameImage = "";
            if (imageUploads != null) {
                var newNameUploads = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + imageUploads.FileName;
                var fileUploads = Path.Combine (_enviroment.ContentRootPath,"wwwroot", "uploads","brands", newNameUploads);
                using var fileStream = new FileStream (fileUploads, FileMode.Create);
                imageUploads.CopyTo(fileStream);
                getNameImage = newNameUploads;
            }

            var updateBrands = newProduct.Find(id);
            updateBrands.Name = Request.Form["name"];
            if(getNameImage != "")
            updateBrands.Image = getNameImage;
            context.SaveChanges();
            HttpContext.Session.SetInt32("alertUpdateBrand",0);

            // [Redirects]
            return RedirectToAction(actionName: "Index", controllerName: "Brand", new { id = id });
            
        }

        [Route("destroy/{id}")]
        [HttpGet]
        public IActionResult Destroy(int? id) {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            var delete = context.Brands.Find(id);
            context.Brands.Remove(delete);
            context.SaveChanges();
            HttpContext.Session.SetInt32("alertDeleteBrand",0);
            return RedirectToAction(actionName: "Index", controllerName: "Brand");
        }
    }
}