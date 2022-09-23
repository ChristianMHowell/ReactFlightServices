namespace ReactFlightServices.Services.Workers
{
    public class TerminalWorker : ITerminalWork
    {
        private readonly TerminalHandler handler;

        /// <summary>
        /// 
        /// </summary>
        public TerminalWorker(TerminalHandler Handler)
        {
            this.handler = Handler;
        }

        public async Task<bool> CloseGate(int GateId)
        {
            var query = new StringBuilder($"UPDATE Gate SET GateOpen = 0 WHERE GateId = {GateId}");
            var result = await handler.GateRepository.UpdateSql(query.ToString());
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TerminalId"></param>
        /// <returns></returns>
        public async Task<bool> CloseTerminal(int TerminalId)
        {
            var query = new StringBuilder($"UPDATE Terminal SET TerminalOpen = 0 WHERE TerminalId = {TerminalId}");
            var result = await handler.TerminalRepository.UpdateSql(query.ToString());
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="terminalId"></param>
        /// <returns></returns>
        public async Task<Terminal> GetTerminalById(int TerminalId)
        {
            var result = await handler.TerminalRepository.GetById(TerminalId);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AirportId"></param>
        /// <returns></returns>
        public async Task<List<Terminal>> GetTerminalsByAirport(int AirportId)
        {
            var result = await handler.TerminalRepository.Get(q => q.AirportId == AirportId);
            return result.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TerminalId"></param>
        /// <returns></returns>
        public async Task<List<Vendor>> GetVendorsByTerminal(int TerminalId)
        {
            var result = await handler.VendorRepository.Get(q => q.TerminalId == TerminalId);
            return result.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewTerminal"></param>
        /// <returns></returns>
        public async Task<bool> NewTerminal(Terminal NewTerminal)
        {
            handler.TerminalRepository.Add(NewTerminal);
            var result = await handler.TerminalRepository.Save();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="GateId"></param>
        /// <returns></returns>
        public async Task<bool> OpenGate(int GateId)
        {
            var query = new StringBuilder($"UPDATE Gate SET GateOpen = 1 WHERE GateId = {GateId}");
            var result = await handler.GateRepository.UpdateSql(query.ToString());
            return result;
        }

        public Task<bool> OpenTerminal(int TerminalId)
        {
            var query = new StringBuilder($"UPDATE Terminal SET TerminalOpen = 1 WHERE TerminalId = {TerminalId}");
            var result = handler.TerminalRepository.UpdateSql(query.ToString());
            return result;
        }
    }
}
