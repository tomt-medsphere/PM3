using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        PM3Entities Init();
    }
}
