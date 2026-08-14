namespace FourthWallCafe.ORM.Repositories;

using FourthWallCafe.LIB.Interfaces;
using FourthWallCafe.LIB.Entities;
using FourthWallCafe.LIB.Enums;

public class OrderItemAdapter : IRepository<OrderItem>
{
    public OrderItem? CreateItem(string[] Details)
    {
        return null;
    }

    public OrderItem? UpdateValues(Option Option, int Id, string[] Values)
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
        return [null];
    }

}
