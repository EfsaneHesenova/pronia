using Microsoft.EntityFrameworkCore;
using Pronia.DAL.Contexts;
using System;

namespace Pronia.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ProniaDbContext>(
                options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("MsSql"))
                );
            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );


            app.Run();
        }
    }
}
