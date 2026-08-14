namespace FourthWallCafe.ORM.Repositories;

using FourthWallCafe.LIB.Interfaces;
using FourthWallCafe.LIB.Entities;
using FourthWallCafe.LIB.Enums;

public class ServerAdapter : IRepository<Server>
{
    private readonly SessionContext Context;

    public ServerAdapter() => Context = new ();
    public ServerAdapter(SessionContext C) => Context = C;

    public Server? CreateItem(string[] Details)
    {
        return null;
    }

    public Server? UpdateValues(Option Option, int Id, string[] Values)
    {
        return null;
    }

    public Server? RetrieveSingle(Option Option, int Id)
    {
        return null;
    }

    public bool AddItem(Server Item)
    {
        return false;
    }

    public bool UpdateItem(Server Item)
    {
        return false;
    }

    public bool IfStatus(Option Option, int Id)
    {
        return false;
    }

    public ICollection<Server?>? RetrieveSet(Option Option, string Search)
    {
        return [null];
    }

}
