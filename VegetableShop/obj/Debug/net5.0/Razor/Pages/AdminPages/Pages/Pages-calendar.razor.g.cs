#pragma checksum "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\Pages\AdminPages\Pages\Pages-calendar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56e4c71e924f24250545deb662bf656b5122e7ee"
// <auto-generated/>
#pragma warning disable 1591
namespace VegetableShop.Pages.AdminPages.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Pages-calendar")]
    public partial class Pages_calendar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""be-content""><div class=""page-head""><h2 class=""page-head-title"">Calendar</h2>
        <nav aria-label=""breadcrumb"" role=""navigation""><ol class=""breadcrumb page-head-nav""><li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Pages</a></li>
                <li class=""breadcrumb-item active"">Calendar</li></ol></nav></div>
    <div class=""main-content container-fluid""><div class=""row full-calendar""><div class=""col-lg-9""><div class=""card card-fullcalendar""><div class=""card-body""><div id=""calendar""></div></div></div></div>
            <div class=""col-lg-3""><div class=""card fullcalendar-external-events""><div class=""card-header card-header-divider"">Draggable Events</div>
                    <div class=""card-body""><div id=""external-events""><div class=""fc-event"">My Event 1</div>
                            <div class=""fc-event"">My Event 2</div>
                            <div class=""fc-event"">My Event 3</div>
                            <div class=""fc-event"">My Event 4</div>
                            <div class=""fc-event"">My Event 5</div>
                            <p><input id=""drop-remove"" type=""checkbox"">
                                <label for=""drop-remove"">remove after drop</label></p></div></div></div></div></div></div></div>
