namespace FourthWallCafe.ORM.Repositories;

using Microsoft.EntityFrameworkCore;
using FourthWallCafe.LIB.Interfaces;
using FourthWallCafe.LIB.Entities;
using FourthWallCafe.LIB.Utils;

public class ServerAdapter : IRepository<Server>
{
    private readonly SessionContext Context;

    public ServerAdapter() => Context = new ();
    public ServerAdapter(SessionContext C) => Context = C;

    public Server? CreateEntity(UpdateData Details)
    {
        return null;
    }

    public Server? UpdateValues(Option Option, int Id, UpdateData Values)
    {
        return null;
    }

    public Server? RetrieveSingle(Option Option, int Id)
    {
        return null;
    }

    public bool AddEntity(Server Entity)
    {
        return false;
    }

    public bool UpdateEntity(Server Entity)
    {
        return false;
    }

    public bool ValidateEntity(Option Option, Server Entity)
    {
        return false;
    }

    public bool IfStatus(Option Option, int Id)
    {
        return false;
    }

    public ICollection<Server?>? RetrieveSet(Option Option, string Search)
    {
        return Option switch
        {
            Option.ALL    => [.. Context.Server],
            Option.ACTIVE => [.. Context.Server.Where(S => S.TermDate == null)],
            _ => [null],
        };
    }
}
