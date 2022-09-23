namespace ReactFlightServices.Services
{
    public class AirportHandler : IUnitOfWork
    {
        private bool disposedValue;
        FlightServicesContext context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public AirportHandler(FlightServicesContext context)
        {
            this.context = context;
        }


        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<Airport> AIrportRepository { get => new(context); }

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<Terminal> TerminalRepository { get => new(context); }

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<Gate> GateRepository { get => new(context); }

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<TicketClerk> TicketClerkRepository { get => new(context); }


        public FlightRepository<Vendor> VendorRepository { get => new(context); }





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