");
            __builder.AddMarkupContent(1, "<nav class=\"be-right-sidebar\"><div class=\"sb-content\"><div class=\"tab-navigation\"><ul class=\"nav nav-tabs nav-justified\" role=\"tablist\"><li class=\"nav-item\" role=\"presentation\"><a class=\"nav-link active\" href=\"#tab1\" aria-controls=\"tab1\" role=\"tab\" data-toggle=\"tab\">Chat</a></li>\r\n                <li class=\"nav-item\" role=\"presentation\"><a class=\"nav-link\" href=\"#tab2\" aria-controls=\"tab2\" role=\"tab\" data-toggle=\"tab\">Todo</a></li>\r\n                <li class=\"nav-item\" role=\"presentation\"><a class=\"nav-link\" href=\"#tab3\" aria-controls=\"tab3\" role=\"tab\" data-toggle=\"tab\">Settings</a></li></ul></div>\r\n        <div class=\"tab-panel\"><div class=\"tab-content\"><div class=\"tab-pane tab-chat active\" id=\"tab1\" role=\"tabpanel\"><div class=\"chat-contacts\"><div class=\"chat-sections\"><div class=\"be-scroller-chat\"><div class=\"content\"><h2>Recent</h2>\r\n                                    <div class=\"contact-list contact-list-recent\"><div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar1.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data\"><span class=\"status away\"></span><span class=\"name\">Claire Sassu</span><span class=\"message\">Can you share the...</span></div></a></div>\r\n                                        <div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar2.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data\"><span class=\"status\"></span><span class=\"name\">Maggie jackson</span><span class=\"message\">I confirmed the info.</span></div></a></div>\r\n                                        <div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar3.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data\"><span class=\"status offline\"></span><span class=\"name\">Joel King\t\t</span><span class=\"message\">Ready for the meeti...</span></div></a></div></div>\r\n                                    <h2>Contacts</h2>\r\n                                    <div class=\"contact-list\"><div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar4.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data2\"><span class=\"status\"></span><span class=\"name\">Mike Bolthort</span></div></a></div>\r\n                                        <div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar5.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data2\"><span class=\"status\"></span><span class=\"name\">Maggie jackson</span></div></a></div>\r\n                                        <div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar6.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data2\"><span class=\"status offline\"></span><span class=\"name\">Jhon Voltemar</span></div></a></div></div></div></div></div>\r\n                        <div class=\"bottom-input\"><input type=\"text\" placeholder=\"Search...\" name=\"q\"><span class=\"mdi mdi-search\"></span></div></div>\r\n                    <div class=\"chat-window\"><div class=\"title\"><div class=\"user\"><img src=\"assets\\img\\avatar2.png\" alt=\"Avatar\">\r\n                                <h2>Maggie jackson</h2><span>Active 1h ago</span></div><span class=\"icon return mdi mdi-chevron-left\"></span></div>\r\n                        <div class=\"chat-messages\"><div class=\"be-scroller-messages\"><div class=\"content\"><ul><li class=\"friend\"><div class=\"msg\">Hello</div></li>\r\n                                        <li class=\"self\"><div class=\"msg\">Hi, how are you?</div></li>\r\n                                        <li class=\"friend\"><div class=\"msg\">Good, I\'ll need support with my pc</div></li>\r\n                                        <li class=\"self\"><div class=\"msg\">Sure, just tell me what is going on with your computer?</div></li>\r\n                                        <li class=\"friend\"><div class=\"msg\">I don\'t know it just turns off suddenly</div></li></ul></div></div></div>\r\n                        <div class=\"chat-input\"><div class=\"input-wrapper\"><span class=\"photo mdi mdi-camera\"></span>\r\n                                <input type=\"text\" placeholder=\"Message...\" name=\"q\" autocomplete=\"off\"><span class=\"send-msg mdi mdi-mail-send\"></span></div></div></div></div>\r\n                <div class=\"tab-pane tab-todo\" id=\"tab2\" role=\"tabpanel\"><div class=\"todo-container\"><div class=\"todo-wrapper\"><div class=\"be-scroller-todo\"><div class=\"todo-content\"><span class=\"category-title\">Today</span>\r\n                                    <ul class=\"todo-list\"><li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" checked id=\"tck1\">\r\n                                                <label class=\"custom-control-label\" for=\"tck1\">Initialize the project</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck2\">\r\n                                                <label class=\"custom-control-label\" for=\"tck2\">Create the main structure\t\t\t\t\t\t\t</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck3\">\r\n                                                <label class=\"custom-control-label\" for=\"tck3\">Updates changes to GitHub\t\t\t\t\t\t\t</label></div></li></ul><span class=\"category-title\">Tomorrow</span>\r\n                                    <ul class=\"todo-list\"><li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck4\">\r\n                                                <label class=\"custom-control-label\" for=\"tck4\">Initialize the project\t\t\t\t\t\t\t</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck5\">\r\n                                                <label class=\"custom-control-label\" for=\"tck5\">Create the main structure\t\t\t\t\t\t\t</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck6\">\r\n                                                <label class=\"custom-control-label\" for=\"tck6\">Updates changes to GitHub\t\t\t\t\t\t\t</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck7\">\r\n                                                <label class=\"custom-control-label\" for=\"tck7\" title=\"This task is too long to be displayed in a normal space!\">This task is too long to be displayed in a normal space!\t\t\t\t\t\t\t</label></div></li></ul></div></div></div>\r\n                        <div class=\"bottom-input\"><input type=\"text\" placeholder=\"Create new task...\" name=\"q\"><span class=\"mdi mdi-plus\"></span></div></div></div>\r\n                <div class=\"tab-pane tab-settings\" id=\"tab3\" role=\"tabpanel\"><div class=\"settings-wrapper\"><div class=\"be-scroller-settings\"><span class=\"category-title\">General</span>\r\n                            <ul class=\"settings-list\"><li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st1\" id=\"st1\"><span><label for=\"st1\"></label></span></div><span class=\"name\">Available</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st2\" id=\"st2\"><span><label for=\"st2\"></label></span></div><span class=\"name\">Enable notifications</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st3\" id=\"st3\"><span><label for=\"st3\"></label></span></div><span class=\"name\">Login with Facebook</span></li></ul><span class=\"category-title\">Notifications</span>\r\n                            <ul class=\"settings-list\"><li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" name=\"st4\" id=\"st4\"><span><label for=\"st4\"></label></span></div><span class=\"name\">Email notifications</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st5\" id=\"st5\"><span><label for=\"st5\"></label></span></div><span class=\"name\">Project updates</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st6\" id=\"st6\"><span><label for=\"st6\"></label></span></div><span class=\"name\">New comments</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" name=\"st7\" id=\"st7\"><span><label for=\"st7\"></label></span></div><span class=\"name\">Chat messages</span></li></ul><span class=\"category-title\">Workflow</span>\r\n                            <ul class=\"settings-list\"><li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" name=\"st8\" id=\"st8\"><span><label for=\"st8\"></label></span></div><span class=\"name\">Deploy on commit</span></li></ul></div></div></div></div></div></div></nav>\r\n\r\n<!-- Js Plugins\r\n");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
