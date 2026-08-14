namespace FourthWallCafe.ORM.Repositories;

using FourthWallCafe.LIB.Interfaces;
using FourthWallCafe.LIB.Entities;
using FourthWallCafe.LIB.Enums;

public class PaymentTypeAdapter : IRepository<PaymentType>
{
    public PaymentType? CreateItem(string[] Details)
    {
        return null;
    }

    public PaymentType? UpdateValues(Option Option, int Id, string[] Values)
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
        return [null];
    }

}
