namespace FourthWallCafe.ORM.Repositories;

using Microsoft.EntityFrameworkCore;
using FourthWallCafe.LIB.Interfaces;
using FourthWallCafe.LIB.Entities;
using FourthWallCafe.LIB.Utils;

public class ItemAdapter : IRepository<Item>
{
    private readonly SessionContext Context;

    public ItemAdapter() => Context = new ();
    public ItemAdapter(SessionContext C) => Context = C;

    public Item? CreateEntity(UpdateData Details)
    {
        return null;
    }

    public Item? UpdateValues(Option Option, int Id, UpdateData Values)
    {
        return null;
    }

    public Item? RetrieveSingle(Option Option, int Id)
    {
        return null;
    }

    public bool AddEntity(Item Entity)
    {
        return false;
    }

    public bool UpdateEntity(Item Entity)
    {
        return false;
    }

    public bool ValidateEntity(Option Option, Item Entity)
    {
        return false;
    }

    public bool IfStatus(Option Option, int Id)
    {
        return false;
    }

    public ICollection<Item?>? RetrieveSet(Option Option, string Search)
    {
        return Option switch {
            Option.ALL => [.. Context.Item],
            _ => [null]
        };
    }
}
