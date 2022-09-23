namespace ReactFlightServices.Endpoints
{
    public class ClerkEndpoints : IEndpointExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public void DefineEndpoints(WebApplication app)
        {
            app.MapPost("/AirportClerk/AddClerk", AddClerk).WithDisplayName("Add New Clerk");

            app.MapPost("/AirportClerk/UpdateClerk", UpdateClerk).WithDisplayName("Update Clerk Info");

            app.MapPost("/AirportClerk/AddPassenger", AddPassenger).WithDisplayName("Add Passenger Account");

            app.MapPost("/AirportClerk/UpdatePassenger", UpdatePassenger).WithDisplayName("Update Passenger Info");

            app.MapPost("/AirportClerk/SellTicket", SellTicket);

            app.MapPost("/AirportClerk/RefundTicket", RefundTicket);



        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void DefineServices(IServiceCollection services)
        {
            services.AddScoped<ITicketClerkWork, TicketClerkWorker>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewClerk"></param>
        /// <returns></returns>
        private async Task<IResult> AddClerk(TicketClerk NewClerk)
        {


            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UpdatedClerk"></param>
        /// <returns></returns>
        private async Task<IResult> UpdateClerk(TicketClerk UpdatedClerk)
        {


            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PassengerId"></param>
        /// <param name="ClerkId"></param>
        /// <returns></returns>
        private async Task<IResult> SellTicket(int PassengerId, int ClerkId)
        {


            return Results.Ok();
        }


        private async Task<IResult> RefundTicket(int PassengerId, int TicketId)
        {


            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewPassenger"></param>
        /// <returns></returns>
        private async Task<IResult> AddPassenger(Passenger NewPassenger)
        {

            return Results.Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UpdatedPassenger"></param>
        /// <returns></returns>
        private async Task<IResult> UpdatePassenger(Passenger UpdatedPassenger)
        {


            return Results.Ok();
        }


    }
}
