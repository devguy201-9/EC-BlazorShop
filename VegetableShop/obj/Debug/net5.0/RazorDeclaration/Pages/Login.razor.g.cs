// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace VegetableShop.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\_Imports.razor"
using VegetableShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\_Imports.razor"
using VegetableShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\Pages\Login.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\Pages\Login.razor"
using VegetableShop.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\Pages\Login.razor"
using VegetableShop.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\Pages\Login.razor"
       
    private string Load = null;
    private class Model
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    private Model model = new Model();
    private string TxtFromLocalStorage = string.Empty;

    protected async Task Check()
    {

        //Logout
        //await LocalStorage.DeleteAsync("UserSession");

        //Get UserSession from localstorage
        var result = await LocalStorage.GetAsync<string>("UserSession");
        TxtFromLocalStorage = result.Success ? result.Value : "Can't read local storage";
    }


    /*private async Task Authenticate()
    {
        var userAccount = userAccountService.GetByUserName(model.UserName);
        if (userAccount == null || userAccount.Password != model.Password)
        {
            await js.InvokeVoidAsync("alert", "Invalid User Name or Password");
            return;
        }

        var customAuthStateProvider = (CustomAuthenticationStateProvider)authStateProvider;
        await customAuthStateProvider.UpdateAuthenticationState(new UserSession
        {
            UserName = userAccount.UserName,
            Role = userAccount.Role
        });
        navManager.NavigateTo("/", true);
    }*/
    private async Task Authenticate()
    {
        Load = "!ok";

        var userAccount = await userService.GetUsersByUserNameAndPasswordAsync(model.UserName, model.Password);
        if (userAccount == null)
        {
            await js.InvokeVoidAsync("alert", "Invalid User Name or Password");
            return;
        }


        var authState1 = new CustomAuthenticationStateProvider(new UserSession
        {
            UserName = userAccount.user_name,
            Role = userAccount.roles.role_name
        });

        var authState = await authState1.GetAuthenticationStateAsync();
        var user = authState.User;
        if (user.Identity.IsAuthenticated)
        {

            await LocalStorage.SetAsync("UserSession", user.Identity.Name);

            //Get role name from user Identity
            //TxtFromLocalStorage = user.Claims.Last().Value + " is authenticated.";
            Load = "ok";
            await js.InvokeVoidAsync("alert", "Login Success !");
            navManager.NavigateTo("/", true);
        }
        else
        {
            Load = "ok";
            TxtFromLocalStorage = "The user is NOT authenticated.";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleService roleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage LocalStorage { get; set; }
    }
}
#pragma warning restore 1591
