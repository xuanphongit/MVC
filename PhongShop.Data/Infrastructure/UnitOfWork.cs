namespace PhongShop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private PhongShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public PhongShopDbContext DbContext => dbContext ?? (dbContext = new DbFactory().Init());

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}