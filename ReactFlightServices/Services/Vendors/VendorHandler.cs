namespace ReactFlightServices.Services
{
    public class VendorHandler : IUnitOfWork
    {
        private bool disposedValue;
        FlightServicesContext context;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public VendorHandler(FlightServicesContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<Vendor> VendorRepository { get => new(context); }

        /// <summary>
        /// 
        /// </summary>
        public async void Save()
        {
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                    context.Dispose();

                disposedValue = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
