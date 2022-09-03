namespace ReactFlightServices.Endpoints
{
    public class CrewEndpoints : IEndpointExtensions
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public void DefineEndpoints(WebApplication app)
        {
            app.MapPost("/Airline/AddCrewMember", AddCrewMember);

            app.MapPost("/Airline/UpdateCrewMember", UpdateCrewMember);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Handler"></param>
        /// <param name="Token"></param>
        /// <param name="NewCrew"></param>
        /// <returns></returns>
        private async Task<IResult> AddCrewMember([FromServices] IAirlineWork airlineWorker, [FromHeader] string Token, [FromBody] Crew NewCrew)
        {

            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Handler"></param>
        /// <param name="Token"></param>
        /// <param name=""></param>
        /// <returns></returns>
        private async Task<IResult> UpdateCrewMember([FromServices] IAirlineWork airlineWorker, [FromHeader] string Token, [FromBody] Crew CrewMember)
        {


            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Handler"></param>
        /// <param name="Token"></param>
        /// <param name="Cremember"></param>
        /// <param name="FlightId"></param>
        /// <returns></returns>
        private async Task<IResult> AddCrewMemberFlight([FromServices] IAirlineWork airlineWorker, [FromHeader] string Token, [FromBody] Crew CrewMember, int FlightId)
        {

            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void DefineServices(IServiceCollection services)
        {
            services.AddScoped<IAirlineWork, AirlineWorker>();
        }
    }
}
