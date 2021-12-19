using System.ComponentModel.Design.Serialization;
using System.Security.AccessControl;
using System.Net.Cache;
using System.Threading;
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
    [Route("admin/product")]
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment _enviroment;
        // // private readonly ProductService _productService; 
        public ProductController(IWebHostEnvironment enviroment)
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
            var product = (from a in context.Products
                          select a).ToList();
            var alertStoreProduct = -1;
            var alertUpdateProduct = -1;
            var alertDeleteProduct = -1;
            if(HttpContext.Session.GetInt32("alertStoreProduct") != null) {
                alertStoreProduct = (int)HttpContext.Session.GetInt32("alertStoreProduct");
                HttpContext.Session.Remove("alertStoreProduct");
            }
            if(HttpContext.Session.GetInt32("alertUpdateProduct") != null) {
                alertUpdateProduct = (int)HttpContext.Session.GetInt32("alertUpdateProduct");
                HttpContext.Session.Remove("alertUpdateProduct");
            }
            if(HttpContext.Session.GetInt32("alertDeleteProduct") != null) {
                alertDeleteProduct = (int)HttpContext.Session.GetInt32("alertDeleteProduct");
                HttpContext.Session.Remove("alertDeleteProduct");
            }
            ViewData["alertStoreProduct"] =  alertStoreProduct;  
            ViewData["alertUpdateProduct"] =  alertUpdateProduct;  
            ViewData["alertDeleteProduct"] =  alertDeleteProduct;
            ViewData["product"] = product;  
            return View();
        }

        [Route("create")]
        [HttpGet]
        public IActionResult Create()
        {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            var newBrand = (from a in context.Brands
                          select a).ToList();
            ViewData["brand"] = newBrand;  
            return View();
        }


        [Route("store")]
        [HttpPost]
        public IActionResult Store()
        {
            var context = new Models.sanphamContext();
            var newProduct = context.Products;

            // [Checks File]
            var imageUploads = Request.Form.Files["image"];
            var getNameImage = "defaulse.jpg";
            if (imageUploads != null) {
                var newNameUploads = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + imageUploads.FileName;
                var fileUploads = Path.Combine (_enviroment.ContentRootPath,"wwwroot", "uploads", newNameUploads);
                using var fileStream = new FileStream (fileUploads, FileMode.Create);
                imageUploads.CopyTo(fileStream);
                getNameImage = newNameUploads;
            }
            

            // [Uploads Data]
            var data = new Models.Product{
                Name = Request.Form["name"],
                Image = getNameImage,
                Price = Int32.Parse(Request.Form["price"]),
                // Price = 10,
                ShortDesc = Request.Form["short_desc"],
                Desc = Request.Form["desc"],
                DiscountPrice = Int32.Parse(Request.Form["discount_price"]),
                Brand = Int32.Parse(Request.Form["brand"]),
                // Brand = 1,
                View = 0,
            };
            newProduct.Add(data);
            context.SaveChanges();
            HttpContext.Session.SetInt32("alertStoreProduct",0);
            // [Redirects]
            return RedirectToAction(actionName: "Index", controllerName: "Product");
            
            // ViewBag.name =  getNameImage;
            // return View("Views/Product/test.cshtml");
        }

        [Route("edit/{id}")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            var newBrand = (from a in context.Brands
                      select a).ToList();
            var product = context.Products.Find(id);
            ViewData["product"] = product;
            ViewData["brand"] = newBrand;  
            return View();
        }

        [Route("update/{id?}")]
        [HttpPost]
        public IActionResult Update(int? id)
        {
            var context = new Models.sanphamContext();
            var newProduct = context.Products;

            // [Checks File]
            var imageUploads = Request.Form.Files["image"];
            var getNameImage = "";
            if (imageUploads != null) {
                var newNameUploads = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + imageUploads.FileName;
                var fileUploads = Path.Combine (_enviroment.ContentRootPath,"wwwroot", "uploads", newNameUploads);
                using var fileStream = new FileStream (fileUploads, FileMode.Create);
                imageUploads.CopyTo(fileStream);
                getNameImage = newNameUploads;
            }

            var updateProduct = newProduct.Find(id);
            updateProduct.Name = Request.Form["name"];
            if(getNameImage != "")
            updateProduct.Image = getNameImage;
            updateProduct.Price = Int32.Parse(Request.Form["price"]);
            updateProduct.ShortDesc = Request.Form["short_desc"];
            updateProduct.Desc = Request.Form["desc"];
            updateProduct.DiscountPrice = Int32.Parse(Request.Form["discount_price"]);
            updateProduct. Brand = Int32.Parse(Request.Form["brand"]);

            context.SaveChanges();
            HttpContext.Session.SetInt32("alertUpdateProduct",0);
            // [Redirects]
            return RedirectToAction(actionName: "Index", controllerName: "Product", new { id = id });
            
        }

        [Route("destroy/{id}")]
        [HttpGet]
        public IActionResult Destroy(int? id)
        {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            var delete = context.Products.Find(id);
            context.Products.Remove(delete);
            context.SaveChanges();
            HttpContext.Session.SetInt32("alertDeleteProduct",0);
            return RedirectToAction(actionName: "Index", controllerName: "Product");
        }
    }
}


