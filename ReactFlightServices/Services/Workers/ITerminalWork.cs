namespace ReactFlightServices.Services.Workers
{
    public interface ITerminalWork
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="terminalId"></param>
        /// <returns></returns>
        Task<Terminal> GetTerminalById(Terminal terminalId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AirportId"></param>
        /// <returns></returns>
        Task<List<Terminal>> GetTerminalsByAirport(int AirportId);

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
        /// <param name="NewTerminal"></param>
        /// <param name="AirportId"></param>
        /// <returns></returns>
        Task<Terminal> NewTerminal(Terminal NewTerminal, int AirportId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TerminalId"></param>
        /// <returns></returns>
        Task<List<Vendor>> GetVendorsByTerminal(int TerminalId);


    }
}
