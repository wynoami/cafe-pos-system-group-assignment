using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;
using FourthWallCafe.Web.Services;

namespace FourthWallCafe.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var mockService = new MockCafeService();
            var viewModel = mockService.GetHomeData();

            return View(viewModel);
        }
    }
}