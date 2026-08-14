namespace FourthWallCafe.LIB.Utils;

public class UpdateData
{
    // GENERIC
    public const string ID   = "id";
    public const string Name = "name";
    public const string Desc = "desc";

    // IDs
    public const string OrderID     = "orderid";
    public const string CategoryID  = "categoryid";
    public const string ItemID      = "itemid";
    public const string PriceID     = "priceid";
    public const string OrderItemID = "orderitemid";
    public const string PaymentID   = "paymentid";
    public const string ServerID    = "serverid";
    public const string TimeOfDayID = "timeofdayid";

    // CafeOrder
    public const string OrderDate = "orderdate";
    public const string SubTotal  = "subtotal";
    public const string Tax       = "tax";
    public const string Tip       = "tip";
    public const string AmountDue = "amountdue";

    // ItemPrice
    public const string Price     = "price";
    public const string StartDate = "startdate";
    public const string EndDate   = "enddate";

    // OrderItem
    public const string Quantity      = "quantity";
    public const string ExtendedPrice = "extendedprice";

    // Server
    public const string FirstName = "firstname";
    public const string LastName  = "lastname";
    public const string HireDate  = "hiredate";
    public const string TermDate  = "termdate";
    public const string DoB       = "birth";

    public Dictionary<string, string> Index = new()
    {
        [ID]            = string.Empty,
        [Name]          = string.Empty,
        [Desc]          = string.Empty,
        [OrderID]       = string.Empty,
        [CategoryID]    = string.Empty,
        [ItemID]        = string.Empty,
        [PriceID]       = string.Empty,
        [OrderItemID]   = string.Empty,
        [PaymentID]     = string.Empty,
        [ServerID]      = string.Empty,
        [TimeOfDayID]   = string.Empty,
        [OrderDate]     = string.Empty,
        [SubTotal]      = string.Empty,
        [Tax]           = string.Empty,
        [Tip]           = string.Empty,
        [AmountDue]     = string.Empty,
        [Price]         = string.Empty,
        [StartDate]     = string.Empty,
        [EndDate]       = string.Empty,
        [Quantity]      = string.Empty,
        [ExtendedPrice] = string.Empty,
        [FirstName]     = string.Empty,
        [LastName]      = string.Empty,
        [HireDate]      = string.Empty,
        [TermDate]      = string.Empty,
        [DoB]           = string.Empty,
    };
}
