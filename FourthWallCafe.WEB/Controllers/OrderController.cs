using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;
using FourthWallCafe.Web.ViewModels;
using System.Reflection.PortableExecutable;

namespace FourthWallCafe.Web.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new CreateOrderViewModel
            {
                ActiveServers = new List<ServerViewModel>
                {
                    new ServerViewModel { ServerId = 1, FirstName = "Alice", LastName = "Smith" },
                    new ServerViewModel { ServerId = 2, FirstName = "Bob", LastName = "Jones" },
                    new ServerViewModel { ServerId = 3, FirstName = "Charlie", LastName = "Brown" },
                }
            };
            return View(viewModel);
        }

        // POST: Orders/Create (handles the buton click)
        [HttpPost]
        public IActionResult Create(int serverId)
        {
            // eventually will call int newOrderId = _orderService.CreateOrder(serverId);
            //For now this is a mock creation of a new order with ID 101
            int newOrderId = 101;

            // the system creates a new order and navigates to its details page by ivoking the RedirectToAction() method with the order id
            return RedirectToAction("Details", new { id = newOrderId });
        }

        // GET: Orders/Details/101 (the landing page after creation)
        [HttpGet]
        public IActionResult Details(int id)
        {
            ViewBag.OrderId = id;
            return View();
        }
    }
}