namespace ReactFlightServices.Services.Workers
{
    public class AirportWorker : IAirportWork
    {
        private readonly AirportHandler airport;
        private readonly VendorHandler vendor;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Airport"></param>
        /// <param name="Vendor"></param>
        public AirportWorker(AirportHandler Airport, VendorHandler Vendor)
        {
            this.airport = Airport;
            vendor = Vendor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewVendor"></param>
        /// <param name="AirportId"></param>
        /// <returns></returns>
        public async Task<bool> AddVendorToAirport(Vendor NewVendor)
        {
            vendor.VendorRepository.Add(NewVendor);
            await vendor.VendorRepository.Save();
            return true;
        }


        public Task<bool> CloseTerminal(int TerminalId)
        {
            var query = @"UPDATE Terminal SET TerminalOpen = 0 WHERE TerminalId = {TerminalId}";
            var result = airport.TerminalRepository.UpdateSql(query);
            return result;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AirportId"></param>
        /// <returns></returns>
        public async Task<Airport> GetAirport(int AirportId)
        {
            var result = await airport.AIrportRepository.GetById(AirportId);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<Airport>> GetAirports()
        {
            var result = await airport.AIrportRepository.Get();
            return result.ToList();
        }


        public Task<bool> OpenTerminal(int TerminalId)
        {
            var query = @"UPDATE Terminal SET TerminalOpen = 1 WHERE TerminalId = {TerminalId}";

            var result = airport.TerminalRepository.UpdateSql(query);
            return result;
        }
    }
}
