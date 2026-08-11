namespace FourthWallCafe.WEB;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();

        var app = builder.Build();
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }
        app.UseStaticFiles();
        app.UseRouting();
        app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Hame}/{action=Index}/{id?}");
        // app.MapGet("/", () => "Hello World!");
        app.Run();
    }
}
