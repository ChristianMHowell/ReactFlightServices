namespace ReactFlightServices.Services
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
