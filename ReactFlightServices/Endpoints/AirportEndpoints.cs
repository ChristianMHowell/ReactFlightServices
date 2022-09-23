

namespace ReactFlightServices.Endpoints
{
    public class AirportEndpoints : IEndpointExtensions
    {
        public void DefineEndpoints(WebApplication app)
        {
            app.MapGet("/Airports", FlightServiceHome);
            app.MapGet("/Airport", AirportHome);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task<IResult> FlightServiceHome([FromServices] IAirportWork Airports)
        {
            var airports = await Airports.GetAirports();
            return Results.Ok(airports);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task<IResult> AirportHome([FromServices] IAirportWork Airport, [FromBody] DateTime LoginTime, int AirportId)
        {
            var result = await Airport.GetAirport(AirportId);
            return Results.Ok(result);
        }      

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="TerminalId"></param>
        /// <returns></returns>
        private async Task<IResult> OpenTerminal([FromServices] IAirportWork context, int TerminalId)
        {
            var result = await context.OpenTerminal(TerminalId);
            return Results.Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="TerminalId"></param>
        /// <returns></returns>
        private async Task<IResult> CloseTerminal([FromServices] IAirportWork context, int TerminalId)
        {
            var result = await context.CloseTerminal(TerminalId);
            return Results.Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="GateId"></param>
        /// <returns></returns>
        private async Task<IResult> OpenGate([FromServices] ITerminalWork context, int GateId)
        {           
            var result = await context.OpenGate(GateId);
            return Results.Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="GateId"></param>
        /// <returns></returns>
        private async Task<IResult> CloseGate([FromServices] ITerminalWork context, int GateId)
        {
            
            return Results.Ok();
        }
               

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void DefineServices(IServiceCollection services)
        {

            services.AddScoped<IAirportWork, AirportWorker>();
            services.AddScoped<ITerminalWork, TerminalWorker>();


        }
    }
}
