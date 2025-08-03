using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Torneos.src.Shared.utils;

using MySqlConnector;
using Microsoft.Extensions.Configuration;

public class DbInstaller : IDbInstaller
{

       private readonly IConfiguration _configuration;

    public DbInstaller(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void EnsureDatabaseExists()
    {
        var connStr = _configuration.GetConnectionString("DefaultConnection");

        if (string.IsNullOrWhiteSpace(connStr))
            throw new InvalidOperationException("La cadena de conexión 'DefaultConnection' no está definida.");

        var builder = new MySqlConnectionStringBuilder(connStr);
        var databaseName = builder.Database;

        if (string.IsNullOrEmpty(databaseName))
            throw new InvalidOperationException("La cadena de conexión no contiene el nombre de la base de datos.");

        builder.Database = "";

        using var connection = new MySqlConnection(builder.ConnectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = $"CREATE DATABASE IF NOT EXISTS `{databaseName}`;";
        command.ExecuteNonQuery();
    }
      
}
