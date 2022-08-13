

namespace ReactFlightServices.Endpoints
{
    public class FlightEndpoints : IEndpointExtensions
    {
        public void DefineEndpoints(WebApplication app)
        {
            app.MapGet("/Flights/GetAllFlights", GetAllFlightsByAirport);
            //app.MapGet("/Flights/GetFlightById", GetFlightById);
            //app.MapGet("")
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="AirportId"></param>
        /// <returns></returns>
        private async Task<IResult> GetAllFlightsByAirport([FromServices] FlightHandler handler, [FromBody] int AirportId)
        {

            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="FlightId"></param>
        /// <returns></returns>
        private async Task<IResult> GetFlightsById([FromServices] FlightHandler handler, [FromBody] int FlightId)
        {

            return Results.Ok();
        }

        public void DefineServices(IServiceCollection services)
        {
            
        }
    }
}
