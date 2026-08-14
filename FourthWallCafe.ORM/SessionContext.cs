namespace FourthWallCafe.ORM;

using Microsoft.EntityFrameworkCore;
using FourthWallCafe.LIB;
using FourthWallCafe.LIB.Entities;

public class SessionContext : DbContext
{
    private readonly string AccessInfo;

    public SessionContext() =>
        AccessInfo = DbAccess.Credentials;

    public SessionContext(string Credentials) =>
        AccessInfo = Credentials;

    public DbSet<CafeOrder>   CafeOrder   { get; set; }
    public DbSet<Category>    Category    { get; set; }
    public DbSet<Item>        Item        { get; set; }
    public DbSet<ItemPrice>   ItemPrice   { get; set; }
    public DbSet<OrderItem>   OrderItem   { get; set; }
    public DbSet<PaymentType> PaymentType { get; set; }
    public DbSet<Server>      Server      { get; set; }
    public DbSet<TimeOfDay>   TimeOfDay   { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder Builder)
    {
        Builder.UseMySql(AccessInfo, ServerVersion.AutoDetect(AccessInfo));
    }

}
