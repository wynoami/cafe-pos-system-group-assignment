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

    private bool IsServerActive(int? Id)
    {
        return
            Context.Server
                .Where(S => S.ServerID == Id)
                .Where(S => S.TermDate == null)
                .FirstOrDefault() != null;
    }

    public CafeOrder? CreateEntity(UpdateData Values)
    {
        Dictionary<string, string> _Values = Values.Index;

        int?     _ServerId  = _Values[UpdateData.ServerID].DeriveInt();
        decimal? _SubTotal  = _Values[UpdateData.SubTotal].DeriveDecimal() ?? 0;
        decimal? _Tip       = _Values[UpdateData.Tip].DeriveDecimal()      ?? 0;
        decimal? _Tax       = _SubTotal * Defaults.TaxRate;
        decimal? _AmountDue = _SubTotal + _Tax + _Tip;

        if (!IsServerActive(_ServerId))
            return null;

        return new CafeOrder()
        {
            ServerID      = _ServerId,
            PaymentTypeID =  null,
            OrderDate     =  DateTime.Now,
            SubTotal      = _SubTotal,
            Tax           = _Tax,
            Tip           = _Tip,
            AmountDue     = _AmountDue,
        };
    }

    public CafeOrder? UpdateValues(Option Option, int Id, UpdateData Values)
    {
        Dictionary<string, string> _Values = Values.Index;
        CafeOrder? TargetEntity = Context.CafeOrder
            .Where(O => O.OrderID == Id)
            .FirstOrDefault();

        if (TargetEntity == null)
            return null;

        switch (Option)
        {
            case Option.ClOSE :
            case Option.PAYMENT :
                TargetEntity.PaymentTypeID = int.Parse(_Values[UpdateData.PaymentID]);
                break;
            case Option.NONE :
            default :
                break;
        };

        Context.SaveChanges();
        return TargetEntity;
    }

    public CafeOrder? RetrieveSingle(Option Option, int Id)
    {
        return Option switch {
            Option.SINGLE => Context.CafeOrder
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

    public bool AddEntity(CafeOrder Entity)
    {
        try {
            Context.CafeOrder.Add(Entity);
            Context.SaveChanges();
            return true;
        } catch (Exception Ex) {
            Console.WriteLine(Ex.Message);
            // Console.WriteLine(Ex.StackTrace);
            return false;
        }
    }

    public bool UpdateEntity(CafeOrder Entity)
    {
        return false;
    }

    public bool ValidateEntity(Option Option, CafeOrder Entity)
    {
        return false;
    }

    public bool Status(Option Option, int Id)
    {
        return Option switch
        {
            _ => false,
        };
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
