namespace FourthWallCafe.ORM.Repositories;

using Microsoft.EntityFrameworkCore;
using FourthWallCafe.LIB.Interfaces;
using FourthWallCafe.LIB.Entities;
using FourthWallCafe.LIB.Utils;

public class ItemPriceAdapter : IRepository<ItemPrice>
{
    private readonly SessionContext Context;

    public ItemPriceAdapter() => Context = new ();
    public ItemPriceAdapter(SessionContext C) => Context = C;

    public ItemPrice? CreateEntity(UpdateData Details)
    {
        return null;
    }

    public ItemPrice? UpdateValues(Option Option, int Id, UpdateData Values)
    {
        return null;
    }

    public ItemPrice? RetrieveSingle(Option Option, int Id)
    {
        return null;
    }

    public bool AddEntity(ItemPrice Entity)
    {
        return false;
    }

    public bool UpdateEntity(ItemPrice Entity)
    {
        return false;
    }

    public bool ValidateEntity(Option Option, ItemPrice Entity)
    {
        return false;
    }

    public bool Status(Option Option, int Id)
    {
        return false;
    }

    public ICollection<ItemPrice?>? RetrieveSet(Option Option, string Search)
    {
        return Option switch {
            Option.ALL => [.. Context.ItemPrice],
            _ => [null]
        };
    }
}
