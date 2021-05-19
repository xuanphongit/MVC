using System;

namespace PhongShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        PhongShopDbContext Init();
    }
}