#pragma checksum "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8a7959296ef7fcf89d1fb9f4b2ff89a16791585"
// <auto-generated/>
#pragma warning disable 1591
namespace VegetableShop.Pages.PagesCRUDUser
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\_Imports.razor"
using VegetableShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\_Imports.razor"
using VegetableShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
using VegetableShop.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
using VegetableShop.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Users")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "nav-link");
            __builder.AddAttribute(2, "href", "AddUsers");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<span class=\"oi oi-plus\" aria-hidden=\"true\">Add New</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h1>User Info</h1>");
#nullable restore
#line 12 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
 if (UserObj is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading... !</em></p>");
#nullable restore
#line 15 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>id</th>\r\n                <th>Full Name</th>\r\n                <th>User Name</th>\r\n                <th>Address</th>\r\n                <th>Created</th>\r\n                <th>Action</th></tr></thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 30 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
             foreach (var user in UserObj)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
#nullable restore
#line 33 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
__builder.AddContent(14, user.id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 34 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
__builder.AddContent(17, user.full_name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 35 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
__builder.AddContent(20, user.user_name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 36 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
__builder.AddContent(23, user.address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
#nullable restore
#line 37 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
__builder.AddContent(26, user.created_at);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "nav-link");
            __builder.AddAttribute(31, "href", "EditEmployee/" + (
#nullable restore
#line 39 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
                                                                user.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "<span class=\"oi oi-pencil\" aria-hidden=\"true\">Edit</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "class", "nav-link");
            __builder.AddAttribute(36, "href", "Delete/" + (
#nullable restore
#line 42 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
                                                          user.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "<span class=\"oi oi-trash\" aria-hidden=\"true\">Delete</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\tgthuan\Desktop\Vegetable-Shop\VegetableShop\Pages\PagesCRUDUser\Users.razor"
       
    List<users> UserObj;
    protected override async Task OnInitializedAsync()
    {
        UserObj = await Task.Run(() => userService.GetAllUsersAsync());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userService { get; set; }
    }
}
#pragma warning restore 1591
