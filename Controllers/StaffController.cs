using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace WebBanMayTinh.Controllers
{
    public class StaffController : Controller
    {
        [Route("admin/staff")]
        [HttpGet]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            var staff = (from a in context.staff
                          select a).ToList();
            var alertStoreStaff = -1;
            if(HttpContext.Session.GetInt32("alertStoreStaff") != null) {
                alertStoreStaff = (int)HttpContext.Session.GetInt32("alertStoreStaff");
                HttpContext.Session.Remove("alertStoreStaff");
            }
            ViewData["staff"] = staff;  
            ViewData["alertStoreStaff"] = alertStoreStaff; 
            return View();
        }

        public string md5(string str) {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(str);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        [Route("admin/staff/store")]
        [HttpPost]
        public IActionResult Store()
        {
            var context = new Models.sanphamContext();
            var newUsers = context.staff;
            var data = new Models.staff{
                Name = Request.Form["name"],
                Password = md5(Request.Form["password"]),
            };
            newUsers.Add(data);
            context.SaveChanges();
            HttpContext.Session.SetInt32("alertStoreStaff",0);
            return RedirectToAction(actionName: "Index", controllerName: "Staff");
        }

        [Route("admin/staff/create")]
        [HttpGet]
        public IActionResult Create()
        {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            return View();
        }


        [Route("admin/staff/check-login")]
        [HttpPost]
        public IActionResult Login()
        {
            var context = new Models.sanphamContext();
            var user = context.staff.Where(s => s.Name == Request.Form["user"]).Where(s => s.Password == md5(Request.Form["password"])).FirstOrDefault();
            if(user != null) {
                HttpContext.Session.SetInt32("loginStaff",user.Id);
                return RedirectToAction(actionName: "CheckListOrder", controllerName: "Staff");
            }
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
        }


        [Route("staff/order")]
        [HttpGet]
        public IActionResult CheckListOrder() {
                    if(HttpContext.Session.GetInt32("loginStaff") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
                        var context = new Models.sanphamContext();
            var orders = (from a in context.Orders
                          select a).Where(s => s.Status == 1).ToList();
            ViewData["orders"] = orders;  
            return View();
        }

        [Route("staff/logout")]
        [HttpGet]
        public IActionResult LogoutPage()
        {
            if(HttpContext.Session.GetInt32("loginStaff") != null) 
            HttpContext.Session.Remove("loginStaff");
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
        }

        [Route("delivery-confirmation/{id}")]
        [HttpGet]
        public IActionResult DeliveryConfirmation(int id)
        {
            if(HttpContext.Session.GetInt32("loginStaff") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            var order =  context.Orders.Find(id);
            order.Status = 2;
            context.SaveChanges();

            var orderProduct =  context.OrderProducts.Where(s => s.IdOrder == id);
            foreach (var item in orderProduct)
            {
                var context1 = new Models.sanphamContext();
                var products = context1.Products.Find(item.IdProduct);
                products.Sold += item.Amount;
                context1.SaveChanges();
            }

            return RedirectToAction(actionName: "CheckListOrder", controllerName: "Staff");
        }

        [Route("staff/order/show/{id}")]
        [HttpGet]
        public IActionResult ShowOrderPage(int id)
        {
            if(HttpContext.Session.GetInt32("loginStaff") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            var orders =  context.Orders.Find(id);
            var order_product = context.OrderProducts.Where(s => s.IdOrder == orders.Id).ToList();
            ViewData["orders"] = orders;  
            ViewData["orders_product"] = order_product;
            return View();
        }
    }
}