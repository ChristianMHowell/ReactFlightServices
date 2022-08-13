namespace ReactFlightServices.Services
{
    public class PilotHandler : IUnitOfWork
    {
        private bool disposedValue;
        FlightServicesContext context;


        /// <summary>
        /// 
        /// </summary>
        public PilotHandler(FlightServicesContext Context)
        {
            context = Context;
        }

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<Pilot> PilotRepository { get => new(context); }

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
