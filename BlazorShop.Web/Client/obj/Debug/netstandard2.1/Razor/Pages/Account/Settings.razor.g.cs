#pragma checksum "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Settings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48caa2e40fad20a3f8c21030c1b1d3b59f41d694"
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
#line 2 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Settings.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/account/settings")]
    public partial class Settings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Settings.razor"
 if (model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<BlazorShop.Web.Client.Shared.Common.LoadingScreen>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Settings.razor"
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
            __builder.AddMarkupContent(24, "<h4 class=\"card-title mb-4\">Account Settings</h4>\r\n                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(25);
            __builder.AddAttribute(26, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 23 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Settings.razor"
                                             model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 23 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Settings.razor"
                                                                   SubmitAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(29, "\r\n\r\n                                ");
                __builder2.OpenComponent<BlazorShop.Web.Client.Shared.Common.ErrorsList>(30);
                __builder2.AddAttribute(31, "ShowErrors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Settings.razor"
                                                        ShowErrors

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "Errors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.String>>(
#nullable restore
#line 25 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Settings.razor"
                                                                            Errors

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(34);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(36);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n\r\n                                ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group row");
                __builder2.AddMarkupContent(40, "\r\n                                    ");
                __builder2.AddMarkupContent(41, "<label class=\"col-sm-2 col-form-label\">Email</label>\r\n                                    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-sm-6");
                __builder2.AddMarkupContent(44, "\r\n                                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "type", "email");
                __builder2.AddAttribute(47, "class", "form-control-plaintext");
                __builder2.AddAttribute(48, "readonly", true);
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Settings.razor"
                                                                email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => email = __value, email))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group row");
                __builder2.AddMarkupContent(57, "\r\n                                    ");
                __builder2.AddMarkupContent(58, "<label class=\"col-sm-2 col-form-label\">First name</label>\r\n                                    ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-sm-6");
                __builder2.AddMarkupContent(61, "\r\n                                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(62);
                __builder2.AddAttribute(63, "type", "text");
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Settings.razor"
                                                                model.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.FirstName = __value, model.FirstName))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                                ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group row");
                __builder2.AddMarkupContent(73, "\r\n                                    ");
                __builder2.AddMarkupContent(74, "<label class=\"col-sm-2 col-form-label\">Last name</label>\r\n                                    ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-sm-6");
                __builder2.AddMarkupContent(77, "\r\n                                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(78);
                __builder2.AddAttribute(79, "type", "text");
                __builder2.AddAttribute(80, "class", "form-control");
                __builder2.AddAttribute(81, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Settings.razor"
                                                                model.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.LastName = __value, model.LastName))));
                __builder2.AddAttribute(83, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n\r\n                                ");
                __builder2.AddMarkupContent(87, "<button class=\"btn btn-primary\"> Save changes </button>\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(88, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 59 "C:\Users\tgthuan\Desktop\EC-BlazorShop\BlazorShop.Web\Client\Pages\Account\Settings.razor"
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
