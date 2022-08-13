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
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Handler"></param>
        /// <param name="Token"></param>
        /// <param name="NewCrew"></param>
        /// <returns></returns>
        private async Task<IResult> AddCrewMember([FromServices] CrewHandler Handler, [FromHeader] string Token, [FromBody] Crew NewCrew)
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
        private async Task<IResult> UpdateCrewMember([FromServices] CrewHandler Handler, [FromHeader] string Token, [FromBody] Crew CrewMember)
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
        private async Task<IResult> AddCrewMemberFlight([FromServices] CrewHandler Handler, [FromHeader] string Token, [FromBody] Crew Cremember, int FlightId)
        {

            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void DefineServices(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, CrewHandler>();
        }
    }
}
