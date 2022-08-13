namespace ReactFlightServices.Services
{
    public class PassengerHandler : IUnitOfWork
    {
        private bool disposedValue;
        FlightServicesContext context;

        /// <summary>
        /// 
        /// </summary>
        public PassengerHandler(FlightServicesContext Context)
        {
            context = Context;
        }

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<Passenger> PassengerRepository { get => new(context); }

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<PassengerTicket> PassengerTicketRepository { get => new(context); }





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

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~PassengerHandler()
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
