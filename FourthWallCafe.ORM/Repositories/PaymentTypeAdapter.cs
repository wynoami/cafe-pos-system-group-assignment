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

    public PaymentType? CreateEntity(UpdateData Details)
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

    public bool AddEntity(PaymentType Entity)
    {
        return false;
    }

    public bool UpdateEntity(PaymentType Entity)
    {
        return false;
    }

    public bool ValidateEntity(Option Option, PaymentType Entity)
    {
        return false;
    }

    public bool Status(Option Option, int Id)
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
