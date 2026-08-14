namespace FourthWallCafe.ORM.Repositories;

using FourthWallCafe.LIB.Interfaces;
using FourthWallCafe.LIB.Entities;
using FourthWallCafe.LIB.Enums;

public class CafeOrderAdapter : IRepository<CafeOrder>
{
    public CafeOrder? CreateItem(string[] Details)
    {
        return null;
    }

    public CafeOrder? UpdateValues(Option Option, int Id, string[] Values)
    {
        return null;
    }

    public CafeOrder? RetrieveSingle(Option Option, int Id)
    {
        return null;
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
        return [null];
    }

}
