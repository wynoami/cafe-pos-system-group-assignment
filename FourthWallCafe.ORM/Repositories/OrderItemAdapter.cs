namespace FourthWallCafe.ORM.Repositories;

using Microsoft.EntityFrameworkCore;
using FourthWallCafe.LIB.Interfaces;
using FourthWallCafe.LIB.Entities;
using FourthWallCafe.LIB.Utils;

public class OrderItemAdapter : IRepository<OrderItem>
{
    private readonly SessionContext Context;

    public OrderItemAdapter() => Context = new ();
    public OrderItemAdapter(SessionContext C) => Context = C;

    private bool IsOrderOpen(int Id)
    {
        return
            Context.CafeOrder
                .Where(O => O.OrderID == Id)
                .Where(O => O.PaymentTypeID == null)
                .FirstOrDefault() != null;
    }

    public OrderItem? CreateEntity(UpdateData Values)
    {
        Dictionary<string, string> _Values = Values.Index;

        string _OrderIdStr  = _Values[UpdateData.OrderID];
        string _PriceIdStr  = _Values[UpdateData.PriceID];
        string _QuantStr    = _Values[UpdateData.Quantity];
        string _ExtPriceStr = _Values[UpdateData.ExtendedPrice];

        // defaults not assumed
        if (!int.TryParse(_OrderIdStr, out int _OrderId)  ||
            !int.TryParse(_PriceIdStr, out int _PriceId)  ||
            !int.TryParse(_QuantStr,   out int _Quantity))
            return null;

        // handle default assignment
        decimal _ExtPrice = decimal.TryParse(_ExtPriceStr, out decimal E) ? E : 0.0M;

        if (!IsOrderOpen(_OrderId))
            return null;

        return new OrderItem()
        {
            OrderID       = _OrderId,
            ItemPriceID   = _PriceId,
            Quantity      = _Quantity,
            ExtendedPrice = _ExtPrice
        };
    }

    public OrderItem? UpdateValues(Option Option, int Id, UpdateData Values)
    {
        return null;
    }

    // include ItemID and Quantity
    public OrderItem? RetrieveSingle(Option Option, int Id)
    {
        return null;
    }

    public bool AddEntity(OrderItem Entity)
    {
        return false;
    }

    public bool UpdateEntity(OrderItem Entity)
    {
        return false;
    }

    public bool ValidateEntity(Option Option, OrderItem Entity)
    {
        return false;
    }

    public bool Status(Option Option, int Id)
    {
        return false;
    }

    public ICollection<OrderItem?>? RetrieveSet(Option Option, string Search)
    {
        return Option switch {
            Option.ALL =>
                [.. Context.OrderItem],

            Option.ORDER =>
                [..
                Context.OrderItem
                    .Where(I => I.OrderID.ToString() == Search)
                ],

            _ => [null],
        };
    }

}
