namespace FourthWallCafe.LIB.Models;

public class OrderItemModel
{
    public int     OrderItemID   { get; set; }
    public int     OrderID       { get; set; }
    public int     ItemPriceID   { get; set; }
    public int     Quantity      { get; set; }
    public decimal ExtendedPrice { get; set; }
}
