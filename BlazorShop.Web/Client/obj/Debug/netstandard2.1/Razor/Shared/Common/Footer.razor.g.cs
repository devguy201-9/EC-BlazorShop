#pragma checksum "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Shared\Common\Footer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452f36d2190a9b38b8c55fba909d4984e39cb281"
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
#line 1 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models.Addresses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models.ShoppingCarts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Models.Wishlists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services.Addresses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services.ShoppingCarts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Infrastructure.Services.Wishlists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Shared.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Shared.Navigation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\_Imports.razor"
using BlazorShop.Web.Client.Shared.Products;

#line default
#line hidden
#nullable disable
    public partial class Footer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<footer class=\"section-footer border-top\">\r\n    <div class=\"container\">\r\n        <section class=\"footer-top  padding-y\">\r\n            <div class=\"row\">\r\n                <aside class=\"col-md-4 col-12\">\r\n                    <article class=\"mr-md-4\">\r\n                        <h5 class=\"title\">Contact us</h5>\r\n                        <ul class=\"list-icon\">\r\n                            <li> <i class=\"icon fa fa-map-marker\"> </i>542 Fake Street, Sofia, Bulgaria </li>\r\n                            <li> <i class=\"icon fa fa-envelope\"> </i> admin@blazorshop.com </li>\r\n                            <li> <i class=\"icon fa fa-phone\"> </i> (800) 060-0730, (800) 060-0730</li>\r\n                            <li> <i class=\"icon fa fa-clock\"> </i> Mon-Sat 09:00am - 06:00pm </li>\r\n                        </ul>\r\n                    </article>\r\n                </aside>\r\n                <aside class=\"col-md col-6\">\r\n                    <h5 class=\"title\">Information</h5>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li> <a href=\"#\">About us</a></li>\r\n                        <li> <a href=\"#\">Career</a></li>\r\n                        <li> <a href=\"#\">Find a store</a></li>\r\n                        <li> <a href=\"#\">Rules and terms</a></li>\r\n                    </ul>\r\n                </aside>\r\n                <aside class=\"col-md col-6\">\r\n                    <h5 class=\"title\">My Account</h5>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li> <a href=\"/account/settings\"> Account Settings </a></li>\r\n                        <li> <a href=\"/orders\"> My Orders </a></li>\r\n                        <li> <a href=\"/wishlist\"> My Wishlist </a></li>\r\n                    </ul>\r\n                </aside>\r\n                <aside class=\"col-md-4 col-12\">\r\n                    <h5 class=\"title\">Newsletter</h5>\r\n                    <p> Subscribe to our email newsletter today to receive updates on special offers. </p>\r\n\r\n                    <form class=\"form-inline mb-3\">\r\n                        <div class=\"input-group\">\r\n                            <input type=\"text\" class=\"form-control\" placeholder=\"Email\">\r\n                            <span class=\"input-group-append\">\r\n                                <button class=\"btn ml-2 btn-warning\"> Subscribe </button>\r\n                            </span>\r\n                        </div>\r\n                    </form>\r\n\r\n                    <p class=\"text-black-50 mb-2\">Follow us on social media</p>\r\n                    <div>\r\n                        <a href=\"#\" class=\"btn btn-icon btn-light\"><i class=\"fab fa-facebook-f\"></i></a>\r\n                        <a href=\"#\" class=\"btn btn-icon btn-light\"><i class=\"fab fa-twitter\"></i></a>\r\n                        <a href=\"#\" class=\"btn btn-icon btn-light\"><i class=\"fab fa-instagram\"></i></a>\r\n                        <a href=\"#\" class=\"btn btn-icon btn-light\"><i class=\"fab fa-youtube\"></i></a>\r\n                    </div>\r\n\r\n                </aside>\r\n            </div>\r\n        </section>\r\n\r\n        <section class=\"footer-bottom border-top row\">\r\n            <div class=\"col-md-6\">\r\n                <p class=\"mb-0\">\r\n                    <a href>Terms and Conditions</a> |\r\n                    <a href>Privacy</a> |\r\n                    <a href>Cookies</a>\r\n                </p>\r\n            </div>\r\n            <div class=\"col-md-6 text-md-right\">\r\n                <a href=\"https://github.com/kalintsenkov/BlazorShop\" target=\"_blank\"><i class=\"fab fa-github\"></i> Open Source </a>\r\n            </div>\r\n        </section>\r\n    </div>\r\n</footer>");
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
