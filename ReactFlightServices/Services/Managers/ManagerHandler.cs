namespace ReactFlightServices.Services.Managers
{
    public class ManagerHandler : IUnitOfWork
    {
        FlightServicesContext? context;
        private bool disposedValue;

        public ManagerHandler(FlightServicesContext? Context)
        {
            context = Context;
        }

        public FlightRepository<Airline> AirlineRepository { get => new(context!); }


        public FlightRepository<Airport> AirportRepository { get => new(context!); }


        public FlightRepository<Terminal> TerminalRepository { get => new(context!); }


        public FlightRepository<Flight> FlightRepository { get => new(context!); }


        public FlightRepository<Gate> GateRepository { get => new(context!); }


        public FlightRepository<Passenger> PassengerRepository { get => new(context!); }


        public FlightRepository<Ticket> TicketRepository { get => new(context!); }


        public FlightRepository<TicketClerk> ClerkRepository { get => new(context!); }


        public FlightRepository<Vendor> VendorRepository { get => new(context!); }


       

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
                    context!.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
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
