namespace ReactFlightServices.Services.Workers
{
    public interface IAirportWork
    {
        /// <summary>
        /// Retrieves all Flight Service Hubs
        /// </summary>
        /// <returns>List Of Airports</returns>
        Task<List<Airport>> GetAirports();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AirportId"></param>
        /// <returns></returns>
        Task<Airport> GetAirport(int AirportId);

        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TerminalId"></param>
        /// <returns></returns>
        Task<bool> OpenTerminal(int TerminalId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TerminalId"></param>
        /// <returns></returns>
        Task<bool> CloseTerminal(int TerminalId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewVendor"></param>
        /// <param name="AirportId"></param>
        /// <returns></returns>
        Task<bool> AddVendorToAirport(Vendor NewVendor);



    }
}
