using System.ComponentModel.Design.Serialization;
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
    [Route("admin/event")]
    public class EventController : Controller
    {
        private readonly IWebHostEnvironment _enviroment;
        // // private readonly ProductService _productService; 
        public EventController(IWebHostEnvironment enviroment)
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
            var events = (from a in context.Events
                          select a).ToList();
            var alertStoreEvent = -1;
            var alertUpdateEvent = -1;
            var alertDeleteEvent = -1;
            if(HttpContext.Session.GetInt32("alertStoreEvent") != null) {
                alertStoreEvent = (int)HttpContext.Session.GetInt32("alertStoreEvent");
                HttpContext.Session.Remove("alertStoreEvent");
            }
            if(HttpContext.Session.GetInt32("alertUpdateEvent") != null) {
                alertUpdateEvent = (int)HttpContext.Session.GetInt32("alertUpdateEvent");
                HttpContext.Session.Remove("alertUpdateEvent");
            }
            if(HttpContext.Session.GetInt32("alertDeleteEvent") != null) {
                alertDeleteEvent = (int)HttpContext.Session.GetInt32("alertDeleteEvent");
                HttpContext.Session.Remove("alertDeleteEvent");
            }
            ViewData["alertStoreEvent"] =  alertStoreEvent;  
            ViewData["alertUpdateEvent"] =  alertUpdateEvent;  
            ViewData["alertDeleteEvent"] =  alertDeleteEvent;
            ViewData["events"] = events;  
            return View();
        }
        [Route("create")]
        [HttpGet]
        public IActionResult Create()
        {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            return View();
        }


        [Route("store")]
        [HttpPost]
        public IActionResult Store()
        {
            var context = new Models.sanphamContext();
            var newProduct = context.Events;

            // [Checks File]
            var imageUploads = Request.Form.Files["image"];
            var getNameImage = "defaulse.jpg";
            if (imageUploads != null) {
                var newNameUploads = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + imageUploads.FileName;
                var fileUploads = Path.Combine (_enviroment.ContentRootPath,"wwwroot", "uploads","events", newNameUploads);
                using var fileStream = new FileStream (fileUploads, FileMode.Create);
                imageUploads.CopyTo(fileStream);
                getNameImage = newNameUploads;
            }
            

            // [Uploads Data]
            var data = new Models.Event{
                Name = Request.Form["name"],
                Image = getNameImage,
            };
            newProduct.Add(data);
            context.SaveChanges();

            HttpContext.Session.SetInt32("alertStoreEvent",0);
            // [Redirects]
            return RedirectToAction(actionName: "Index", controllerName: "Event");
            
            // ViewBag.name =  getNameImage;
            // return View("Views/Product/test.cshtml");
        }

        [Route("edit/{id}")]
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            var events = context.Events.Find(id);
            ViewData["event"] = events;
            return View();
        }

         [Route("update/{id?}")]
        [HttpPost]
        public IActionResult Update(int? id)
        {
            var context = new Models.sanphamContext();
            var events = context.Events;

            // [Checks File]
            var imageUploads = Request.Form.Files["image"];
            var getNameImage = "";
            if (imageUploads != null) {
                var newNameUploads = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + imageUploads.FileName;
                var fileUploads = Path.Combine (_enviroment.ContentRootPath,"wwwroot", "uploads", "events" ,newNameUploads);
                using var fileStream = new FileStream (fileUploads, FileMode.Create);
                imageUploads.CopyTo(fileStream);
                getNameImage = newNameUploads;
            }

            var updateEvent = events.Find(id);
            updateEvent.Name = Request.Form["name"];
            if(getNameImage != "")
            updateEvent.Image = getNameImage;

            context.SaveChanges();
            HttpContext.Session.SetInt32("alertUpdateEvent",0);
            // [Redirects]
            return RedirectToAction(actionName: "Index", controllerName: "Event", new { id = id });
        }

        [Route("destroy/{id}")]
        [HttpGet]
        public IActionResult Destroy(int? id)
        {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            var delete = context.Events.Find(id);
            context.Events.Remove(delete);
            context.SaveChanges();
            HttpContext.Session.SetInt32("alertDeleteEvent",0);
            return RedirectToAction(actionName: "Index", controllerName: "Event");
        }

    }
}
