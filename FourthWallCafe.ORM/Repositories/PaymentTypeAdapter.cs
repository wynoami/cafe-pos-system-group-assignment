namespace FourthWallCafe.ORM.Repositories;

using Microsoft.EntityFrameworkCore;
using FourthWallCafe.LIB.Interfaces;
using FourthWallCafe.LIB.Entities;
using FourthWallCafe.LIB.Utils;

public class PaymentTypeAdapter : IRepository<PaymentType>
{
    private readonly SessionContext Context;

    public PaymentTypeAdapter() => Context = new ();
    public PaymentTypeAdapter(SessionContext C) => Context = C;

    public PaymentType? CreateItem(UpdateData Details)
    {
        return null;
    }

    public PaymentType? UpdateValues(Option Option, int Id, UpdateData Values)
    {
        return null;
    }

    public PaymentType? RetrieveSingle(Option Option, int Id)
    {
        return null;
    }

    public bool AddItem(PaymentType Item)
    {
        return false;
    }

    public bool UpdateItem(PaymentType Item)
    {
        return false;
    }

    public bool IfStatus(Option Option, int Id)
    {
        return false;
    }

    public ICollection<PaymentType?>? RetrieveSet(Option Option, string Search)
    {
        return Option switch
        {
            Option.ALL => [.. Context.PaymentType],
            _ => [ null ]
        };
    }

}
