#pragma checksum "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a36957e3a21d739ec8a0ab61bdd2d8fffee73989"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Web.Client.Pages.Account
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
#nullable restore
#line 2 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/account/overview")]
    public partial class Overview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
 if (orders == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<BlazorShop.Web.Client.Shared.Common.LoadingScreen>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "section");
            __builder.AddAttribute(5, "class", "section-content padding-y bg");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container");
            __builder.AddMarkupContent(9, "\r\n\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.AddMarkupContent(12, "\r\n\r\n                ");
            __builder.OpenComponent<BlazorShop.Web.Client.Shared.AccountSidebar>(13);
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n                ");
            __builder.OpenElement(15, "main");
            __builder.AddAttribute(16, "class", "col-md-9");
            __builder.AddMarkupContent(17, "\r\n\r\n                    ");
            __builder.OpenElement(18, "article");
            __builder.AddAttribute(19, "class", "card mb-3");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-body");
            __builder.AddMarkupContent(23, "\r\n\r\n                            ");
            __builder.OpenElement(24, "figure");
            __builder.AddAttribute(25, "class", "icontext");
            __builder.AddMarkupContent(26, "\r\n                                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "text");
            __builder.AddMarkupContent(29, "\r\n                                    ");
            __builder.OpenElement(30, "strong");
            __builder.AddContent(31, " ");
            __builder.AddContent(32, 
#nullable restore
#line 24 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
                                              firstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(33, " ");
            __builder.AddContent(34, 
#nullable restore
#line 24 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
                                                         lastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                                    <br>\r\n                                    ");
            __builder.AddContent(37, 
#nullable restore
#line 26 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
                                     email

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, "\r\n                                    <br>\r\n                                    ");
            __builder.AddMarkupContent(39, "<a href=\"/account/settings\">Edit</a>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            <hr>\r\n                            ");
            __builder.AddMarkupContent(42, @"<p>
                                <i class=""fa fa-map-marker text-muted""></i> &nbsp; My address:
                                <br>
                                Tashkent city, Street name, Building 123, House 321 &nbsp;
                                <a href=""/addresses"" class=""btn-link""> Edit </a>
                            </p>

                            ");
            __builder.OpenElement(43, "article");
            __builder.AddAttribute(44, "class", "card-group");
            __builder.AddMarkupContent(45, "\r\n                                ");
            __builder.OpenElement(46, "figure");
            __builder.AddAttribute(47, "class", "card bg");
            __builder.AddMarkupContent(48, "\r\n                                    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "p-3");
            __builder.AddMarkupContent(51, "\r\n                                        ");
            __builder.OpenElement(52, "h5");
            __builder.AddAttribute(53, "class", "card-title");
            __builder.AddContent(54, 
#nullable restore
#line 42 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
                                                                orders.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                        ");
            __builder.AddMarkupContent(56, "<span>Orders</span>\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                ");
            __builder.AddMarkupContent(59, @"<figure class=""card bg"">
                                    <div class=""p-3"">
                                        <h5 class=""card-title"">5</h5>
                                        <span>Wishlists</span>
                                    </div>
                                </figure>
                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\r\n                    ");
            __builder.OpenElement(63, "article");
            __builder.AddAttribute(64, "class", "card  mb-3");
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "card-body");
            __builder.AddMarkupContent(68, "\r\n                            ");
            __builder.AddMarkupContent(69, "<h5 class=\"card-title mb-4\">Recent orders </h5>\r\n\r\n                            ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "row");
            __builder.AddMarkupContent(72, "\r\n\r\n");
#nullable restore
#line 63 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
                                 foreach (var order in orders)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "                                    ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "col-md-6");
            __builder.AddMarkupContent(76, "\r\n                                        ");
            __builder.OpenElement(77, "figure");
            __builder.AddAttribute(78, "class", "itemside  mb-3");
            __builder.AddMarkupContent(79, "\r\n\r\n                                            ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "aside");
            __builder.AddMarkupContent(82, "\r\n                                                ");
            __builder.OpenElement(83, "a");
            __builder.AddAttribute(84, "href", "/order/details/" + (
#nullable restore
#line 69 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
                                                                         order.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(85, "\r\n                                                    ");
            __builder.OpenElement(86, "img");
            __builder.AddAttribute(87, "src", 
#nullable restore
#line 70 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
                                                               order.ProductImageSource

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(88, "class", "border img-sm");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                                            ");
            __builder.OpenElement(92, "figcaption");
            __builder.AddAttribute(93, "class", "info");
            __builder.AddMarkupContent(94, "\r\n                                                ");
            __builder.OpenElement(95, "a");
            __builder.AddAttribute(96, "href", "/order/details/" + (
#nullable restore
#line 74 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
                                                                         order.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(97, "\r\n                                                    ");
            __builder.OpenElement(98, "time");
            __builder.AddAttribute(99, "class", "text-muted");
            __builder.AddMarkupContent(100, "<i class=\"fa fa-calendar-alt\"></i> ");
            __builder.AddContent(101, 
#nullable restore
#line 75 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
                                                                                                                 order.CreatedOn

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(102, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                                                    ");
            __builder.OpenElement(104, "p");
            __builder.AddAttribute(105, "class", "black");
            __builder.AddContent(106, " ");
            __builder.AddContent(107, 
#nullable restore
#line 76 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
                                                                       order.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(108, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                                                    ");
            __builder.AddMarkupContent(110, "<span class=\"text-success\">Sent</span>\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 83 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(115, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n\r\n                            ");
            __builder.AddMarkupContent(117, "<a href=\"/orders/mine\" class=\"btn btn-outline-primary\"> See all orders  </a>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n");
#nullable restore
#line 96 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Overview.razor"
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
