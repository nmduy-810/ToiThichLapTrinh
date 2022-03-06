using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ToiThichLapTrinh.Server.Datas;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    /* Instance application db context */
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        /* Get current environment name, build configuration builder */
        var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        /* Read appsettings.json file and appsettings.Development.json or appsettings.Production.json file*/
        var configurationRoot = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{environmentName}.json")
            .Build();

        /* Create builder */
        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();

        /* Return value of connection string in appsettings.json*/
        var connectionString = configurationRoot.GetConnectionString("DefaultConnection");

        //Cast to Sql Server
        builder.UseSqlServer(connectionString);

        return new ApplicationDbContext(builder.Options);
    }
}