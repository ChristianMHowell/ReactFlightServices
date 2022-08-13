namespace ReactFlightServices.Services
{
    public class FlightHandler : IUnitOfWork
    {
        private bool disposedValue;
        FlightServicesContext context;

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<Flight> FlightsRepository { get => new(context); }

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<Gate> GateRepository { get => new(context); }

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<Ticket> TicketRepository { get => new(context); }   


        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public FlightHandler(FlightServicesContext context)
        {            
            this.context = context;
        }

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
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
