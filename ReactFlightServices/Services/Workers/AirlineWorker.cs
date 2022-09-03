namespace ReactFlightServices.Services.Workers
{
    public class AirlineWorker : IAirlineWork
    {
        private readonly AirlineHandler airlineHandler;
        private readonly FlightHandler flightHandler;
        private readonly PilotHandler pilotHandler;
        private readonly CrewHandler crewHandler;

        public AirlineWorker(AirlineHandler airline, FlightHandler flight, 
                             PilotHandler pilot, CrewHandler crew)
        {
            this.airlineHandler = airline;
            this.flightHandler = flight;
            this.pilotHandler = pilot;
            this.crewHandler = crew;
        }

        public async Task<bool> AddAirline(Airline airline)
        {
            airlineHandler.AirlineRepository.Add(airline);
            await airlineHandler.AirlineRepository.Save();
            return true;
        }

        public async Task<bool> AddCrewToAirline(Crew NewMember, int AirlineId)
        {
            crewHandler.CrewRepository.Add(NewMember);
            await crewHandler.CrewRepository.Save();

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<Airline>> GetAllAirlines()
        {
            var result = await airlineHandler.AirlineRepository.Get();
            return result.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<Crew>> GetAllCrew()
        {
            var result = await airlineHandler.CrewRepository.Get();
            return result.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AirlineId"></param>
        /// <returns></returns>
        public async Task<List<Crew>> GetCrewByAirline(int AirlineId)
        {
            var query = $"SELECT * FROM Crew c INNER JOIN CrewAirline ca ON c.CrewId = ca.CrewId INNER JOIN Airline a ON ca.AirlineId = a.AirlineId WHERE ca.Airline = {AirlineId}";
            var result = await crewHandler.CrewRepository.GetWithSql(query);
            return result.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FlightId"></param>
        /// <returns></returns>
        public async Task<List<Crew>> GetCrewByFlight(int FlightId)
        {
            var query = new StringBuilder(@"SELECT * FROM Crew c");
            query.Append(" INNER JOIN CrewFlight ca ON c.CrewId = ca.CrewId");
            query.Append(" INNER JOIN Flight a ON ca.FlightId = a.FlightId");
            query.Append(" WHERE ca.Flight = " + FlightId);

            var result = await crewHandler.CrewRepository.GetWithSql(query.ToString());
            return result.ToList();              

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewMember"></param>
        /// <returns></returns>
        public async Task<bool> NewCrewMember(Crew NewMember)
        {
            crewHandler.CrewRepository.Add(NewMember);
            var result = await crewHandler.CrewRepository.Save();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewPilot"></param>
        /// <param name="FlightId"></param>
        /// <returns></returns>
        public async Task<bool> AddPilotToFlight(Pilot NewPilot, int FlightId)
        {
            airlineHandler.FlightsPilotRepository.Add(new FlightPilot() { FlightId = FlightId, PilotId = NewPilot.PilotId });
            var result = await airlineHandler.FlightsPilotRepository.Save();
            return result;
        }

    }
}
