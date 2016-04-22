using System;

namespace PM3.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        Pm3Entities Init();
    }
}
