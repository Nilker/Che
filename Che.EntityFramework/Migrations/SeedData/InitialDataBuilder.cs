using Che.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Che.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly CheDbContext _context;

        public InitialDataBuilder(CheDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.DisableAllFilters();

            new DefaultEditionsBuilder(_context).Build();
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
