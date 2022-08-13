namespace ReactFlightServices.Services
{
    public class GateHandler : IUnitOfWork
    {
        private bool disposedValue;
        FlightServicesContext context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public GateHandler(FlightServicesContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<Gate> GateRepository { get => new(context); }

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<FlightGate> FlightGateRepository { get => new(context); }   

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<Flight> GateFlightRepository { get => new(context); }


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
                    context.Dispose();
                }

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
