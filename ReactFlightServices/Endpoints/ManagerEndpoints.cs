namespace ReactFlightServices.Endpoints
{
    public class ManagerEndpoints : IEndpointExtensions
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public void DefineEndpoints(WebApplication app)
        {
            app.MapPost("/FlightServices/AddAirport", AddAirport);

            app.MapPost("/FlightServices/UpdateAirport", UpdateAirport);

            app.MapPost("/FlightServices/AddAirline", AddAirline);

            app.MapPost("/FlightServices/UpdateAirline", UpdateAirline);

            app.MapPost("/FlightServices/AddTerminal", AddTerminal);

            app.MapPost("/FlightServices/UpdateTerminal", UpdateTerminal);

            app.MapPost("/FlightServices/OpenTerminal", OpenTerminal);

            app.MapPost("/FlightServices/CloseTerminal", CloseTerminal);

            app.MapPost("/FlightServices/AddFlight", AddFlight);

            app.MapPost("/FlightServices/UpdateFlightStatus", UpdateFlightStatus);

            app.MapPost("/FlightServices/AddFLightToGate", AddFlightToGate);

            app.MapPost("/FlightServices/AddPilot", AddPilot);

            app.MapPost("/FlightServices/UpdatePilot", UpdatePilot);

            app.MapPost("/FlightServices/AddPilotToFlight", AddPilotToFlight);

            app.MapPost("/FlightServices/AddPassenger", AddPassenger);

            app.MapPost("/FlightServices/UpdatePassenger", UpdatePassenger);

            app.MapPost("/FlightServices/AddGate", AddGate);

            app.MapPost("/FlightServices/UpdateGate", UpdateGate);

            app.MapPost("/FlightServices/OpenGate", OpenGate);

            app.MapPost("/FlightServices/CloseGate", CloseGate);

            app.MapPost("/FlightServices/AddVendor", AddVendor);

            app.MapPost("/FlightServices/UpdateVendor", UpdateVendor);

            app.MapPost("/FlightServices/OpenVendor", OpenVendor);

            app.MapPost("/FlightServices/CloseVendor", CloseVendor);

            app.MapPost("/FlightServices/AddClerk", AddClerk);

            app.MapPost("/FlightServices/UpdateClerk", UpdateClerk);

            app.MapPost("/FlightServices/AddCrew", AddCrew);

            app.MapPost("/FlightServices/UpdateCrew", UpdateCrew);

            app.MapPost("/FlightServices/AddCrewtoFlight", AddCrewToFlight);


        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void DefineServices(IServiceCollection services)
        {
            services.AddScoped<IManagerWork, ManagerWorker>();
        }



        private async Task<IResult> AddAirport(Airport NewAiport)
        {

            return Results.Ok();
        }


        private async Task<IResult> UpdateAirport(Airport UpdatedAirport)
        {


            return Results.Ok();
        }


        private async Task<IResult> AddAirline(Airline NewAirline)
        {


            return Results.Ok();
        }


        private async Task<IResult> UpdateAirline(Airline UpdatedAirline)
        {


            return Results.Ok();
        }


        private async Task<IResult> AddTerminal(Terminal NewTerminal)
        {


            return Results.Ok();
        }

        
        private async Task<IResult> UpdateTerminal(Terminal UpdatedTerminal)
        {


            return Results.Ok();
        }


        private async Task<IResult> OpenTerminal(int TerminalId)
        {


            return Results.Ok();
        }


        private async Task<IResult> CloseTerminal(int TerminalId)
        {


            return Results.Ok();
        }


        private async Task<IResult> AddGate(Gate NewGate)
        {


            return Results.Ok();
        }


        private async Task<IResult> UpdateGate(Gate UpdatedGate)
        {


            return Results.Ok();
        }


        private async Task<IResult> OpenGate(int GateId)
        {


            return Results.Ok();
        }


        private async Task<IResult> CloseGate(int GateId)
        {


            return Results.Ok();
        }


        private async Task<IResult> AddFlight(Flight NewFlight)
        {


            return Results.Ok();
        }


        private async Task<IResult> UpdateFlightStatus(int FlightId)
        {


            return Results.Ok();
        }


        private async Task<IResult> AddVendor(Vendor NewVendor)
        {


            return Results.Ok();
        }


        private async Task<IResult> UpdateVendor(Vendor NewVendor)
        {


            return Results.Ok();
        }


        private async Task<IResult> OpenVendor(int VendorId)
        {


            return Results.Ok();
        }


        private async Task<IResult> CloseVendor(int VendorId)
        {


            return Results.Ok();
        }


        private async Task<IResult> AddPassenger(Passenger NewPassenger)
        {


            return Results.Ok();
        }


        private async Task<IResult> UpdatePassenger(Passenger UpdatedPassenger)
        {


            return Results.Ok();
        }


        private async Task<IResult> AddPilot(Pilot NewPilot)
        {


            return Results.Ok();
        }


        private async Task<IResult> UpdatePilot(Pilot UpdatedPilot)
        {


            return Results.Ok();
        }


        private async Task<IResult> AddPilotToFlight(int PilotId, int FlightId)
        {


            return Results.Ok();
        }


        private async Task<IResult> AddFlightToGate(int FlightId, int GateId)
        {


            return Results.Ok();
        }


        private async Task<IResult> AddClerk(TicketClerk NewClerk)
        {


            return Results.Ok();
        }


        private async Task<IResult> UpdateClerk(TicketClerk UpdatedClerk)
        {


            return Results.Ok();
        }


        private async Task<IResult> AddCrew(Crew NewCrew)
        {


            return Results.Ok();
        }

        private async Task<IResult> UpdateCrew(Crew UpdatedCrew)
        {


            return Results.Ok();
        }

        private async Task<IResult> AddCrewToFlight(int CrewId, int FlightId)
        {


            return Results.Ok();
        }















    }
}
