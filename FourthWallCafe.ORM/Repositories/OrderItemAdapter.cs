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

    public OrderItem? CreateItem(UpdateData Details)
    {
        return null;
    }

    public OrderItem? UpdateValues(Option Option, int Id, UpdateData Values)
    {
        return null;
    }

    public OrderItem? RetrieveSingle(Option Option, int Id)
    {
        return null;
    }

    public bool AddItem(OrderItem Item)
    {
        return false;
    }

    public bool UpdateItem(OrderItem Item)
    {
        return false;
    }

    public bool IfStatus(Option Option, int Id)
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
