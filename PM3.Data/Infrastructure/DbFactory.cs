using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM3.Data.Infrastructure
{
    public class DbFactory :Disposable, IDbFactory
    {
        PM3Entities dbContext;

        public PM3Entities Init()
        {
            return dbContext ?? (dbContext = new PM3Entities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

    }
}
