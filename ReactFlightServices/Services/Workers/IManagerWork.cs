namespace ReactFlightServices.Services.Workers
{
    public interface IManagerWork
    {
        Task<bool> AddAirport(Airport NewAirport);


        Task<bool> UpdateAirport(Airport UpdatedAirport);


        Task<bool> AddAirline(Airline NewAirline);


        Task<bool> UpdateAirline(Airline UpdatedAirline);


        Task<bool> AddTerminal(Terminal NewTerminal);


        Task<bool> UpdateTerminal(Terminal UpdatedTerminal);


        Task<bool> AddGate(Gate NewGate);


        Task<bool> UpdateGate(Gate UpdatedGate);

        Task<bool> AddVendor(Vendor NewVendor);

        Task<bool> UpdateVendor(Vendor UpdatedVendor);


        Task<bool> AddPassenger(Passenger NewPassenger);


        Task<bool> UpdatePassenger(Passenger UpdatedPassenger);


        Task<bool> AddFlight(Flight NewFlight);


        Task<bool> UpdateFlight(Flight UpdatedFlight);

        Task<bool> UpdateFlightStatus(int FlightId, int FlightStatus);


        Task<bool> AddClerk(TicketClerk NewClerk);


        Task<bool> UpdateClerk(TicketClerk UpdatedClerk);


        Task<bool> OpenTerminal(int TerminalId);


        Task<bool> CloseTerminal(int TerminalId);


        Task<bool> OpenGate(int GateId);


        Task<bool> CloseGate(int GateId);

        Task<bool> OpenVendor(int VendorId);

        Task<bool> CloseVendor(int VendorId);




    }
}
