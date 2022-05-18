#pragma checksum "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\Pages\AdminPages\Pages\Pages-loaders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2c48ef3bf4880c3413e74e779d583208bf9da63"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Pages-loaders")]
    public partial class Pages_loaders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"be-content\"><div class=\"page-head\"><h2 class=\"page-head-title\">Page Loaders</h2>\r\n        <nav aria-label=\"breadcrumb\" role=\"navigation\"><ol class=\"breadcrumb page-head-nav\"><li class=\"breadcrumb-item\"><a href=\"#\">Home</a></li>\r\n                <li class=\"breadcrumb-item\"><a href=\"#\">Category</a></li>\r\n                <li class=\"breadcrumb-item active\">Page Loaders</li></ol></nav></div>\r\n    <div class=\"main-content container-fluid\"><div class=\"row\"><div class=\"col-12 col-lg-7 offset-lg-2\"><div class=\"card\"><div class=\"card-header\"><span class=\"title\">Using loaders classes</span></div>\r\n                    <div class=\"card-body\"><p>To use the effect you need a minimum structure consisting of the following elements:</p>\r\n                        <ol><li><p>The parent element with the <code>be-loading</code> class</p></li>\r\n                            <li><p>Directly inside <code>be-loading</code> you have to include the <code>be-spinner</code> element which contains the SVG.</p></li></ol>\r\n                        <p>Then to trigger the effect, add the <code>be-loading-active</code> class on the <code>be-loading</code> element.</p></div>\r\n                    <pre class=\"prettyprint\">&lt;div class=&quot;be-loading&quot;&gt;\r\n &lt;!-- Here goes your content --&gt;\r\n\r\n &lt;div class=&quot;be-spinner&quot;&gt;\r\n  &lt;svg width=&quot;40px&quot; height=&quot;40px&quot; viewBox=&quot;0 0 66 66&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;\r\n    &lt;circle fill=&quot;none&quot; stroke-width=&quot;4&quot; stroke-linecap=&quot;round&quot; cx=&quot;33&quot; cy=&quot;33&quot; r=&quot;30&quot; class=&quot;circle&quot;&gt;&lt;/circle&gt;\r\n  &lt;/svg&gt;\r\n &lt;/div&gt;\r\n&lt;/div&gt;\r\n</pre></div></div></div>\r\n        <div class=\"row\"><div class=\"col-lg-7 offset-lg-2\"><div class=\"card card-flat be-loading text-center\"><div class=\"card-header\">Load Example</div>\r\n                    <div class=\"card-body\"><p>Aliquam posuere volutpat turpis, ut euimod diam pellentesque at. Sed sit amet nulla a dui dignisim euismod. Morbi luctus elementum dictum. Donec convallis mattis elit id varius. Quisque facilisis sapien quis mauris, erat condimentum.</p>\r\n                        <button class=\"btn btn-primary btn-xl toggle-loading\">Trigger loader</button></div>\r\n                    <div class=\"be-spinner\"><svg width=\"40px\" height=\"40px\" viewbox=\"0 0 66 66\" xmlns=\"http://www.w3.org/2000/svg\"><circle class=\"circle\" fill=\"none\" stroke-width=\"4\" stroke-linecap=\"round\" cx=\"33\" cy=\"33\" r=\"30\"></circle></svg></div></div></div></div></div></div>\r\n");
            __builder.AddMarkupContent(1, "<nav class=\"be-right-sidebar\"><div class=\"sb-content\"><div class=\"tab-navigation\"><ul class=\"nav nav-tabs nav-justified\" role=\"tablist\"><li class=\"nav-item\" role=\"presentation\"><a class=\"nav-link active\" href=\"#tab1\" aria-controls=\"tab1\" role=\"tab\" data-toggle=\"tab\">Chat</a></li>\r\n                <li class=\"nav-item\" role=\"presentation\"><a class=\"nav-link\" href=\"#tab2\" aria-controls=\"tab2\" role=\"tab\" data-toggle=\"tab\">Todo</a></li>\r\n                <li class=\"nav-item\" role=\"presentation\"><a class=\"nav-link\" href=\"#tab3\" aria-controls=\"tab3\" role=\"tab\" data-toggle=\"tab\">Settings</a></li></ul></div>\r\n        <div class=\"tab-panel\"><div class=\"tab-content\"><div class=\"tab-pane tab-chat active\" id=\"tab1\" role=\"tabpanel\"><div class=\"chat-contacts\"><div class=\"chat-sections\"><div class=\"be-scroller-chat\"><div class=\"content\"><h2>Recent</h2>\r\n                                    <div class=\"contact-list contact-list-recent\"><div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar1.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data\"><span class=\"status away\"></span><span class=\"name\">Claire Sassu</span><span class=\"message\">Can you share the...</span></div></a></div>\r\n                                        <div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar2.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data\"><span class=\"status\"></span><span class=\"name\">Maggie jackson</span><span class=\"message\">I confirmed the info.</span></div></a></div>\r\n                                        <div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar3.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data\"><span class=\"status offline\"></span><span class=\"name\">Joel King\t\t</span><span class=\"message\">Ready for the meeti...</span></div></a></div></div>\r\n                                    <h2>Contacts</h2>\r\n                                    <div class=\"contact-list\"><div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar4.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data2\"><span class=\"status\"></span><span class=\"name\">Mike Bolthort</span></div></a></div>\r\n                                        <div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar5.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data2\"><span class=\"status\"></span><span class=\"name\">Maggie jackson</span></div></a></div>\r\n                                        <div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar6.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data2\"><span class=\"status offline\"></span><span class=\"name\">Jhon Voltemar</span></div></a></div></div></div></div></div>\r\n                        <div class=\"bottom-input\"><input type=\"text\" placeholder=\"Search...\" name=\"q\"><span class=\"mdi mdi-search\"></span></div></div>\r\n                    <div class=\"chat-window\"><div class=\"title\"><div class=\"user\"><img src=\"assets\\img\\avatar2.png\" alt=\"Avatar\">\r\n                                <h2>Maggie jackson</h2><span>Active 1h ago</span></div><span class=\"icon return mdi mdi-chevron-left\"></span></div>\r\n                        <div class=\"chat-messages\"><div class=\"be-scroller-messages\"><div class=\"content\"><ul><li class=\"friend\"><div class=\"msg\">Hello</div></li>\r\n                                        <li class=\"self\"><div class=\"msg\">Hi, how are you?</div></li>\r\n                                        <li class=\"friend\"><div class=\"msg\">Good, I\'ll need support with my pc</div></li>\r\n                                        <li class=\"self\"><div class=\"msg\">Sure, just tell me what is going on with your computer?</div></li>\r\n                                        <li class=\"friend\"><div class=\"msg\">I don\'t know it just turns off suddenly</div></li></ul></div></div></div>\r\n                        <div class=\"chat-input\"><div class=\"input-wrapper\"><span class=\"photo mdi mdi-camera\"></span>\r\n                                <input type=\"text\" placeholder=\"Message...\" name=\"q\" autocomplete=\"off\"><span class=\"send-msg mdi mdi-mail-send\"></span></div></div></div></div>\r\n                <div class=\"tab-pane tab-todo\" id=\"tab2\" role=\"tabpanel\"><div class=\"todo-container\"><div class=\"todo-wrapper\"><div class=\"be-scroller-todo\"><div class=\"todo-content\"><span class=\"category-title\">Today</span>\r\n                                    <ul class=\"todo-list\"><li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" checked id=\"tck1\">\r\n                                                <label class=\"custom-control-label\" for=\"tck1\">Initialize the project</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck2\">\r\n                                                <label class=\"custom-control-label\" for=\"tck2\">Create the main structure\t\t\t\t\t\t\t</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck3\">\r\n                                                <label class=\"custom-control-label\" for=\"tck3\">Updates changes to GitHub\t\t\t\t\t\t\t</label></div></li></ul><span class=\"category-title\">Tomorrow</span>\r\n                                    <ul class=\"todo-list\"><li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck4\">\r\n                                                <label class=\"custom-control-label\" for=\"tck4\">Initialize the project\t\t\t\t\t\t\t</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck5\">\r\n                                                <label class=\"custom-control-label\" for=\"tck5\">Create the main structure\t\t\t\t\t\t\t</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck6\">\r\n                                                <label class=\"custom-control-label\" for=\"tck6\">Updates changes to GitHub\t\t\t\t\t\t\t</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck7\">\r\n                                                <label class=\"custom-control-label\" for=\"tck7\" title=\"This task is too long to be displayed in a normal space!\">This task is too long to be displayed in a normal space!\t\t\t\t\t\t\t</label></div></li></ul></div></div></div>\r\n                        <div class=\"bottom-input\"><input type=\"text\" placeholder=\"Create new task...\" name=\"q\"><span class=\"mdi mdi-plus\"></span></div></div></div>\r\n                <div class=\"tab-pane tab-settings\" id=\"tab3\" role=\"tabpanel\"><div class=\"settings-wrapper\"><div class=\"be-scroller-settings\"><span class=\"category-title\">General</span>\r\n                            <ul class=\"settings-list\"><li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st1\" id=\"st1\"><span><label for=\"st1\"></label></span></div><span class=\"name\">Available</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st2\" id=\"st2\"><span><label for=\"st2\"></label></span></div><span class=\"name\">Enable notifications</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st3\" id=\"st3\"><span><label for=\"st3\"></label></span></div><span class=\"name\">Login with Facebook</span></li></ul><span class=\"category-title\">Notifications</span>\r\n                            <ul class=\"settings-list\"><li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" name=\"st4\" id=\"st4\"><span><label for=\"st4\"></label></span></div><span class=\"name\">Email notifications</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st5\" id=\"st5\"><span><label for=\"st5\"></label></span></div><span class=\"name\">Project updates</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st6\" id=\"st6\"><span><label for=\"st6\"></label></span></div><span class=\"name\">New comments</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" name=\"st7\" id=\"st7\"><span><label for=\"st7\"></label></span></div><span class=\"name\">Chat messages</span></li></ul><span class=\"category-title\">Workflow</span>\r\n                            <ul class=\"settings-list\"><li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" name=\"st8\" id=\"st8\"><span><label for=\"st8\"></label></span></div><span class=\"name\">Deploy on commit</span></li></ul></div></div></div></div></div></div></nav>\r\n\r\n<!-- Js Plugins\r\n");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
