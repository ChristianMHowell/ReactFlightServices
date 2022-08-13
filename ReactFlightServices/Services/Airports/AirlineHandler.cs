namespace ReactFlightServices.Services
{
    public class AirlineHandler : IUnitOfWork
    {
        private bool disposedValue;
        private FlightServicesContext context;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public AirlineHandler(FlightServicesContext context)
        {
            this.context = context;
        }



        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<Airline> AirlineRepository { get => new(context); }

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<Flight> FlightsRepository { get => new(context); }




        /// <summary>
        /// 
        /// </summary>
        public async void Save()
        {
            await context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~AirlineHandler()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
