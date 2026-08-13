using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;
using FourthWallCafe.Web.ViewModels;
using FourthWallCafe.Web.Services;
using System.Reflection.PortableExecutable;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace FourthWallCafe.Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            // Later will call: var menu = _orderService.GetMenuItems();
            return View();
        }
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
        public IActionResult Details(int id, int? categoryId = null)
        {
            // Simulating data that will eventually be oulled from the backend database via a Service
            var viewModel = new OrderDetailsViewModel
            {
                OrderId = id,

                // Mock Categories to buildthe navigation
                MenuCategories = new List<CategoryViewModel>
                {
                    new CategoryViewModel { CategoryId = 1, Name = "Espresso Bar" },
                    new CategoryViewModel { CategoryId = 2, Name = "Pastries" },
                    new CategoryViewModel { CategoryId = 3, Name = "Sandwiches" }
                },

                // Mock Menu Items tied to their respective CategoryIds
                MenuItems = new List<MenuItemViewModel>
                {
                    new MenuItemViewModel { ItemId = 1, CategoryId = 1, Name = "Latte", CurrentPrice = 4.50m },
                    new MenuItemViewModel { ItemId = 2, CategoryId = 1, Name = "Americano", CurrentPrice = 3.00m },
                    new MenuItemViewModel { ItemId = 3, CategoryId = 2, Name = "Butter Croissant", CurrentPrice = 3.50m },
                    new MenuItemViewModel { ItemId = 4, CategoryId = 2, Name = "Blueberry Muffin", CurrentPrice = 3.25m },
                    new MenuItemViewModel { ItemId = 5, CategoryId = 3, Name = "Turkey Club", CurrentPrice = 8.50m }
                },

                // Mocking a ticket that already has one item added to it
                CurrentOrderItems = new List<OrderItemViewModel>
                {
                    new OrderItemViewModel { OrderItemId = 1, ItemName = "Latte", Quantity = 1, Subtotal = 4.50m}
                },

                OrderTotal = 4.50m
            };

            if (categoryId.HasValue)
            {
                viewModel.MenuItems = viewModel.MenuItems
                                        .Where(m => m.CategoryId == categoryId.Value)
                                        .ToList();
            }
            
            return View(viewModel);
        }

         // POST: Orders/AddItem
            [HttpPost]
            public IActionResult AddItem(int orderId, int itemId)
            {
                // Eventually we will pass these variables to the backend service (_cafeLookupService.AddItemToTicket(orderId, itemId))
                //The PRG Pattern: After processing a POST, always redirect back to a GET request
                return RedirectToAction("Details", new { id = orderId });
            }

            [HttpGet]
            public IActionResult Checkout(int id)
        {
            // Later I will fetch the final order total from _orderService
            ViewBag.OrderId = id;

            return View();
        }

        [HttpPost]
        public IActionResult ProcessPayment(int orderId,string paymentMethod)
        {
            // Later _orderService.CloseTicket(orderId, paymentMethod);
            return RedirectToAction("Index", "Home");
        }
    }
}