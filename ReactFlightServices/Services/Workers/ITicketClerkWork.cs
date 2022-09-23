namespace ReactFlightServices.Services.Workers
{
    public interface ITicketClerkWork
    {
         
        Task<bool> NewClerk(TicketClerk NewClerk);


        Task<bool> UpdateClerk(TicketClerk UpdateClerk);

        Task<TicketClerkTicket> SellTicket(TicketClerkTicket NewTicket, int PaymentId, int PassengerId);


        Task<bool> RefundTicket(Ticket NewTicket, int PaymentId);


        Task<bool> NewPassenger(Passenger NewPassenger);


        Task<bool> UpdatePassenger(Passenger UpdatePassenger);


        Task<TicketClerk> GetClerkById(int ClerkId);


        Task<List<TicketClerk>> GetClerksByAirport(int AirportId);


        Task<List<TicketClerk>> GetAllClerks();



        Task<List<Ticket>> GetTicketsByFlight(int FlightId);


        Task<Tuple<int, int>> GetTicketCount(int FlightId);


        Task<List<TicketClerkTicket>> GetTicketsByClerk(int ClerkId);
        
    }
}
