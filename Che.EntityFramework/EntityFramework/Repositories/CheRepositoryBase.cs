using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Che.EntityFramework.Repositories
{
    public abstract class CheRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<CheDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected CheRepositoryBase(IDbContextProvider<CheDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class CheRepositoryBase<TEntity> : CheRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected CheRepositoryBase(IDbContextProvider<CheDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
