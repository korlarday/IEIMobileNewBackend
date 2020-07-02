using System.Threading.Tasks;
using IEIMobile.Models;
using IEIMobile.Repository.Interfaces;
using Microsoft.Identity.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;
using IEIMobile.Models.Dtos;

namespace IEIMobile.Repository.Mock
{
    public class MockUserRepo : IUserRepo
    {
        private readonly IConfiguration configuration;
        public MockUserRepo(IConfiguration iConfig)
        {
            configuration = iConfig;
        }

        public bool Authenticate(User user)
        {
            if(user.Pin == "PEN110007768292" && user.Password == "D2J1t0"){
                return true;
            }
            return false;
        }

        public async Task<string> GetToken(User user)
        {
            IConfidentialClientApplication app;
            var authority = String.Format(
                                CultureInfo.InvariantCulture, 
                                configuration.GetValue<string>("ClientConfig:Instance"), 
                                configuration.GetValue<string>("ClientConfig:TenantId"));
            app = ConfidentialClientApplicationBuilder.Create(
                    configuration.GetValue<string>("ClientConfig:ClientId"))
                    .WithClientSecret(configuration.GetValue<string>("ClientConfig:ClientSecret"))
                    .WithAuthority(new Uri(authority))
                    .Build();

            string[] ResourceIds = new string[] { configuration.GetValue<string>("ClientConfig:ResourceId") };

            AuthenticationResult result = null;

            result = await app.AcquireTokenForClient(ResourceIds).ExecuteAsync();
            return result.AccessToken;
        }

        public async Task<AuthDataDto> SignUserIn(User user)
        {
            AuthDataDto authData = new AuthDataDto{
                Pin = user.Pin,
                Status = "Success",
                Message = "Login in was successful",
                Token = await GetToken(user),
                ExpirationTime = 1200
            };
            return authData;
        }

    }
}