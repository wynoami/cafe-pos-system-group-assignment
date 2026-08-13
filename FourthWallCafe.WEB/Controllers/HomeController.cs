using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;
using FourthWallCafe.Web.Services;
using FourthWallCafe.Web.ViewModels;

namespace FourthWallCafe.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderService _orderService;

        public HomeController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            var viewModel = _orderService.GetHomeData();

            return View(viewModel);
        }
    }
}