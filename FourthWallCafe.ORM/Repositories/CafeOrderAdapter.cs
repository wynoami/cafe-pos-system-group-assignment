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

    public CafeOrder? CreateEntity(UpdateData Values)
    {
        Dictionary<string, string> _Values = Values.Index;
        int? _ServerId = int.TryParse(_Values[UpdateData.ServerIDKey], out int n) ? n : null;

        // if
        // (  !int.TryParse(_Values[UpdateData.ServerIDKey],       out int _ServerId)
        // || !decimal.TryParse(_Values[UpdateData.ServerIDKey],   out decimal _SubTotal)
        // || !decimal.TryParse(_Values[UpdateData.TaxKey],        out decimal _Tax)
        // || !decimal.TryParse(_Values[UpdateData.TipKey],        out decimal _Tip))
        //     return null;

        CafeOrder? NewEntity = new(){
            ServerID  = _ServerId,
            OrderDate =  DateTime.Now,
            // SubTotal  = _SubTotal,
            // Tax       = _Tax,
            // Tip       = _Tip,
        };

        return NewEntity;
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
                TargetEntity.PaymentTypeID = int.Parse(_Values[UpdateData.PaymentIDKey]);
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
        return false;
    }

    public bool UpdateEntity(CafeOrder Entity)
    {
        return false;
    }

    public bool ValidateEntity(Option Option, CafeOrder Entity)
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
