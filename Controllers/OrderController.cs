using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebBanMayTinh.Controllers
{
    [Route("admin/order")]
    public class OrderController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            var context = new Models.sanphamContext();
            var orders = (from a in context.Orders
                          select a).Where(s => s.Status < 2).ToList();
            ViewData["orders"] = orders;  
            return View();
        }


        [Route("admin/order/order-delivered")]
        [HttpGet]
        public IActionResult OrderDelivered()
        {
            var context = new Models.sanphamContext();
            var orders = (from a in context.Orders
                          select a).Where(s => s.Status == 2).ToList();
            ViewData["orders"] = orders;  
            return View();
        }

        [Route("show/{id}")]
        [HttpGet]
        public IActionResult Show(int id)
        {
            var context = new Models.sanphamContext();
            var orders =  context.Orders.Find(id);
            var order_product = context.OrderProducts.Where(s => s.IdOrder == orders.Id).ToList();
            ViewData["orders"] = orders;  
            ViewData["orders_product"] = order_product;
            return View();
        }

        

        [Route("destroy/{id}")]
        [HttpGet]
        public IActionResult Destroy(int id)
        {
            var context = new Models.sanphamContext();
            var order_product = context.OrderProducts.Where(s => s.IdOrder == id);
            context.OrderProducts.RemoveRange(order_product);
            var order =  context.Orders.Find(id);
            context.Orders.Remove(order);
            context.SaveChanges();
            return RedirectToAction(actionName: "Index", controllerName: "Order");
        }

        [Route("order-browsing/{id}")]
        [HttpGet]
        public IActionResult OrderBrowsing(int id)
        {
            var context = new Models.sanphamContext();
            var order =  context.Orders.Find(id);
            order.Status = 1;
            context.SaveChanges();
            return RedirectToAction(actionName: "Index", controllerName: "Order");
        }

    }
}