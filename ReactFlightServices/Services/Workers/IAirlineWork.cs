namespace ReactFlightServices.Services.Workers
{
    public interface IAirlineWork
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="airline"></param>
        /// <returns></returns>
        Task<Airline> AddAirline(Airline airline);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<Airline>> GetAllAirlines();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<Crew>> GetAllCrew();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Flight"></param>
        /// <returns></returns>
        Task<List<Crew>> GetCrewByFlight(int Flight);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AirlineId"></param>
        /// <returns></returns>
        Task<List<Crew>> GetCrewByAirline(int AirlineId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewMember"></param>
        /// <param name="AirlineId"></param>
        /// <returns></returns>
        Task<Crew> AddCrewToAirline(Crew NewMember, int AirlineId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewMember"></param>
        /// <returns></returns>
        Task<Crew> NewCrewMember (Crew NewMember);

    }
}
