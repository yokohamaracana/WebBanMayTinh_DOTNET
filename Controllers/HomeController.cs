using System.Threading;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PagedList;
using PagedList.Mvc;
using WebBanMayTinh.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;

namespace WebBanMayTinh.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            int idUser = -1;
            if(HttpContext.Session.GetInt32("login") != null) 
            idUser = (int)HttpContext.Session.GetInt32("login");
            var context = new Models.sanphamContext();
            var newProduct = (from a in context.Products
                          select a).ToList();
            var events = (from a in context.Events
                          select a).Take(4).ToList();
            var brands = (from a in context.Brands
                          select a).ToList();
            var sort_view_product = (from a in context.Products
                          select a).OrderByDescending(x=>x.View).Take(5).ToList();
            var sort_id_product =  (from a in context.Products
                          select a).OrderByDescending(x=>x.Id).Take(5).ToList();
            var sort_id_selled =  (from a in context.Products
                          select a).OrderByDescending(x=>x.Sold).Take(5).ToList();
            ViewBag.checkUsers = idUser;             
            ViewData["product"] = newProduct;  
            ViewData["brands"] = brands; 
            ViewData["events"] = events; 
            ViewData["sort_view_product"] = sort_view_product;
            ViewData["sort_id_product"] = sort_id_product; 
            ViewData["sort_id_selled"] =  sort_id_selled; 
            return View();
        }


        [Route("shop/{page?}")]
        [HttpGet]
        public IActionResult ShopPage(int page)
        {
            HttpContext.Session.Remove("count");
            if(page == null)
            page = 1;
            if(page <= 0)
            return RedirectToAction(actionName: "ShopPage", controllerName: "Home",new { page = 1 });

            var context = new Models.sanphamContext();
            var newProduct = from p in context.Products select p;

            // Lấy tổng số dòng dữ liệu
            var totalItems = newProduct.Count();
            // Tính số trang hiện thị (mỗi trang hiện thị ITEMS_PER_PAGE mục do bạn cấu hình = 10, 20 ...)
            var ITEMS_PER_PAGE = 5;
            int totalPages = (int)Math.Ceiling((double)totalItems / ITEMS_PER_PAGE);
            // Lấy phần tử trong  hang hiện tại (pageNumber là trang hiện tại - thường Binding từ route)
            
            if(page > totalPages)
            return RedirectToAction(actionName: "ShopPage", controllerName: "Home",new { page = totalPages });
            
            ViewBag.currentPage  = page;
            ViewBag.route  = "shop";
            ViewBag.countPages   = totalPages;


            var pros = newProduct.Skip(ITEMS_PER_PAGE * (page - 1)).Take(ITEMS_PER_PAGE).ToList();

            ViewData["product"] = pros;  
            return View();
        }

        [Route("product/{id}")]
        [HttpGet]
        public IActionResult SingleProduct(int id)
        {
            var context = new Models.sanphamContext();
            // var newBrand = (from a in context.Brands
            //               select a).ToList();
            var updateProduct = context.Products.Find(id);
            updateProduct.View = updateProduct.View + 1;
            context.SaveChanges();
            var product = context.Products.Find(id);
            var groupProduct = context.Products.Where(s => s.Brand == product.Brand).Where(s => s.Id != id).Take(6).ToList();
            var sort_id_product =  (from a in context.Products
                          select a).OrderBy(x=>x.Id).Take(6).ToList();
            var comments = context.Coments.Where(s => s.IdProduct == id).ToList();
            var avg = context.Rates.Average(x => x.Stars);
            var alertAddCard = -1;
            if(HttpContext.Session.GetInt32("alertAddCard") != null) {
                alertAddCard = (int)HttpContext.Session.GetInt32("alertAddCard");
                HttpContext.Session.Remove("alertAddCard");
            }
            ViewData["avg"] = avg;
            ViewData["GroupProduct"] =  groupProduct;       
            ViewData["product"] = product;
            ViewData["coments"] = comments;
            ViewData["sort_id_product"] = sort_id_product; 
            ViewData["alertAddCard"] =  alertAddCard;
            return View();
        }

        // [Route("testCart")]
        // [HttpPost]
        // public string testCart(int[] a) {
        //     return "Đây là: hahaha " +a[0];
        // }

        // [Route("testCart1")]
        // [HttpGet]
        // public string testCart1(string a) {
        //     return "Đây là: "+ a;
        // }


        [Route("cart")]
        [HttpGet]
        public IActionResult Cart()
        {
            if(HttpContext.Session.GetInt32("login") == null)
            return RedirectToAction(actionName: "LoginPage", controllerName: "Users");
            int idUser = (int)HttpContext.Session.GetInt32("login");
            var context = new Models.sanphamContext();
            var newCart = context.Carts;
            // var product = newCart.Where(s => s.IdUsers == idUser).Where(s => s.IdProduct == id).FirstOrDefault();
            var product_cart = newCart.Where(s => s.IdUsers == idUser).ToList();
            var alertDeleteCard = -1;
            if(HttpContext.Session.GetInt32("alertDeleteCard") != null) {
                alertDeleteCard = (int)HttpContext.Session.GetInt32("alertDeleteCard");
                HttpContext.Session.Remove("alertDeleteCard");
            }
            ViewData["alertDeleteCard"] =  alertDeleteCard;  
            ViewData["product"] = product_cart;
            ViewData["context"] = context;
            return View();
        }

        [Route("search")]
        [HttpGet]
        public IActionResult Search(string keyword) {
            var context = new Models.sanphamContext();
            var getProduct = context.Products;
            var products = getProduct.Where(s => s.Name.Contains(keyword)).ToList();
            ViewData["products"] = products;
            return View();
        }

        [Route("add-cart/{id}")]
        [HttpPost]
        public IActionResult AddCart(int id)
        {
            if(HttpContext.Session.GetInt32("login") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Users");
            int idUser = (int)HttpContext.Session.GetInt32("login");


            var context = new Models.sanphamContext();
            var newCart = context.Carts;
            var user = newCart.Where(s => s.IdUsers == idUser).Where(s => s.IdProduct == id).FirstOrDefault();
            if(user != null) {
                user.Amount = Int32.Parse(Request.Form["quantity"]) + user.Amount;
            }
            else {
                // [Uploads Data]
                var data = new Models.Cart {
                    IdUsers = idUser,
                    IdProduct = id,
                    Amount = Int32.Parse(Request.Form["quantity"]),
                };
                newCart.Add(data);
            }
            context.SaveChanges();
            HttpContext.Session.SetInt32("alertAddCard",0);
            // [Redirects]
            return RedirectToAction(actionName: "SingleProduct", controllerName: "Home",new {id = id});
        }

        [Route("delete-cart/{id}")]
        [HttpGet]
        public IActionResult DeleteCart(int id) {
            if(HttpContext.Session.GetInt32("login") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Users");
            int idUser = (int)HttpContext.Session.GetInt32("login");
            var context = new Models.sanphamContext();
            var newCart = context.Carts;
            var checkCart = newCart.Where(s => s.IdUsers == idUser).Where(s => s.Id == id).FirstOrDefault();
            if(checkCart != null) {
                var carts = newCart.Find(id);
                context.Carts.Remove(carts);
                context.SaveChanges();
            }
            HttpContext.Session.SetInt32("alertDeleteCard",0);
            return RedirectToAction(actionName: "Cart", controllerName: "Home");
        }


        [Route("CheckOut")]
        [HttpGet]

        public IActionResult CheckOut()
        {
            if(HttpContext.Session.GetInt32("login") == null)
            return RedirectToAction(actionName: "LoginPage", controllerName: "Users");
            int idUser = (int)HttpContext.Session.GetInt32("login");

            var context = new Models.sanphamContext();
            var newCart = context.Carts;
            // var product = newCart.Where(s => s.IdUsers == idUser).Where(s => s.IdProduct == id).FirstOrDefault();
            var product_cart = newCart.Where(s => s.IdUsers == idUser).ToList();
            ViewData["product"] = product_cart;
            // HttpContext.Session.SetInt32("count",12);
            return View();
        }

        [Route("other/store")]
        [HttpPost]
        public IActionResult OtherStore()
        {
            if(HttpContext.Session.GetInt32("login") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Users");
            int idUser = (int)HttpContext.Session.GetInt32("login");
            var context = new Models.sanphamContext();
            var newOther = context.Orders;
            var newOrderProduct = context.OrderProducts;
            var newCart = context.Carts;
            if(context.Carts.FirstOrDefault() == null)
            return RedirectToAction(actionName: "Cart", controllerName: "Home");
            var data = new Models.Order{
                IdUser = idUser,
                Status = 0,
                Name = Request.Form["nameOther"],
                Address = Request.Form["addressOther"],
                City = Request.Form["CityOther"],
                Phone = Request.Form["phoneOther"],
                OtherNote = Request.Form["noteOther"],
                District = Request.Form["distristOther"],
                Time = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"))
            };
            newOther.Add(data);
            context.SaveChanges();

            var idOther = context.Orders.OrderByDescending(p => p.Time).FirstOrDefault();

            var product_cart = newCart.Where(s => s.IdUsers == idUser).ToList();
            foreach (var item in product_cart)
            {
                var dataOrderProduct = new Models.OrderProduct{
                    IdOrder = idOther.Id,
                    IdProduct = item.IdProduct,
                    IdUsers = idUser,
                    Amount = item.Amount,
                    Quantity = item.Amount
                };
                newOrderProduct.Add(dataOrderProduct);

                context.SaveChanges();
            }

            foreach (var item in product_cart)
            {
                var delete = newCart.Find(item.Id);
                newCart.Remove(delete);
                context.SaveChanges();
            }

            return RedirectToAction(actionName: "LoginPage", controllerName: "Users");
        }


        [Route("history")]
        [HttpGet]
        public IActionResult HistoryPage() {
            if(HttpContext.Session.GetInt32("login") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Users");
            int idUser = (int)HttpContext.Session.GetInt32("login");
            var context = new Models.sanphamContext();
            var history = context.Orders.Where(s => s.IdUser == idUser).ToList();
            ViewData["history"] = history;
            return View();
        }

        [Route("order/{id}")]
        [HttpGet]
        public IActionResult ShowOrderPage(int id)
        {
            if(HttpContext.Session.GetInt32("login") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Users");
            var context = new Models.sanphamContext();
            var orders =  context.Orders.Find(id);
            var order_product = context.OrderProducts.Where(s => s.IdOrder == orders.Id).ToList();
            ViewData["orders"] = orders;  
            ViewData["orders_product"] = order_product;
            return View();
        }

        [Route("rate/{id}")]
        [HttpPost]
        public IActionResult AddRate(int id) {
            if(HttpContext.Session.GetInt32("login") == null) 
            return RedirectToAction(actionName: "LoginPage", controllerName: "Users");

            int idUser = (int)HttpContext.Session.GetInt32("login");
            var context = new Models.sanphamContext();
            var newComent = context.Coments;
            var newRating = context.Rates;
            // [Uploads Data]
            var data = new Models.Coment {
                IdProduct = id,
                IdUser = idUser,
                Content = Request.Form["content"],
            };
            newComent.Add(data);
            context.SaveChanges();

            var dataRating = new Models.Rate {
                IdProduct = id,
                IdUser = idUser,
                Stars = Int32.Parse(Request.Form["rating"]),
            };
            newRating.Add(dataRating);
            context.SaveChanges();
            return  RedirectToAction(actionName: "SingleProduct", controllerName: "Home",new { id = id });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
