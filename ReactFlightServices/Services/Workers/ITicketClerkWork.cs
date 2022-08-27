namespace ReactFlightServices.Services.Workers
{
    public interface ITicketClerkWork
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewClerk"></param>
        /// <returns></returns>
        Task<TicketClerk> NewClerk(TicketClerk NewClerk);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UpdateClerk"></param>
        /// <returns></returns>
        Task<TicketClerk> UpdateClerk(TicketClerk UpdateClerk);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewTicket"></param>
        /// <param name="PassengerId"></param>
        /// <returns></returns>
        Task<TicketClerkTicket> SellTicket(TicketClerkTicket NewTicket, int PassengerId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewPassenger"></param>
        /// <returns></returns>
        Task<Passenger> NewPassenger(Passenger NewPassenger);

        
    }
}
