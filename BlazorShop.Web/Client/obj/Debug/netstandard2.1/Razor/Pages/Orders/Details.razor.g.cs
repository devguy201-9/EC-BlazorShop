#pragma checksum "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10f41bc016f8b3e0f205ced69dd0fe8cc1e2ba84"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Web.Client.Pages.Orders
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
#line 2 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/order/details/{Id}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
 if (order == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<BlazorShop.Web.Client.Shared.Common.LoadingScreen>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "section");
            __builder.AddAttribute(5, "class", "section-pagetop bg");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "h2");
            __builder.AddAttribute(11, "class", "title-page text-center");
            __builder.AddContent(12, "Order #");
            __builder.AddContent(13, 
#nullable restore
#line 12 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
                                                       Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.AddContent(17, "    ");
            __builder.OpenElement(18, "section");
            __builder.AddAttribute(19, "class", "section-content padding-y bg");
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "container");
            __builder.AddMarkupContent(23, "\r\n\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card mb-3");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "article");
            __builder.AddAttribute(28, "class", "card-body");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.AddMarkupContent(30, "<header class=\"mb-4\">\r\n                        <h4 class=\"card-title\">Order details</h4>\r\n                    </header>\r\n                    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
            __builder.AddMarkupContent(33, "\r\n\r\n");
#nullable restore
#line 26 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
                         foreach (var product in order.Products)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-md-6");
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.OpenElement(38, "figure");
            __builder.AddAttribute(39, "class", "itemside  mb-3");
            __builder.AddMarkupContent(40, "\r\n                                    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "aside");
            __builder.AddMarkupContent(43, "\r\n                                        ");
            __builder.OpenElement(44, "img");
            __builder.AddAttribute(45, "src", 
#nullable restore
#line 31 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
                                                   product.ImageSource

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(46, "class", "border img-xs");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                                    ");
            __builder.OpenElement(49, "figcaption");
            __builder.AddAttribute(50, "class", "info");
            __builder.AddMarkupContent(51, "\r\n                                        ");
            __builder.OpenElement(52, "p");
            __builder.AddContent(53, " ");
            __builder.AddContent(54, 
#nullable restore
#line 34 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
                                             product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(55, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                                        ");
            __builder.OpenElement(57, "span");
            __builder.AddContent(58, " ");
            __builder.AddContent(59, 
#nullable restore
#line 35 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
                                                product.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(60, " x $");
            __builder.AddContent(61, 
#nullable restore
#line 35 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
                                                                     product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(62, " = Total: $");
            __builder.AddContent(63, 
#nullable restore
#line 35 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
                                                                                               product.Price * product.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(64, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 39 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.OpenElement(72, "article");
            __builder.AddAttribute(73, "class", "card-body border-top");
            __builder.AddMarkupContent(74, "\r\n\r\n                    ");
            __builder.OpenElement(75, "dl");
            __builder.AddAttribute(76, "class", "row");
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.AddMarkupContent(78, "<dt class=\"col-sm-10\">Created on: </dt>\r\n                        ");
            __builder.OpenElement(79, "dd");
            __builder.AddAttribute(80, "class", "col-sm-2 text-right");
            __builder.OpenElement(81, "strong");
            __builder.AddContent(82, 
#nullable restore
#line 47 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
                                                                 order.CreatedOn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\r\n                        ");
            __builder.OpenElement(84, "dt");
            __builder.AddAttribute(85, "class", "col-sm-10");
            __builder.AddContent(86, "Subtotal: ");
            __builder.OpenElement(87, "span");
            __builder.AddAttribute(88, "class", "float-right text-muted");
            __builder.AddContent(89, 
#nullable restore
#line 49 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
                                                                                              order.Products.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(90, " items");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                        ");
            __builder.OpenElement(92, "dd");
            __builder.AddAttribute(93, "class", "col-sm-2 text-right");
            __builder.OpenElement(94, "strong");
            __builder.AddContent(95, "$");
            __builder.AddContent(96, 
#nullable restore
#line 50 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
                                                                  totalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n\r\n                        ");
            __builder.AddMarkupContent(98, "<dt class=\"col-sm-10\">Discount: <span class=\"float-right text-muted\">0%</span></dt>\r\n                        ");
            __builder.AddMarkupContent(99, "<dd class=\"col-sm-2 text-danger text-right\"><strong>$0</strong></dd>\r\n\r\n                        ");
            __builder.AddMarkupContent(100, "<dt class=\"col-sm-10\">Delivery charge: <span class=\"float-right text-muted\">Standard Delivery</span></dt>\r\n                        ");
            __builder.AddMarkupContent(101, "<dd class=\"col-sm-2 text-right\"><strong>Free</strong></dd>\r\n\r\n                        ");
            __builder.AddMarkupContent(102, "<dt class=\"col-sm-10\">Total:</dt>\r\n                        ");
            __builder.OpenElement(103, "dd");
            __builder.AddAttribute(104, "class", "col-sm-2 text-right");
            __builder.OpenElement(105, "strong");
            __builder.AddAttribute(106, "class", "h5 text-dark");
            __builder.AddContent(107, "$");
            __builder.AddContent(108, 
#nullable restore
#line 59 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
                                                                                       totalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 67 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Orders\Details.razor"
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
