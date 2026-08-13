using System.Collections.Generic;
using FourthWallCafe.Web.ViewModels;

namespace FourthWallCafe.Web.Services
{
    public class MockCafeService
    {
        public HomeViewModel GetHomeData()
        {
            var model = new HomeViewModel();
            model.OpenOrders.Add(new ActiveOrderViewModel { OrderId = 67 });
            model.OpenOrders.Add(new ActiveOrderViewModel { OrderId = 68 });
            model.OpenOrders.Add(new ActiveOrderViewModel { OrderId = 69 });

            return model;
        }
    }
}