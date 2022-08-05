namespace ReactFlightServices.Services
{
    public interface IEndpointExtensions
    {
        void DefineServices(IServiceCollection services);
        void DefineEndpoints(WebApplication app);
    }
}
