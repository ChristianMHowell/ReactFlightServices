

namespace ReactFlightServices.Endpoints
{
    public class AirportEndpoints : IEndpointExtensions
    {
        public void DefineEndpoints(WebApplication app)
        {
            app.MapGet("/FlightServices", FlightServiceHome);
            app.MapGet("/Airport", AirportHome);
            app.MapPost("/Airport/Open", OpenAirport);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task<IResult> FlightServiceHome([FromServices] AirportHandler Airports)
        {
            IEnumerable<Airport> airports = Airports.AIrportRepository.Get(null, null, "Terminal, Gate, Vendor");

            return Results.Ok(airports.ToList());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task<IResult> AirportHome([FromServices] AirportHandler Airport, [FromBody] DateTime LoginTime, int AirportId)
        {
            

            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="AirportId"></param>
        /// <returns></returns>
        private async Task<IResult> OpenAirport([FromServices] FlightServicesContext context, int AirportId)
        {

            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="Airport"></param>
        /// <returns></returns>
        private async Task<IResult> CloseAirport([FromServices] FlightServicesContext context, int Airport)
        {

            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="TerminalId"></param>
        /// <returns></returns>
        private async Task<IResult> OpenTerminal([FromServices] FlightServicesContext context, int TerminalId)
        {

            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="TerminalId"></param>
        /// <returns></returns>
        private async Task<IResult> CloseTerminal([FromServices] FlightServicesContext context, int TerminalId)
        {

            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="GateId"></param>
        /// <returns></returns>
        private async Task<IResult> OpenGate([FromServices] FlightServicesContext context, int GateId)
        {

            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="GateId"></param>
        /// <returns></returns>
        private async Task<IResult> CloseGate([FromServices] FlightServicesContext context, int GateId)
        {

            return Results.Ok();
        }
               

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void DefineServices(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, AirlineHandler>();
            services.AddTransient<IUnitOfWork, AirportHandler>();
            services.AddTransient<IUnitOfWork, GateHandler>();


        }
    }
}
