#pragma checksum "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\Common\Header.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b114c25c8d35fb73fce5ed2f688237a9bbae5d0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Web.Client.Shared.Common
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
    public partial class Header : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\Common\Header.razor"
 if (categories == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<BlazorShop.Web.Client.Shared.Common.LoadingScreen>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 4 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\Common\Header.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "header");
            __builder.AddAttribute(5, "class", "section-header");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, @"<section class=""navbar-light border-bottom"">
            <div class=""container"">
                <nav class=""d-flex align-items-center flex-column flex-md-row"">
                    <ul class=""nav mr-md-auto"">
                        <li><a href=""#"" class=""nav-link px-2""> <i class=""fab fa-facebook""></i> </a></li>
                        <li><a href=""#"" class=""nav-link px-2""> <i class=""fab fa-instagram""></i> </a></li>
                        <li><a href=""#"" class=""nav-link px-2""> <i class=""fab fa-twitter""></i> </a></li>
                    </ul>

                    <ul class=""nav"">
                        <li><a href=""#"" class=""nav-link""> <i class=""fa fa-comment""></i> Contact </a></li>
                        <li><a href=""#"" class=""nav-link""> <i class=""fa fa-phone""></i> Call us </a></li>
                    </ul>
                </nav>
            </div>
        </section>

        ");
            __builder.OpenElement(8, "section");
            __builder.AddAttribute(9, "class", "header-main border-bottom");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "container");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row align-items-center");
            __builder.AddMarkupContent(16, "\r\n\r\n                    ");
            __builder.AddMarkupContent(17, "<div class=\"col-lg-3 col-sm-4 col-md-4 col-5\">\r\n                        <a href=\"/\" class=\"brand-wrap\">\r\n                            <img class=\"logo\" src=\"images/logo.png\">\r\n                        </a>\r\n                    </div>\r\n\r\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-lg-4 col-xl-5 col-sm-8 col-md-4 d-none d-md-block");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenComponent<BlazorShop.Web.Client.Shared.Navigation.NavSearch>(21);
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-lg-5 col-xl-4 col-sm-8 col-md-4 col-7");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "d-flex justify-content-end");
            __builder.AddMarkupContent(29, "\r\n\r\n                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(30);
            __builder.AddAttribute(31, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(32, "\r\n                                    ");
                __builder2.AddMarkupContent(33, @"<div class=""widget-header mr-3"">
                                        <a href=""/account/login"" class=""icon icon-sm rounded-circle border"">
                                            <i class=""fa fa-shopping-cart""></i>
                                        </a>
                                        <span class=""badge badge-pill badge-danger notify"">0</span>
                                    </div>

                                    ");
                __builder2.AddMarkupContent(34, @"<div class=""widget-header icontext"">
                                        <a href=""#"" class=""icon icon-sm rounded-circle border"">
                                            <i class=""fa fa-user""></i>
                                        </a>
                                        <div class=""text"">
                                            <span class=""text-muted"">Welcome!</span>
                                            <div>
                                                <a href=""/account/login"">Login</a> |
                                                <a href=""/account/register""> Register</a>
                                            </div>
                                        </div>
                                    </div>
                                ");
            }
            ));
            __builder.AddAttribute(35, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n                                    ");
                __builder2.OpenComponent<BlazorShop.Web.Client.Shared.Navigation.NavCart>(37);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n\r\n                                    ");
                __builder2.AddMarkupContent(39, @"<a href=""/wishlist"" class=""widget-header mr-3"">
                                        <div class=""icon"">
                                            <i class=""icon-sm rounded-circle border fa fa-heart""></i>
                                        </div>
                                    </a>

                                    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "widget-header dropdown");
                __builder2.AddMarkupContent(42, "\r\n                                        ");
                __builder2.OpenElement(43, "a");
                __builder2.AddEventPreventDefaultAttribute(44, "onclick", true);
                __builder2.AddAttribute(45, "href", "#");
                __builder2.AddAttribute(46, "data-toggle", "dropdown");
                __builder2.AddAttribute(47, "class", "dropdown-toggle");
                __builder2.AddAttribute(48, "data-offset", "20,10");
                __builder2.AddMarkupContent(49, "\r\n                                            ");
                __builder2.AddMarkupContent(50, "<div class=\"icon icon-sm rounded-circle border \">\r\n                                                <i class=\"fa fa-user\"></i>\r\n                                            </div>\r\n                                            ");
                __builder2.AddMarkupContent(51, "<span class=\"sr-only\">Profile actions</span>\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                                        ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "dropdown-menu dropdown-menu-right");
                __builder2.AddMarkupContent(55, "\r\n                                            ");
                __builder2.AddMarkupContent(56, "<a class=\"dropdown-item\" href=\"/account/settings\">Profile setting</a>\r\n                                            ");
                __builder2.AddMarkupContent(57, "<a class=\"dropdown-item\" href=\"/orders/mine\">My orders</a>\r\n                                            <hr class=\"dropdown-divider\">\r\n                                            ");
                __builder2.OpenComponent<BlazorShop.Web.Client.Pages.Account.Logout>(58);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\r\n        ");
            __builder.OpenElement(68, "nav");
            __builder.AddAttribute(69, "class", "navbar navbar-main navbar-expand-md border-bottom");
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "container");
            __builder.AddMarkupContent(73, "\r\n\r\n                ");
            __builder.OpenComponent<BlazorShop.Web.Client.Shared.Navigation.NavMobileSearch>(74);
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\r\n\r\n                ");
            __builder.AddMarkupContent(76, "<button class=\"navbar-toggler\" type=\"button\" data-toggle=\"collapse\" data-target=\"#dropdown6\">\r\n                    <span class=\"navbar-toggler-icon\"></span>\r\n                </button>\r\n\r\n                ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "collapse navbar-collapse");
            __builder.AddAttribute(79, "id", "dropdown6");
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.OpenElement(81, "ul");
            __builder.AddAttribute(82, "class", "navbar-nav mr-auto");
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.AddMarkupContent(84, "<li class=\"nav-item\">\r\n                            <a class=\"nav-link pl-0\" href=\"/\"> <strong>Home</strong></a>\r\n                        </li>\r\n                        ");
            __builder.AddMarkupContent(85, "<li class=\"nav-item\">\r\n                            <a class=\"nav-link\" href=\"/wishlist\">Wishlist</a>\r\n                        </li>\r\n                        ");
            __builder.AddMarkupContent(86, "<li class=\"nav-item\">\r\n                            <a class=\"nav-link\" href=\"/products/page/1\">Products</a>\r\n                        </li>\r\n                        ");
            __builder.OpenElement(87, "li");
            __builder.AddAttribute(88, "class", "nav-item dropdown");
            __builder.AddMarkupContent(89, "\r\n                            ");
            __builder.OpenElement(90, "a");
            __builder.AddEventPreventDefaultAttribute(91, "onclick", true);
            __builder.AddAttribute(92, "class", "nav-link dropdown-toggle");
            __builder.AddAttribute(93, "href", "");
            __builder.AddAttribute(94, "data-toggle", "dropdown");
            __builder.AddAttribute(95, "aria-haspopup", "true");
            __builder.AddAttribute(96, "aria-expanded", "false");
            __builder.AddMarkupContent(97, "\r\n                                Categories\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                            ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "dropdown-menu");
            __builder.AddMarkupContent(101, "\r\n");
#nullable restore
#line 130 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\Common\Header.razor"
                                 foreach (var category in categories)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "                                    ");
            __builder.OpenElement(103, "a");
            __builder.AddAttribute(104, "class", "dropdown-item");
            __builder.AddAttribute(105, "href", "/products/category/" + (
#nullable restore
#line 133 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\Common\Header.razor"
                                                                 category.Name

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 133 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\Common\Header.razor"
                                                                                category.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(106, "\r\n                                        ");
            __builder.AddContent(107, 
#nullable restore
#line 134 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\Common\Header.razor"
                                         category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(108, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
#nullable restore
#line 136 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\Common\Header.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(114);
            __builder.AddAttribute(115, "Roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 141 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\Common\Header.razor"
                                           Constants.AdministratorRole

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(117, "\r\n                        ");
                __builder2.AddMarkupContent(118, @"<ul class=""navbar-nav"">
                            <li class=""nav-item"">
                                <a href=""/products/add"" class=""btn btn-primary ml-md-4"">
                                    <i class=""fa fa-plus""></i> Add product
                                </a>
                            </li>
                        </ul>
                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(119, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n");
#nullable restore
#line 155 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Shared\Common\Header.razor"
}

#line default
#line hidden
#nullable disable
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
