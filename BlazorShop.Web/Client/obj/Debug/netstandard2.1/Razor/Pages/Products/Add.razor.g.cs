#pragma checksum "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c9155eb88967c3119bc1a86fd0c1b56e84ac1e4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Web.Client.Pages.Products
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
#nullable restore
#line 2 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
           [Authorize(Roles = Constants.AdministratorRole)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products/add")]
    public partial class Add : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
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
#line 7 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<section class=\"section-pagetop bg\">\r\n        <div class=\"container\">\r\n            <h2 class=\"title-page text-center\">Add Product</h2>\r\n        </div>\r\n    </section>\r\n");
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "section");
            __builder.AddAttribute(7, "class", "section-content padding-y bg");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card mx-auto");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "article");
            __builder.AddAttribute(19, "class", "card-body");
            __builder.AddMarkupContent(20, "\r\n\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(21);
            __builder.AddAttribute(22, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
                                         model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 22 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
                                                               SubmitAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(26);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(28);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n\r\n\r\n                            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "\r\n                                ");
                __builder2.AddMarkupContent(33, "<label>Name</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "type", "text");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
                                                        model.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Name = __value, model.Name))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n                            ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "\r\n                                ");
                __builder2.AddMarkupContent(45, "<label>Category</label>\r\n                                ");
                __Blazor.BlazorShop.Web.Client.Pages.Products.Add.TypeInference.CreateInputSelectNumber_0(__builder2, 46, 47, "form-control", 48, 
#nullable restore
#line 35 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
                                                                model.CategoryId

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.CategoryId = __value, model.CategoryId)), 50, () => model.CategoryId, 51, (__builder3) => {
                    __builder3.AddMarkupContent(52, "\r\n");
#nullable restore
#line 36 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
                                     foreach (var category in categories)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(53, "                                        ");
                    __builder3.OpenElement(54, "option");
                    __builder3.AddAttribute(55, "value", 
#nullable restore
#line 38 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
                                                        category.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(56, 
#nullable restore
#line 38 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
                                                                      category.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(57, "\r\n");
#nullable restore
#line 39 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
                                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(58, "                                ");
                }
                );
                __builder2.AddMarkupContent(59, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n                            ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-row");
                __builder2.AddMarkupContent(63, "\r\n                                ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col form-group");
                __builder2.AddMarkupContent(66, "\r\n                                    ");
                __builder2.AddMarkupContent(67, "<label>Price</label>\r\n                                    ");
                __Blazor.BlazorShop.Web.Client.Pages.Products.Add.TypeInference.CreateInputNumber_1(__builder2, 68, 69, "number", 70, "form-control", 71, 
#nullable restore
#line 46 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
                                                              model.Price

#line default
#line hidden
#nullable disable
                , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Price = __value, model.Price)), 73, () => model.Price);
                __builder2.AddMarkupContent(74, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                                ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "col form-group");
                __builder2.AddMarkupContent(78, "\r\n                                    ");
                __builder2.AddMarkupContent(79, "<label>Quantity</label>\r\n                                    ");
                __Blazor.BlazorShop.Web.Client.Pages.Products.Add.TypeInference.CreateInputNumber_2(__builder2, 80, 81, "number", 82, "form-control", 83, 
#nullable restore
#line 50 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
                                                              model.Quantity

#line default
#line hidden
#nullable disable
                , 84, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Quantity = __value, model.Quantity)), 85, () => model.Quantity);
                __builder2.AddMarkupContent(86, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n\r\n                            ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-group");
                __builder2.AddMarkupContent(91, "\r\n                                ");
                __builder2.AddMarkupContent(92, "<label>Image</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(93);
                __builder2.AddAttribute(94, "type", "url");
                __builder2.AddAttribute(95, "class", "form-control");
                __builder2.AddAttribute(96, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
                                                        model.ImageSource

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.ImageSource = __value, model.ImageSource))));
                __builder2.AddAttribute(98, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.ImageSource));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n\r\n                            ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "form-group");
                __builder2.AddMarkupContent(103, "\r\n                                ");
                __builder2.AddMarkupContent(104, "<label>Description</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(105);
                __builder2.AddAttribute(106, "rows", "2");
                __builder2.AddAttribute(107, "class", "form-control");
                __builder2.AddAttribute(108, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
                                                            model.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Description = __value, model.Description))));
                __builder2.AddAttribute(110, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(111, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n\r\n                            ");
                __builder2.AddMarkupContent(113, "<div class=\"form-group\">\r\n                                <button type=\"submit\" class=\"btn btn-block btn-primary\">Add</button>\r\n                            </div>\r\n\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(114, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n");
#nullable restore
#line 75 "C:\Users\tgthuan\Desktop\New folder2\BlazorShop\src\BlazorShop.Web\Client\Pages\Products\Add.razor"
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
namespace __Blazor.BlazorShop.Web.Client.Pages.Products.Add
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelectNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::BlazorShop.Web.Client.Infrastructure.InputSelectNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
