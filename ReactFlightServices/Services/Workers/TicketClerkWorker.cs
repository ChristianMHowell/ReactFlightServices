using System.Net.WebSockets;

namespace ReactFlightServices.Services.Workers
{
    public class TicketClerkWorker : ITicketClerkWork
    {
        private readonly ClerkHandler clerk;
        private readonly PassengerHandler passenger;
        private readonly FlightHandler flight;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Clerk"></param>
        /// <param name="Passenger"></param>
        public TicketClerkWorker(ClerkHandler Clerk, PassengerHandler Passenger, FlightHandler Flight)
        {
            clerk = Clerk;
            passenger = Passenger;
            flight = Flight;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<TicketClerk>> GetAllClerks()
        {
            var result = await clerk.TIcketClerkRepository.Get();
            return result.ToList();
        }

        public async Task<TicketClerk> GetClerkById(int ClerkId)
        {
            var result = await clerk.TIcketClerkRepository.GetById(ClerkId);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AirportId"></param>
        /// <returns></returns>
        public async Task<List<TicketClerk>> GetClerksByAirport(int AirportId)
        {
            var result = await clerk.TIcketClerkRepository.Get(q => q.ClerkAirport == AirportId);
            return result.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FlightId"></param>
        /// <returns></returns>
        public async Task<Tuple<int, int>> GetTicketCount(int FlightId)
        {
            var result = await clerk.TicketRepository.Get(q => q.TicketFlight == FlightId);
            var thisFlight = await flight.FlightsRepository.GetById(FlightId);
            var remaining = (thisFlight.FlightRows * thisFlight.FlightSeats) - result.Count();
            return new(thisFlight.FlightRows * thisFlight.FlightSeats, remaining);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ClerkId"></param>
        /// <returns></returns>
        public async Task<List<TicketClerkTicket>> GetTicketsByClerk(int ClerkId)
        {
            var result = await clerk.TicketClerkTicketRepository.Get(q => q.ClerkId == ClerkId);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FlightId"></param>
        /// <returns></returns>
        public async Task<List<Ticket>> GetTicketsByFlight(int FlightId)
        {
            var result = await clerk.TicketRepository.Get(q => q.Equals(FlightId));
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewClerk"></param>
        /// <returns></returns>
        public async Task<bool> NewClerk(TicketClerk NewClerk)
        {
            var result = await clerk.TIcketClerkRepository.Add(NewClerk);
            return result > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewPassenger"></param>
        /// <returns></returns>
        public async Task<bool> NewPassenger(Passenger NewPassenger)
        {
            var result = await clerk.PassengerRepository.Add(NewPassenger);
            return result > 0;
        }

        public async Task<bool> RefundTicket(Ticket NewTicket, int PaymentId)
        {
            var query = new StringBuilder();
            query.Append($"UPDATE TicketPayment SET TicketRefund = 1 WHERE TicketId = {NewTicket.TicketId}" );
            var result = await clerk.TicketPaymentRepository.UpdateSql(query.ToString());
            return result;
        }

        public async Task<TicketClerkTicket> SellTicket(Ticket NewTicket, int NewClerk, int PaymentId, int PassengerId)
        {
            var ticketPayment = new TicketPayment();
            var passengerTicket = new PassengerTicket();
            var ticketClerkTicket = new TicketClerkTicket();

            var ticketResult = await clerk.TicketRepository.Add(NewTicket);


            ticketPayment.TicketId = NewTicket.TicketId;
            ticketPayment.PaymentId = PaymentId;
            //var ticketResult = await clerk.TicketClerkTicketRepository.Add(NewTicket);
            var paymentResult = await clerk.TicketPaymentRepository.Add(ticketPayment);

        }

        public Task<bool> UpdateClerk(TicketClerk UpdateClerk)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePassenger(Passenger UpdatePassenger)
        {
            throw new NotImplementedException();
        }

    }
}
