namespace ReactFlightServices.Endpoints
{
    public class VendorEndpoints : IEndpointExtensions
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
        /// <param name="handler"></param>
        /// <param name="AirportId"></param>
        /// <returns></returns>
        private async Task<IResult> GetAllVendorsByAirport([FromServices] VendorHandler handler, int AirportId)
        {

            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="TerminalId"></param>
        /// <returns></returns>
        private async Task<IResult> GetAllVendorsByTerminal([FromServices] VendorHandler handler, [FromHeader]string Token, [FromBody] int TerminalId)
        {


            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="VendorId"></param>
        /// <returns></returns>
        private async Task<IResult> GetVendorById([FromServices] VendorHandler handler, [FromHeader] string Token, int VendorId)
        {


            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="NewVendor"></param>
        /// <returns></returns>
        private async Task<IResult> AddVendor([FromServices] VendorHandler handler, [FromHeader] string Token, [FromBody] Vendor NewVendor)
        {


            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void DefineServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, VendorHandler>();
        }
    }
}
