using System.Security.Claims;

namespace ReactFlightServices.Services.Token
{
    public class TokenService
    {
        IConfiguration config;

        JwtSecurityToken? loginToken;

        List<Claim>? claims;
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
                                 GetClaims("pilot", pilot, null, null, null),
                                 DateTime.Now,
                                 DateTime.Now.AddHours(12),
                                 credentials);
            }

            if (crew is not null)
            {
                loginToken = new(config["JWT:Issuer"],
                                 config["JWT:Audience"],
                                 GetClaims("crew", null, null, crew, null),
                                 DateTime.Now,
                                 DateTime.Now.AddHours(12),
                                 credentials);

            }
            if (passenger is not null)
            {
                loginToken = new(config["JWT:Issuer"],
                                 config["JWT:Audience"],
                                 GetClaims("passenger", null, passenger, null, null),
                                 DateTime.Now,
                                 DateTime.Now.AddHours(12),
                                 credentials);

            }
            if (clerk is not null)
            {
                loginToken = new(config["JWT:Issuer"],
                                 config["JWT:Audience"],
                                 GetClaims("clerk", null, null, null, clerk),
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
        internal List<Claim> GetClaims(string UserType, Pilot? pilot = null, Passenger? passenger = null, Crew? crew = null, TicketClerk? clerk = null)
        {
            if (pilot is not null)
            {
                claims = new()
                {
                    
                };
            }
            if (crew is not null)
            {
                claims = new()
                {

                };

            }
            if (clerk is not null)
            {
                claims = new()
                {

                };

            }
            if (passenger is not null)
            {
                claims = new()
                {

                };

            }
            
            return claims!;
        }


    }

}
