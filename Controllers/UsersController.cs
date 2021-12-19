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
    public class UsersController : Controller
    {
        [Route("admin/users")]
        [HttpGet]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("loginAdmin") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Admin");
            var context = new Models.sanphamContext();
            var users = (from a in context.Users
                          select a).ToList();
            ViewData["users"] = users;  
            return View();
        }

        [Route("login")]
        [HttpGet]
        public IActionResult LoginPage()
        {
            if(HttpContext.Session.GetInt32("login") != null) 
            return RedirectToAction(actionName: "Index", controllerName: "Home");
            var alertLogin = -1;
            var alertRegister = -1;
            if(HttpContext.Session.GetInt32("alertLogin") != null) {
                alertLogin = (int)HttpContext.Session.GetInt32("alertLogin");
                HttpContext.Session.Remove("alertLogin");
            }
            if(HttpContext.Session.GetInt32("alertRegister") != null) {
                alertRegister = (int)HttpContext.Session.GetInt32("alertRegister");
                HttpContext.Session.Remove("alertRegister");
            }
            ViewData["alertLogin"] = alertLogin;
            ViewData["alertRegister"] = alertRegister;
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

        [Route("check-login")]
        [HttpPost]
        public IActionResult Login()
        {
            var context = new Models.sanphamContext();
            var newProduct = context.Users;
            var user = context.Users.Where(s => s.Email == Request.Form["user-login"]).Where(s => s.Password == md5(Request.Form["password-login"])).FirstOrDefault();
            if(user != null) {
                HttpContext.Session.SetInt32("login",user.Id);
                return RedirectToAction(actionName: "Index", controllerName: "Home");
            }
            HttpContext.Session.SetInt32("alertLogin",0);
            return RedirectToAction(actionName: "LoginPage", controllerName: "Users");
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult LogoutPage()
        {
            if(HttpContext.Session.GetInt32("login") != null) 
            HttpContext.Session.Remove("login");
            return RedirectToAction(actionName: "LoginPage", controllerName: "Users");
        }

        [Route("register")]
        [HttpPost]
        public IActionResult Register()
        {
            var context = new Models.sanphamContext();
            var newUsers = context.Users;
            var data = new Models.User{
                Email = Request.Form["email-register"],
                Password = md5(Request.Form["password-register"]),
                PhoneNumber = Request.Form["phone-number-register"],
            };
            newUsers.Add(data);
            context.SaveChanges();
            HttpContext.Session.SetInt32("alertRegister",0);
            return RedirectToAction(actionName: "LoginPage", controllerName: "Users");
        }
    }
}