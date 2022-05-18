using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace VegetableShop.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private UserSession userSession;

        public CustomAuthenticationStateProvider(UserSession userSession )
        {
            this.userSession = userSession;
        }
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity(new[]
          {
            new Claim(ClaimTypes.Name, userSession.UserName),
            new Claim(ClaimTypes.Role, userSession.Role)
            },"CustomAuth");
            
            var user = new ClaimsPrincipal(identity);
            return Task.FromResult(new AuthenticationState(user));

        }

    }
       
    }

