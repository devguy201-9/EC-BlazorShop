﻿using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApplication1.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ProtectedSessionStorage _sessionStorage;
        private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());
        private UserSession userSession;

        public CustomAuthenticationStateProvider(ProtectedSessionStorage sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }

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
            //try
            //{
            //    var userSessionStorageResult = await _sessionStorage.GetAsync<UserSession>("UserSession");
            //    var userSession = userSessionStorageResult.Success ? userSessionStorageResult.Value : null;

            //    if (userSession == null)
            //        return await Task.FromResult(new AuthenticationState(_anonymous));
            //    var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
            //{
            //    new Claim(ClaimTypes.Name, userSession.UserName),
            //    new Claim(ClaimTypes.Role, userSession.Role)
            //}, "CustomAuth"));

            //    return await Task.FromResult(new AuthenticationState(claimsPrincipal));
            //}
            //catch
            //{
            //    return await Task.FromResult(new AuthenticationState(_anonymous));
            //}
        

    ////public async Task UpdateAuthenticationState(UserSession userSession)
    ////    {
    ////        ClaimsPrincipal claimsPrincipal;
    ////        if ( userSession != null)
    ////        {
    ////            await _sessionStorage.SetAsync("UserSession", userSession);
    ////            claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
    ////                {
    ////                    new Claim(ClaimTypes.Name, userSession.UserName),
    ////                    new Claim(ClaimTypes.Role, userSession.Role)
    ////                }, "CustomAuth"));

    ////        }

    ////        else
    ////        {
    ////            await _sessionStorage.DeleteAsync("UserSession");
    ////            claimsPrincipal = _anonymous;
    ////        }

    ////        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
       
       
    }

