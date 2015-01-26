namespace BunnyCraft.Data.Repositories
{
    using System.Data.Entity;
    using System.Linq;

    public class Repository<T> : IRepository<T> where T : class
    {
        private IBunnyDbContext context;
        private IDbSet<T> set;

        public Repository()
            : this(new BunnyDbContext())
        { }

        public Repository(IBunnyDbContext context)
        {
            this.context = context;
            this.set = context.Set<T>();
        }
        
        public IQueryable<T> All()
        {
            return this.set;
        }

        public void Add(T entity)
        {
            
        }

        public void Update(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Modified);
        }

        public void Delete(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Deleted);
        }

        public void Detach(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Detached);
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        private void ChangeEntityState(T entity, EntityState state)
        {
            var entry = this.context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.set.Attach(entity);
            }

            entry.State = state;
        }
    }
}
