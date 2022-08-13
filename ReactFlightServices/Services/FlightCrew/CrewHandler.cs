namespace ReactFlightServices.Services;

public class CrewHandler : IUnitOfWork
{
    private bool disposedValue;
    FlightServicesContext context;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    public CrewHandler(FlightServicesContext context)
    {
        this.context = context;
    }


    public FlightRepository<Crew> CrewRepository { get => new(context); }


    public FlightRepository<Flight> FlightsRepository { get => new(context); }
           

    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public async void Save()
    {
        await context.SaveChangesAsync();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                context.Dispose();
            }

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
