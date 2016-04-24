namespace PM3.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private Pm3Entities _dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this._dbFactory = dbFactory;
        }

        public Pm3Entities DbContext
        {
            get { return _dbContext ?? (_dbContext = _dbFactory.Init()); } // good code
        }

        public void Commit()
        {
            DbContext.Commit();
        }


    }
}
