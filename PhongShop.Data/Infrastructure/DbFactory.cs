namespace PhongShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private PhongShopDbContext dbContext;

        public PhongShopDbContext Init()
        {
            return dbContext ?? (dbContext = new PhongShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}