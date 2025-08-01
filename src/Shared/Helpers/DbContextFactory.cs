using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Torneos.src.Shared.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Torneos.src.Shared.Helpers
{
    public class DbContextFactory
    {
        public static AppDbContext Create()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
            string? connectionString = Environment.GetEnvironmentVariable("MYSQL_CONNECTIONS")
                            ?? config.GetConnectionString("MySqlDB");
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("No se encontro una cadena de conexion valida.");
            // Dectar Version MySQL
            var detectedVersion = MySqlVersionResolver.DetectVersion(connectionString);
            var minVersion = new Version(8, 0, 0);
            if (detectedVersion < minVersion)
                throw new NotSupportedException($"Version de MySQL no soportada: {detectedVersion}. Require {minVersion} o superior.");
            Console.WriteLine($"🔍 MySQL detectado: {detectedVersion}");
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseMySql(connectionString, new MySqlServerVersion(detectedVersion))
                .Options;
            return new AppDbContext(options);

        }
    }
}