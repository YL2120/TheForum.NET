using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
namespace TheForum.Data
{
    public class TheForumDesignContext : IDesignTimeDbContextFactory<TheForumContext>
    {
        public TheForumContext CreateDbContext(string[] args)
        {
            string path = Directory.GetCurrentDirectory();

            var builder = new ConfigurationBuilder() // accès aux paramètres de configuration
                               .SetBasePath(path) //je prends le projet en cours. nuget : fileextension
                               .AddJsonFile("appsettings.json")// et je lui spécifie ma configuration. nuget : configuration.json
                               .AddUserSecrets<TheForumDesignContext>();


            var config = builder.Build();

           /* var connectionString = config.GetConnectionString("TheForumContext");*/ // il lit notre appsetting

            DbContextOptionsBuilder<TheForumContext> optionBuilder = new DbContextOptionsBuilder<TheForumContext>();
            optionBuilder.UseSqlServer(config.GetConnectionString("TheForumContext")); //c'est ici qu'on précise quel DB on va utiliser.

            return new TheForumContext(optionBuilder.Options);
        }
    }
}
