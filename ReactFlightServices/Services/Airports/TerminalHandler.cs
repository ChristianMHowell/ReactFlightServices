namespace ReactFlightServices.Services.Airports
{
    public class TerminalHandler : IUnitOfWork
    {
        private bool disposedValue;
        FlightServicesContext? context;


        public FlightRepository<Terminal> TerminalRepository { get => new(context!); }


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
