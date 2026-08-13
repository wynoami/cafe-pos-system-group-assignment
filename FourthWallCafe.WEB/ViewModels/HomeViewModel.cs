using System.Collections.Generic;

namespace FourthWallCafe.Web.ViewModels
{
    public class HomeViewModel
    {
        public List<ActiveOrderViewModel> OpenOrders { get; set; } =
        new List<ActiveOrderViewModel>();
    }

    public class ActiveOrderViewModel
    {
        public int OrderId { get; set; }
    }
}