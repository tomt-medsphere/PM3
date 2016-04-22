namespace PM3.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        Pm3Entities _dbContext;

        public Pm3Entities Init()
        {
            return _dbContext ?? (_dbContext = new Pm3Entities());
        }

        protected override void DisposeCore()
        {
            _dbContext?.Dispose();
        }
    }
}
