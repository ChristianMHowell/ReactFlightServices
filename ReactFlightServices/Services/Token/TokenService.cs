using System.Security.Claims;

namespace ReactFlightServices.Services
{
    public class TokenService
    {
        IConfiguration config;

        JwtSecurityToken? loginToken;

        List<Claim>? claims;
        string? ClaimName;
        public TokenService(IConfiguration Config)
        {
            config = Config;
        }

        public string GetToken(Pilot? pilot = null, Passenger? passenger = null, Crew? crew = null, TicketClerk? clerk = null)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var handler = new JwtSecurityTokenHandler();

            if (pilot is not null)
            {
                loginToken = new(config["JWT:Issuer"],
                                 config["JWT:Audience"],
                                 GetClaims(pilot, null, null, null),
                                 DateTime.Now,
                                 DateTime.Now.AddHours(12),
                                 credentials);
            }

            if (crew is not null)
            {
                loginToken = new(config["JWT:Issuer"],
                                 config["JWT:Audience"],
                                 GetClaims(null, null, crew, null),
                                 DateTime.Now,
                                 DateTime.Now.AddHours(12),
                                 credentials);

            }
            if (passenger is not null)
            {
                loginToken = new(config["JWT:Issuer"],
                                 config["JWT:Audience"],
                                 GetClaims(null, passenger, null, null),
                                 DateTime.Now,
                                 DateTime.Now.AddHours(12),
                                 credentials);

            }
            if (clerk is not null)
            {
                loginToken = new(config["JWT:Issuer"],
                                 config["JWT:Audience"],
                                 GetClaims(null, null, null, clerk),
                                 DateTime.Now,
                                 DateTime.Now.AddHours(12),
                                 credentials);

            }
            var tokenResult = handler.WriteToken(loginToken);

            return tokenResult;
        }


                /// <summary>
        /// 
        /// </summary>
        /// <param name="PilotForClaims"></param>
        /// <returns></returns>
        internal List<Claim> GetClaims(Pilot? pilot = null, Passenger? passenger = null, Crew? crew = null, TicketClerk? clerk = null)
        {
            if (pilot is not null)
            {
                ClaimName = pilot.FirstName + " " + pilot.MiddleName ?? "" + " " + pilot.LastName;
                claims = new()
                {
                    new Claim(ClaimTypes.Name, ClaimName),
                    new Claim(ClaimTypes.Email, pilot.PilotEmail),
                    new Claim(ClaimTypes.GivenName, pilot.FirstName),
                    new Claim(ClaimTypes.Surname, pilot.LastName),
                    new Claim(ClaimTypes.Role, "pilot")

                };
            }
            if (crew is not null)
            {
                ClaimName = crew.CrewFirst + " " + crew.CrewMiddle ?? "" + crew.CrewLast;
                claims = new()
                {
                    new Claim(ClaimTypes.Name, ClaimName),
                    new Claim(ClaimTypes.Email, crew.CrewEmail),
                    new Claim(ClaimTypes.GivenName, crew.CrewFirst),
                    new Claim(ClaimTypes.Surname, crew.CrewLast),
                    new Claim(ClaimTypes.Role, "crew"),
                };

            }
            if (clerk is not null)
            {
                ClaimName = clerk.ClerkFirst + " " + clerk.ClerkMiddle ?? "" + " " + clerk.ClerkLast;
                claims = new()
                {
                    new Claim(ClaimTypes.Name, ClaimName),
                    new Claim(ClaimTypes.Email, clerk.ClerkFirst),
                    new Claim(ClaimTypes.GivenName, clerk.ClerkFirst),
                    new Claim(ClaimTypes.Surname, clerk.ClerkLast),
                    new Claim(ClaimTypes.Role, "clerk"),
                };

            }
            if (passenger is not null)
            {
                ClaimName = passenger.FirstName + " " + passenger.LastName;
                claims = new()
                {
                    new Claim(ClaimTypes.Name, ClaimName),
                    new Claim(ClaimTypes.Email,passenger.EmailAddress),
                    new Claim(ClaimTypes.GivenName,passenger.FirstName),
                    new Claim(ClaimTypes.Surname, passenger.LastName),
                    new Claim(ClaimTypes.Role, "passenger"),
                };

            }
            
            return claims!;
        }


    }

}
