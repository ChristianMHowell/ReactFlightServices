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
        public FlightRepository<Pilot> PilotRepository { get => new(context); }

        /// <summary>
        /// 
        /// </summary>
        public FlightRepository<Crew> CrewRepository { get => new(context); }

        
        public FlightRepository<FlightPilot> FlightsPilotRepository { get => new(context); }


        public FlightRepository<FlightGate> FlightsGateRepository { get => new(context); }


        public FlightRepository<CrewFlight> CrewFlightRepository { get => new(context); }





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
