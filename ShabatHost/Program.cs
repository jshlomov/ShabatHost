using Microsoft.Extensions.Configuration;
using ShabatHost.DAL;
using ShabatHost.DAL.Repository;

namespace ShabatHost
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder()
                        .AddUserSecrets<Program>()
                        .Build();
            string? conn = config["ConnectionString"];
            string? dbName = config["DefaultDB"];

            DBContext dbContext = new DBContext(conn);
            new SeedService(dbContext, dbName).EnsureTablesAndSeedData();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HostForm(new CategoryRepository(dbContext)));
        }

    }
}