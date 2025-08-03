using Torneos.src.Shared.Helpers;
using Torneos.src.Modules.Personas.Domain.Entities;
using Microsoft.VisualBasic;
using System.Security.Cryptography;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Torneos.src.Shared.utils;
using Torneos.src.Shared.Context;
using Torneos.Ui.Menus.MenuPrincipal;
using Torneos.src.Ui.Menus;


internal class Program
{
    private static void Main(string[] args)
    {
        Bienvenida bienvenida = new Bienvenida();
        bienvenida.Init();
        MenuPrincipal menuPrincipal = new MenuPrincipal();
        menuPrincipal.Init();
        //   var host = Host.CreateDefaultBuilder(args)
        // .ConfigureAppConfiguration((hostingContext, config) =>
        // {
        //     config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        // })
        // .ConfigureServices((context, services) =>
        // {
        //     services.AddScoped<IDbInstaller, DbInstaller>();
        //     services.AddDbContext<AppDbContext>();
        // })
        // .Build();

        //     // Ejecutar verificación
        //     using (var scope = host.Services.CreateScope())
        //     {
        //         var installer = scope.ServiceProvider.GetRequiredService<IDbInstaller>();
        //         installer.EnsureDatabaseExists();
        //     }

        //     host.Run();
        //     var Context = DbContextFactory.Create();
        //     var personas = new Persona
        //     {
        //         Nombre = "JM",
        //         Edad = 12,

        //     };
        //     Context.personas.Add(personas);
        //     Context.SaveChanges();
        //     foreach (var i in Context.personas)
        //     {
        //         Console.WriteLine($"ID: {personas.Id}, nombre: {personas.Nombre}, edad: {personas.Edad}");
        //     }

    }
}