namespace ReactFlightServices.Services.Workers
{
    public interface ITerminalWork
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="terminalId"></param>
        /// <returns></returns>
        Task<Terminal> GetTerminalById(int TerminalId);

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
        Task<bool> NewTerminal(Terminal NewTerminal);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TerminalId"></param>
        /// <returns></returns>
        Task<List<Vendor>> GetVendorsByTerminal(int TerminalId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Gateid"></param>
        /// <returns></returns>
        Task<bool> OpenGate(int Gateid);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="GateId"></param>
        /// <returns></returns>
        Task<bool> CloseGate(int GateId);


    }
}
