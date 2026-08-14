namespace FourthWallCafe.LIB.Utils;

public class UpdateData
{
    // GENERIC
    public const string IDKey   = "id";
    public const string NameKey = "name";
    public const string DescKey = "desc";

    // IDs
    public const string OrderIDKey     = "orderid";
    public const string CategoryIDKey  = "categoryid";
    public const string ItemIDKey      = "itemid";
    public const string PriceIDKey     = "priceid";
    public const string OrderItemIDKey = "orderitemid";
    public const string PaymentIDKey   = "paymentid";
    public const string ServerIDKey    = "serverid";
    public const string TimeOfDayIDKey = "timeofdayid";

    // CafeOrder
    public const string OrderDateKey = "orderdate";
    public const string SubTotalKey  = "subtotal";
    public const string TaxKey       = "tax";
    public const string TipKey       = "tip";
    public const string AmountDueKey = "amountdue";

    // ItemPrice
    public const string PriceKey     = "price";
    public const string StartDateKey = "startdate";
    public const string EndDateKey   = "enddate";

    // OrderItem
    public const string QuantityKey      = "quantity";
    public const string ExtendedPriceKey = "extendedprice";

    // Server
    public const string FirstNameKey = "firstname";
    public const string LastNameKey  = "lastname";
    public const string HireDateKey  = "hiredate";
    public const string TermDateKey  = "termdate";
    public const string DoBKey       = "birth";

    public Dictionary<string, string> Index = new()
    {
        [IDKey]            = string.Empty,
        [NameKey]          = string.Empty,
        [DescKey]          = string.Empty,
        [OrderIDKey]       = string.Empty,
        [CategoryIDKey]    = string.Empty,
        [ItemIDKey]        = string.Empty,
        [PriceIDKey]       = string.Empty,
        [OrderItemIDKey]   = string.Empty,
        [PaymentIDKey]     = string.Empty,
        [ServerIDKey]      = string.Empty,
        [TimeOfDayIDKey]   = string.Empty,
        [OrderDateKey]     = string.Empty,
        [SubTotalKey]      = string.Empty,
        [TaxKey]           = string.Empty,
        [TipKey]           = string.Empty,
        [AmountDueKey]     = string.Empty,
        [PriceKey]         = string.Empty,
        [StartDateKey]     = string.Empty,
        [EndDateKey]       = string.Empty,
        [QuantityKey]      = string.Empty,
        [ExtendedPriceKey] = string.Empty,
        [FirstNameKey]     = string.Empty,
        [LastNameKey]      = string.Empty,
        [HireDateKey]      = string.Empty,
        [TermDateKey]      = string.Empty,
        [DoBKey]           = string.Empty,
    };
}
