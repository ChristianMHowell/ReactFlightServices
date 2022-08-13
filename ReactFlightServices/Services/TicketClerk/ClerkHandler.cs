namespace ReactFlightServices.Services;

public class ClerkHandler : IUnitOfWork
{
    private bool disposedValue;
    FlightServicesContext context;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    public ClerkHandler(FlightServicesContext context)
    {
        this.context = context;
    }

    /// <summary>
    /// 
    /// </summary>
    public FlightRepository<Ticket> TicketRepository { get => new(context); }

    /// <summary>
    /// 
    /// </summary>
    public FlightRepository<PassengerTicket> PassengerTicketRepository { get => new(context); }

    /// <summary>
    /// 
    /// </summary>
    public FlightRepository<Passenger> PassengerRepository { get => new(context); }

    /// <summary>
    /// 
    /// </summary>
    public FlightRepository<TicketClerkTicket> TicketClerkTicketRepository { get => new(context); } 



    /// <summary>
    /// 
    /// </summary>
    public async void Save()
    {
        await context.SaveChangesAsync();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="disposing"></param>
    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
                context.Dispose();

            disposedValue = true;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
