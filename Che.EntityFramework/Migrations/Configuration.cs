using System.Data.Entity.Migrations;
using Che.Migrations.SeedData;

namespace Che.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Che.EntityFramework.CheDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Che";
        }

        protected override void Seed(Che.EntityFramework.CheDbContext context)
        {
            new InitialDataBuilder(context).Build();
        }
    }
}
