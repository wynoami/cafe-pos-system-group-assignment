using System.Collections.Generic;

namespace FourthWallCafe.Web.ViewModels
{
    // The Master Model
    public class OrderDetailsViewModel
    {
        public int OrderId { get; set; }
        public List<CategoryViewModel> MenuCategories { get; set; } = new List<CategoryViewModel>();
        public List<MenuItemViewModel> MenuItems { get; set; } = new List<MenuItemViewModel>();
        public List<OrderItemViewModel> CurrentOrderItems { get; set; } = new List<OrderItemViewModel>();
        public decimal OrderTotal { get; set; }
    }

    // The sub-models that define the shape of the lists above
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }

    public class MenuItemViewModel
    {
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal CurrentPrice { get; set; }
    }

    public class OrderItemViewModel
    {
        public int OrderItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
    }
}