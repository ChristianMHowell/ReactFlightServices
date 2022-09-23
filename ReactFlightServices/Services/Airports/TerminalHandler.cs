namespace ReactFlightServices.Services.Airports
{
    public class TerminalHandler : IUnitOfWork
    {
        private bool disposedValue;
        FlightServicesContext? context;


        public FlightRepository<Terminal> TerminalRepository { get => new(context!); }


        public FlightRepository<Gate> GateRepository { get => new(context!); }


        public FlightRepository<FlightGate> FlightGateRepository { get => new(context!); }


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
                    context?.Dispose();
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
