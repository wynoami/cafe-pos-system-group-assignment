namespace FourthWallCafe.ORM.Repositories;

using Microsoft.EntityFrameworkCore;
using FourthWallCafe.LIB.Interfaces;
using FourthWallCafe.LIB.Entities;
using FourthWallCafe.LIB.Utils;

public class CafeOrderAdapter : IRepository<CafeOrder>
{
    private readonly SessionContext Context;

    public CafeOrderAdapter() => Context = new ();
    public CafeOrderAdapter(SessionContext C) => Context = C;

    public CafeOrder? CreateItem(UpdateData Values)
    {
        return null;
    }

    public CafeOrder? UpdateValues(Option Option, int Id, UpdateData Values)
    {
        CafeOrder? TargetItem = Context.CafeOrder
            .Where(O => O.OrderID == Id)
            .FirstOrDefault();

        switch (Option)
        {
            case Option.ClOSE :
                // TargetItem.PaymentTypeID = Values[0];
                break;
            default :
                break;
        };

        return TargetItem;
    }

    public CafeOrder? RetrieveSingle(Option Option, int Id)
    {
        return Option switch {
            Option.NONE => Context.CafeOrder
                .Where(O => O.OrderID == Id)
                .FirstOrDefault(),

            Option.DETAILS => Context.CafeOrder
                .Where(O => O.OrderID == Id)
                .Include(O => O.Server)
                .Include(O => O.OrderEntries)
                .FirstOrDefault(),

            _ => null
        };
    }

    public bool AddItem(CafeOrder Item)
    {
        return false;
    }

    public bool UpdateItem(CafeOrder Item)
    {
        return false;
    }

    public bool IfStatus(Option Option, int Id)
    {
        return false;
    }

    public ICollection<CafeOrder?>? RetrieveSet(Option Option, string Search)
    {
        return Option switch
        {
            Option.ALL  => [.. Context.CafeOrder],
            Option.OPEN => [.. Context.CafeOrder.Where(O => O.PaymentType == null)],
            _ => [null],
        };
    }

}
