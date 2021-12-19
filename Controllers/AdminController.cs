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
    [Route("admin")]
    public class AdminController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            return View();
        }

        [Route("login")]
        [HttpGet]
        public IActionResult LoginPage()
        {
            if(HttpContext.Session.GetInt32("loginAdmin") != null) 
            return RedirectToAction(actionName: "Index", controllerName: "Admin");
            return View();
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult LogoutPage()
        {
            if(HttpContext.Session.GetInt32("loginAdmin") != null) 
            HttpContext.Session.Remove("loginAdmin");
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
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

        [Route("check-login")]
        [HttpPost]
        public IActionResult Login()
        {
            var context = new Models.sanphamContext();
            var user = context.Admins.Where(s => s.Name == Request.Form["user-login"]).Where(s => s.Password == md5(Request.Form["password-login"])).FirstOrDefault();
            if(user != null) {
                HttpContext.Session.SetInt32("loginAdmin",user.Id);
                return RedirectToAction(actionName: "Index", controllerName: "Admin");
            }
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
        }


        [Route("income/{year}")]
        [HttpGet]
        public IActionResult IncomePage(int year) {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            var orders =  context.Orders.Where(s => s.Status == 2);
            var sum = 0;

            var january = 0;
            var february = 0; 
            var march = 0;
            var april = 0;
            var may = 0;
            var june = 0;
            var july = 0;
            var august = 0;
            var september = 0;
            var october = 0;
            var november = 0;
            var december = 0;

            foreach (var item in orders)
            {
                if(item.Time.Year == year) {
                var context1 = new Models.sanphamContext();
                var order_product = context1.OrderProducts.Where(s => s.IdOrder == item.Id);
                foreach (var products in order_product)
                {
                    var context2 = new Models.sanphamContext();
                    var product = context2.Products.Find(products.IdProduct);
                    sum += product.DiscountPrice;
                    if(item.Time.Month == 1)
                    january += product.DiscountPrice;
                    if(item.Time.Month == 2)
                    february += product.DiscountPrice;
                    if(item.Time.Month == 3)
                    march += product.DiscountPrice;
                    if(item.Time.Month == 4)
                    april += product.DiscountPrice;
                    if(item.Time.Month == 5)
                    may += product.DiscountPrice;
                    if(item.Time.Month == 6)
                    june += product.DiscountPrice;
                    if(item.Time.Month == 7)
                    july += product.DiscountPrice;
                    if(item.Time.Month == 8)
                    august += product.DiscountPrice;
                    if(item.Time.Month == 9)
                    september += product.DiscountPrice;
                    if(item.Time.Month == 10)
                    october += product.DiscountPrice;
                    if(item.Time.Month == 11)
                    november += product.DiscountPrice;
                    if(item.Time.Month == 12)
                    december += product.DiscountPrice;
                }
                }
            }
            ViewData["orders"] = sum;  
            ViewData["year"] = year;
            ViewData["january"] = january;
            ViewData["february"] = february;
            ViewData["march"] = march;
            ViewData["april"] = april;
            ViewData["may"] = may;
            ViewData["june"] = june;
            ViewData["july"] = july;
            ViewData["august"] = august;
            ViewData["september"] = september;
            ViewData["october"] = october;
            ViewData["november"] = november;
            ViewData["december"] = december;
            return View();
        }

        [Route("select-year")]
        [HttpPost]
        public IActionResult SelectYear() {
            return RedirectToAction(actionName: "IncomePage", controllerName: "Admin", new { year = Request.Form["datepicker"] });
        }

        [Route("income/{year}/{month}")]
        [HttpGet]
        public IActionResult MonthlyStatistics(int year, int month) {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            var orders =  context.Orders.Where(s => s.Status == 2).ToList();
            ViewBag.year = year;
            ViewData["orders"] = orders;
            ViewBag.month = month;
            return View(); 
        }
    }
}