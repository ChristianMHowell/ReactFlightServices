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
        public virtual async Task<bool> Save()
        {
            var result = await context!.SaveChangesAsync();
            return result > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual async Task<IEnumerable<T>> GetWithSql(string Query, params object[] Parameters)
        {
            var result = dbSet.FromSqlRaw(Query, Parameters); 
            return await result.ToListAsync();
             
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns>
        public virtual async Task<bool> UpdateSql(string Query)
        {
            var result = await context!.Database.ExecuteSqlRawAsync(Query);
            return result > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="OrderBy"></param>
        /// <param name="Includes"></param>
        /// <returns></returns>
        public virtual async Task<List<T>> Get(Expression<Func<T, bool>>? filter = null, 
            Func<IQueryable<T>, IOrderedQueryable<T>>? OrderBy = null, string? Includes = null)
        {

            IQueryable<T>? query = dbSet;
            query = filter is not null ? query.Where(filter) : query;

            if (Includes?.Length > 1)
                foreach (var item in Includes.Split(","))
                    query.Include(item);
            var result = OrderBy is not null ? await OrderBy(query).ToListAsync() : await query.ToListAsync();

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public virtual async Task<T> GetById(int Id)
        {
            var result = await dbSet.FindAsync(Id);            
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
        public async virtual Task<int> Add(T ItemToAdd)
        {            
            context!.Entry(ItemToAdd).State = EntityState.Added;
            var result = await context!.SaveChangesAsync();
            
            return result;
        }


    }
}
