namespace ReactFlightServices.Services.Workers
{
    public class ManagerWorker : IManagerWork
    {
        public Task<bool> AddAirline(Airline NewAirline)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddAirport(Airport NewAirport)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddClerk(TicketClerk NewClerk)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddFlight(Flight NewFlight)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddGate(Gate NewGate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddPassenger(Passenger NewPassenger)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddTerminal(Terminal NewTerminal)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddVendor(Vendor NewVendor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CloseGate(int GateId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CloseTerminal(int TerminalId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CloseVendor(int VendorId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> OpenGate(int GateId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> OpenTerminal(int TerminalId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> OpenVendor(int VendorId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAirline(Airline UpdatedAirline)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAirport(Airport UpdatedAirport)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateClerk(TicketClerk UpdatedClerk)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateFlight(Flight UpdatedFlight)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateFlightStatus(int FlightId, int FlightStatus)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateGate(Gate UpdatedGate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePassenger(Passenger UpdatedPassenger)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTerminal(Terminal UpdatedTerminal)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateVendor(Vendor UpdatedVendor)
        {
            throw new NotImplementedException();
        }
    }
}
