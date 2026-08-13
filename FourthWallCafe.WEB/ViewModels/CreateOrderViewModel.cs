using System.Collections.Generic;

namespace FourthWallCafe.Web.ViewModels
{
    public class CreateOrderViewModel
    {
        public List<ServerViewModel> ActiveServers { get; set; } =
        new List<ServerViewModel>();
    }

    public class ServerViewModel
    {
        public int ServerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}