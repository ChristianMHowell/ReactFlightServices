namespace ReactFlightServices.Services
{
    public class FlightRepository<T> where T: class
    {
        private FlightServicesContext context;
        private DbSet<T> dbSet;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="dbSet"></param>
        public FlightRepository(FlightServicesContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual IEnumerable<T> GetWithSql(string Query, params object[] Parameters)
        {
            var result = dbSet.FromSqlRaw(Query, Parameters);            
            return result;
             
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="OrderBy"></param>
        /// <param name="Includes"></param>
        /// <returns></returns>
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>>? filter = null, 
            Func<IQueryable<T>, IOrderedQueryable<T>>? OrderBy = null, string? Includes = null)
        {

            IQueryable<T>? query = dbSet;
            query = filter is not null ? query.Where(filter) : query;

            if (Includes?.Length > 1)
                foreach (var item in Includes.Split(","))
                    query.Include(item);
            var result = OrderBy is not null ? OrderBy(query) : query;

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public virtual T GetById(int Id)
        {
            var result = dbSet.Find(Id);            
            return result!;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ItemToUpdate"></param>
        /// <returns></returns>
        public virtual void Update(T ItemToUpdate)
        {
            dbSet.Attach(ItemToUpdate);
            context!.Entry(ItemToUpdate).State = EntityState.Modified;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ItemToAdd"></param>
        public virtual void Add(T ItemToAdd)
        {
            context!.Entry(ItemToAdd).State = EntityState.Added;
        }


    }
}
