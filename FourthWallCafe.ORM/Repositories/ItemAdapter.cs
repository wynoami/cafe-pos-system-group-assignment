namespace FourthWallCafe.ORM.Repositories;

using FourthWallCafe.LIB.Interfaces;
using FourthWallCafe.LIB.Entities;
using FourthWallCafe.LIB.Enums;

public class ItemAdapter : IRepository<Item>
{
    private readonly SessionContext Context;

    public ItemAdapter() => Context = new ();
    public ItemAdapter(SessionContext C) => Context = C;

    public Item? CreateItem(string[] Details)
    {
        return null;
    }

    public Item? UpdateValues(Option Option, int Id, string[] Values)
    {
        return null;
    }

    public Item? RetrieveSingle(Option Option, int Id)
    {
        return null;
    }

    public bool AddItem(Item Item)
    {
        return false;
    }

    public bool UpdateItem(Item Item)
    {
        return false;
    }

    public bool IfStatus(Option Option, int Id)
    {
        return false;
    }

    public ICollection<Item?>? RetrieveSet(Option Option, string Search)
    {
        return [null];
    }

}
