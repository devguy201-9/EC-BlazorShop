#pragma checksum "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\AccountSidebar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ff184b6b7ce4d8259f00f389829c1e9d5fed3f6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Web.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models.Addresses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models.ShoppingCarts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models.Wishlists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services.Addresses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services.ShoppingCarts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services.Wishlists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Shared.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Shared.Navigation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Shared.Products;

#line default
#line hidden
#nullable disable
    public partial class AccountSidebar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "aside");
            __builder.AddAttribute(1, "class", "col-md-3");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "list-group");
            __builder.AddMarkupContent(5, "\r\n\r\n");
#nullable restore
#line 4 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\AccountSidebar.razor"
         if (NavigationManager.Uri.Contains("overview"))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.AddMarkupContent(7, "<a class=\"list-group-item active\" href=\"/account/overview\"> Account overview  </a>\r\n            ");
            __builder.AddMarkupContent(8, "<a class=\"list-group-item\" href=\"/orders/mine\"> My orders </a>\r\n            ");
            __builder.AddMarkupContent(9, "<a class=\"list-group-item\" href=\"/addresses\"> My addresses </a>\r\n            ");
            __builder.AddMarkupContent(10, "<a class=\"list-group-item\" href=\"/account/settings\"> Settings </a>\r\n            ");
            __builder.AddMarkupContent(11, "<a class=\"list-group-item\" href=\"/account/password\"> Change Password </a>\r\n");
#nullable restore
#line 11 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\AccountSidebar.razor"
        }
        else if (NavigationManager.Uri.Contains("orders"))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "            ");
            __builder.AddMarkupContent(13, "<a class=\"list-group-item\" href=\"/account/overview\"> Account overview  </a>\r\n            ");
            __builder.AddMarkupContent(14, "<a class=\"list-group-item active\" href=\"/orders/mine\"> My orders </a>\r\n            ");
            __builder.AddMarkupContent(15, "<a class=\"list-group-item\" href=\"/addresses\"> My addresses </a>\r\n            ");
            __builder.AddMarkupContent(16, "<a class=\"list-group-item\" href=\"/account/settings\"> Settings </a>\r\n            ");
            __builder.AddMarkupContent(17, "<a class=\"list-group-item\" href=\"/account/passsword\"> Change Password </a>\r\n");
#nullable restore
#line 19 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\AccountSidebar.razor"
        }
        else if (NavigationManager.Uri.Contains("addresses"))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "            ");
            __builder.AddMarkupContent(19, "<a class=\"list-group-item\" href=\"/account/overview\"> Account overview  </a>\r\n            ");
            __builder.AddMarkupContent(20, "<a class=\"list-group-item\" href=\"/orders/mine\"> My orders </a>\r\n            ");
            __builder.AddMarkupContent(21, "<a class=\"list-group-item active\" href=\"/addresses\"> My addresses </a>\r\n            ");
            __builder.AddMarkupContent(22, "<a class=\"list-group-item\" href=\"/account/settings\"> Settings </a>\r\n            ");
            __builder.AddMarkupContent(23, "<a class=\"list-group-item\" href=\"/account/password\"> Change Password </a>\r\n");
#nullable restore
#line 27 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\AccountSidebar.razor"
        }
        else if (NavigationManager.Uri.Contains("settings"))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "            ");
            __builder.AddMarkupContent(25, "<a class=\"list-group-item\" href=\"/account/overview\"> Account overview  </a>\r\n            ");
            __builder.AddMarkupContent(26, "<a class=\"list-group-item\" href=\"/orders/mine\"> My orders </a>\r\n            ");
            __builder.AddMarkupContent(27, "<a class=\"list-group-item\" href=\"/addresses\"> My addresses </a>\r\n            ");
            __builder.AddMarkupContent(28, "<a class=\"list-group-item active\" href=\"/account/settings\"> Settings </a>\r\n            ");
            __builder.AddMarkupContent(29, "<a class=\"list-group-item\" href=\"/account/password\"> Change Password </a>\r\n");
#nullable restore
#line 35 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\AccountSidebar.razor"
        }
        else if (NavigationManager.Uri.Contains("password"))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "            ");
            __builder.AddMarkupContent(31, "<a class=\"list-group-item\" href=\"/account/overview\"> Account overview  </a>\r\n            ");
            __builder.AddMarkupContent(32, "<a class=\"list-group-item\" href=\"/orders/mine\"> My orders </a>\r\n            ");
            __builder.AddMarkupContent(33, "<a class=\"list-group-item\" href=\"/addresses\"> My addresses </a>\r\n            ");
            __builder.AddMarkupContent(34, "<a class=\"list-group-item\" href=\"/account/settings\"> Settings </a>\r\n            ");
            __builder.AddMarkupContent(35, "<a class=\"list-group-item active\" href=\"/account/password\"> Change Password </a>\r\n");
#nullable restore
#line 43 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\AccountSidebar.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n    <br>\r\n\r\n    ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "class", "btn btn-light btn-block");
            __builder.AddAttribute(40, "href", "/");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\AccountSidebar.razor"
                                                          Submit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "\r\n        <i class=\"fas fa-sign-out-alt\"></i> ");
            __builder.AddMarkupContent(43, "<span class=\"text\">Log out</span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWishlistsService WishlistsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IShoppingCartsService ShoppingCartsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductsService ProductsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrdersService OrdersService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoriesService CategoriesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAddressesService AddressesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApiAuthenticationStateProvider AuthState { get; set; }
    }
}
#pragma warning restore 1591
