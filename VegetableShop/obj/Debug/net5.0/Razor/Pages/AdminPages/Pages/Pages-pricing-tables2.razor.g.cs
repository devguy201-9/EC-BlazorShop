#pragma checksum "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\Pages\AdminPages\Pages\Pages-pricing-tables2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3db43659021e008730c8443711da733f77082f75"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Pages-pricing-tables2")]
    public partial class Pages_pricing_tables2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"be-content\"><div class=\"main-content container-fluid\"><h1 class=\"display-heading text-center\">Plans & Pricing</h1>\r\n        <p class=\"display-description text-center\">Morbi purus nisi, porttitor a sodales at, consectetur sit amet elit. Vivamus justo risus, ultricies et urna ut,<br> auctor efficitur nisi. Aliquam erat volutpat. Morbi lobortis sem justo</p>\r\n        <div class=\"row pricing-tables\"><div class=\"col-lg-3\"><div class=\"pricing-table pricing-table-color pricing-table-primary\"><div class=\"pricing-table-image\"><svg version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" width=\"85\" height=\"70\" viewbox=\"0 35 470 400\" xmlns:xlink=\"http://-www.w3.org/1999/xlink\" enable-background=\"new 0 35 470 400\"><g><path d=\"m215.419,235c0-11.028-8.972-20-20-20s-20,8.972-20,20 8.972,20 20,20 20-8.972 20-20zm-25,0c0-2.757 2.243-5 5-5s5,2.243 5,5-2.243,5-5,5-5-2.243-5-5z\"></path>\r\n                                <path d=\"M312.415,118.004c-31.227-31.226-72.776-48.423-116.996-48.423s-85.77,17.197-116.995,48.423   C47.197,149.231,30,190.781,30,235c0,44.22,17.197,85.77,48.424,116.996c31.226,31.227,72.775,48.424,116.995,48.424   s85.77-17.197,116.996-48.423c31.227-31.227,48.424-72.777,48.424-116.996S343.642,149.231,312.415,118.004z M195.419,385.419   C112.478,385.419,45,317.941,45,235S112.478,84.581,195.419,84.581S345.839,152.058,345.839,235S278.36,385.419,195.419,385.419z\"></path>\r\n                                <path d=\"m321.895,227.5c-4.143,0-7.5,3.358-7.5,7.5 0,65.604-53.372,118.976-118.976,118.976-4.143,0-7.5,3.358-7.5,7.5s3.357,7.5 7.5,7.5c73.874,0 133.976-60.102 133.976-133.976 0-4.142-3.358-7.5-7.5-7.5z\"></path>\r\n                                <path d=\"m195.419,147.468c4.143,0 7.5-3.358 7.5-7.5s-3.357-7.5-7.5-7.5c-56.536,0-102.532,45.996-102.532,102.532 0,4.142 3.357,7.5 7.5,7.5s7.5-3.358 7.5-7.5c-1.42109e-14-48.266 39.266-87.532 87.532-87.532z\"></path>\r\n                                <path d=\"m195.419,322.532c-4.143,0-7.5,3.358-7.5,7.5s3.357,7.5 7.5,7.5c56.536,0 102.532-45.996 102.532-102.533 0-4.142-3.357-7.5-7.5-7.5s-7.5,3.358-7.5,7.5c0,48.266-39.266,87.533-87.532,87.533z\"></path>\r\n                                <path d=\"m266.508,235c0-39.198-31.891-71.088-71.089-71.088s-71.089,31.89-71.089,71.088c0,39.199 31.891,71.089 71.089,71.089s71.089-31.891 71.089-71.089zm-127.178,0c0-30.927 25.161-56.088 56.089-56.088s56.089,25.161 56.089,56.088c0,30.928-25.161,56.089-56.089,56.089s-56.089-25.162-56.089-56.089z\"></path>\r\n                                <path d=\"m432.5,69.581c-4.143,0-7.5,3.358-7.5,7.5v42.5h-35v-42.5c0-4.142-3.357-7.5-7.5-7.5s-7.5,3.358-7.5,7.5v50c0,4.142 3.357,7.5 7.5,7.5h17.5v129.298c0,4.563-1.476,12.29-3.157,16.533l-18.203,45.933-6.971-2.763c-1.85-0.731-3.914-0.701-5.74,0.088-1.825,0.79-3.263,2.272-3.996,4.121l-16.579,41.834c-2.214,5.587-2.12,11.703 0.265,17.219 2.385,5.516 6.775,9.773 12.363,11.988 2.656,1.052 5.443,1.586 8.284,1.586 9.289,0 17.501-5.58 20.923-14.214l16.579-41.834c1.525-3.851-0.358-8.209-4.21-9.736l-6.972-2.763 18.203-45.933c2.361-5.96 4.212-15.65 4.212-22.06v-129.297h17.5c4.143,0 7.5-3.358 7.5-7.5v-50c-0.001-4.142-3.358-7.5-7.501-7.5zm-59.258,311.098c-1.141,2.88-3.879,4.74-6.976,4.74-0.941,0-1.87-0.179-2.76-0.531-1.862-0.738-3.326-2.158-4.121-3.996-0.795-1.839-0.826-3.877-0.088-5.74l13.815-34.862 6.969,2.762c0.005,0.002 6.976,2.764 6.976,2.764l-13.815,34.863z\"></path>\r\n                                <path d=\"m432.5,39.581h-395c-20.678,0-37.5,16.822-37.5,37.5v315.838c0,20.678 16.822,37.5 37.5,37.5h395c20.678,0 37.5-16.822 37.5-37.5v-315.838c0-20.678-16.822-37.5-37.5-37.5zm22.5,353.338c0,12.407-10.094,22.5-22.5,22.5h-395c-12.406,0-22.5-10.093-22.5-22.5v-315.838c0-12.407 10.094-22.5 22.5-22.5h395c12.406,0 22.5,10.093 22.5,22.5v315.838z\"></path>\r\n                                <path d=\"m117.207,143.07c1.624,0 3.26-0.525 4.635-1.608 21.135-16.642 46.577-25.438 73.577-25.438 4.143,0 7.5-3.358 7.5-7.5s-3.357-7.5-7.5-7.5c-30.4,0-59.052,9.908-82.856,28.653-3.255,2.563-3.815,7.278-1.253,10.532 1.48,1.88 3.677,2.861 5.897,2.861z\"></path>\r\n                                <path d=\"m100.628,150.89c-3.254-2.562-7.971-2.001-10.532,1.253-18.744,23.806-28.653,52.457-28.653,82.857 0,4.142 3.357,7.5 7.5,7.5s7.5-3.358 7.5-7.5c0-27 8.796-52.442 25.438-73.577 2.562-3.255 2.002-7.97-1.253-10.533z\"></path></g></svg></div>\r\n                    <div class=\"pricing-table-title\">Basic</div>\r\n                    <div class=\"card-divider card-divider-xl\"></div>\r\n                    <div class=\"pricing-table-price\"><span class=\"currency\">$</span><span class=\"value\">5</span><span class=\"frecuency\">/mo</span></div>\r\n                    <ul class=\"pricing-table-features\"><li>Lorem ipsum dolor sit amet</li>\r\n                        <li>Pellentesque sit amet odio elit</li>\r\n                        <li>Integer felis odio</li></ul>\r\n                    <button class=\"btn btn-primary btn-outline\" type=\"button\">Get Started</button></div></div>\r\n            <div class=\"col-lg-3\"><div class=\"pricing-table pricing-table-color pricing-table-warning\"><div class=\"pricing-table-image\"><svg version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" width=\"85\" height=\"70\" viewbox=\"0 35 430 360\" xmlns:xlink=\"http://-www.w3.org/1999/xlink\" enable-background=\"new 0 35 430 360\"><g><path d=\"m371.967,36.248h-322.454c-27.302,0-49.513,22.211-49.513,49.513v247.571c0,15.816 12.244,28.817 27.749,30.046v14.353c0,4.142 3.357,7.5 7.5,7.5h47.997c4.143,0 7.5-3.358 7.5-7.5v-14.249h239.987v14.249c0,4.142 3.357,7.5 7.5,7.5h47.998c4.143,0 7.5-3.358 7.5-7.5v-14.353c15.505-1.229 27.748-14.23 27.748-30.046v-247.571c0-27.302-22.21-49.513-49.512-49.513zm-296.221,333.983h-32.997v-6.749h32.997v6.749zm302.985,0h-32.998v-6.749h32.998v6.749zm27.748-36.899c0,8.354-6.796,15.15-15.149,15.15h-361.18c-8.354,0-15.15-6.796-15.15-15.15v-247.571c0-19.03 15.482-34.513 34.513-34.513h322.454c19.03,0 34.513,15.482 34.513,34.513v247.571z\"></path>\r\n                                <path d=\"m343.395,71.376h-265.309c-19.075,0-34.594,15.519-34.594,34.594v146.542c0,19.075 15.519,34.594 34.594,34.594h32.272c13.626,0 26.023-8.038 31.583-20.478l6.725-15.048c3.15-7.046 10.172-11.599 17.89-11.599h88.369c7.718,0 14.739,4.553 17.888,11.599l6.727,15.048c5.561,12.439 17.958,20.477 31.583,20.477h32.272c19.075,0 34.594-15.519 34.594-34.594v-146.541c-0.001-19.075-15.519-34.594-34.594-34.594zm-284.903,100.365v-18.455h304.496v18.455h-304.496zm304.496,15v18.455h-304.496v-18.455h304.496zm-304.496-48.455v-18.455h304.496v18.455h-304.496zm19.594-51.91h265.309c10.419,0 18.941,8.182 19.536,18.455h-304.381c0.595-10.273 9.117-18.455 19.536-18.455zm32.272,185.73h-32.272c-10.42,0-18.942-8.183-19.536-18.457h72.762l-3.065,6.859c-3.149,7.046-10.171,11.598-17.889,11.598zm144.567-47.124h-88.369c-10.939,0-21.076,5.188-27.53,13.667h-80.534v-18.453h304.496v18.453h-80.533c-6.453-8.479-16.592-13.667-27.53-13.667zm88.47,47.124h-32.272c-7.718,0-14.739-4.553-17.889-11.599l-3.065-6.858h72.763c-0.595,10.275-9.117,18.457-19.537,18.457z\"></path>\r\n                                <path d=\"m90.595,293.624c-12.437,0-22.555,10.118-22.555,22.555 0,12.437 10.118,22.555 22.555,22.555s22.555-10.118 22.555-22.555c-0.001-12.437-10.119-22.555-22.555-22.555zm0,30.11c-4.166,0-7.555-3.389-7.555-7.555 0-4.166 3.389-7.555 7.555-7.555s7.555,3.389 7.555,7.555c-0.001,4.166-3.389,7.555-7.555,7.555z\"></path>\r\n                                <path d=\"m330.886,293.624c-12.438,0-22.556,10.118-22.556,22.555 0,12.437 10.118,22.555 22.556,22.555 12.437,0 22.555-10.118 22.555-22.555-0.001-12.437-10.119-22.555-22.555-22.555zm0,30.11c-4.166,0-7.556-3.389-7.556-7.555 0-4.166 3.39-7.555 7.556-7.555s7.555,3.389 7.555,7.555c-0.001,4.166-3.389,7.555-7.555,7.555z\"></path>\r\n                                <path d=\"m259.995,295.985h-98.51c-4.143,0-7.5,3.358-7.5,7.5s3.357,7.5 7.5,7.5h98.51c4.143,0 7.5-3.358 7.5-7.5s-3.357-7.5-7.5-7.5z\"></path>\r\n                                <path d=\"m242.084,289.236c4.143,0 7.5-3.358 7.5-7.5s-3.357-7.5-7.5-7.5h-62.688c-4.143,0-7.5,3.358-7.5,7.5s3.357,7.5 7.5,7.5h62.688z\"></path>\r\n                                <path d=\"m242.084,317.734h-62.688c-4.143,0-7.5,3.358-7.5,7.5s3.357,7.5 7.5,7.5h62.688c4.143,0 7.5-3.358 7.5-7.5s-3.357-7.5-7.5-7.5z\"></path></g></svg></div>\r\n                    <div class=\"pricing-table-title\">Premium</div>\r\n                    <div class=\"card-divider card-divider-xl\"></div>\r\n                    <div class=\"pricing-table-price\"><span class=\"currency\">$</span><span class=\"value\">12</span><span class=\"frecuency\">/mo</span></div>\r\n                    <ul class=\"pricing-table-features\"><li>Lorem ipsum dolor sit amet</li>\r\n                        <li>Pellentesque sit amet odio elit</li>\r\n                        <li>Integer felis odio</li></ul>\r\n                    <button class=\"btn btn-warning btn-outline\" type=\"button\">Get Started</button></div></div>\r\n            <div class=\"col-lg-3\"><div class=\"pricing-table pricing-table-color pricing-table-success\"><div class=\"pricing-table-image\"><svg version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" width=\"120\" height=\"70\" viewbox=\"0 90 460 280\" xmlns:xlink=\"http://-www.w3.org/1999/xlink\" enable-background=\"new 0 90 460 280\"><g><path d=\"m450.5,132h-116.93v-29.5c0-4.142-3.358-7.5-7.5-7.5h-194.14c-4.142,0-7.5,3.358-7.5,7.5v29.5h-116.93c-4.142,0-7.5,3.358-7.5,7.5v216c0,4.142 3.358,7.5 7.5,7.5h443c4.142,0 7.5-3.358 7.5-7.5v-216c0-4.142-3.358-7.5-7.5-7.5zm-311.07-22h179.14v22h-179.14v-22zm303.57,238h-428v-201h428v201z\"></path>\r\n                                <path d=\"m131.93,154.5h-104.43c-2.761,0-5,2.239-5,5v176c0,2.761 2.239,5 5,5h104.43c2.761,0 5-2.239 5-5v-176c0-2.761-2.239-5-5-5zm-5,176h-94.43v-166h94.43v166z\"></path>\r\n                                <path d=\"m321.07,159.5v176c0,2.761 2.239,5 5,5h104.43c2.761,0 5-2.239 5-5v-176c0-2.761-2.239-5-5-5h-104.43c-2.761,0-5,2.239-5,5zm10,5h94.43v166h-94.43v-166z\"></path>\r\n                                <path d=\"m79.715,326.5c24.813,0 45-20.187 45-45s-20.187-45-45-45-45,20.187-45,45 20.187,45 45,45zm0-80c19.299,0 35,15.701 35,35s-15.701,35-35,35-35-15.701-35-35 15.701-35 35-35z\"></path>\r\n                                <path d=\"m79.715,297.539c8.844,0 16.039-7.195 16.039-16.039s-7.195-16.039-16.039-16.039-16.039,7.195-16.039,16.039 7.195,16.039 16.039,16.039zm0-22.078c3.33,0 6.039,2.709 6.039,6.039s-2.709,6.039-6.039,6.039c-3.33,0-6.039-2.709-6.039-6.039s2.709-6.039 6.039-6.039z\"></path>\r\n                                <path d=\"m66.215,231.997c17.369,0 31.5-14.131 31.5-31.5s-14.131-31.5-31.5-31.5-31.5,14.131-31.5,31.5 14.131,31.5 31.5,31.5zm0-53c11.855,0 21.5,9.645 21.5,21.5s-9.645,21.5-21.5,21.5-21.5-9.645-21.5-21.5 9.645-21.5 21.5-21.5z\"></path>\r\n                                <path d=\"m66.215,215.454c8.248,0 14.957-6.709 14.957-14.957s-6.709-14.957-14.957-14.957-14.958,6.709-14.958,14.957 6.71,14.957 14.958,14.957zm0-19.914c2.733,0 4.957,2.224 4.957,4.957s-2.224,4.957-4.957,4.957-4.958-2.224-4.958-4.957 2.224-4.957 4.958-4.957z\"></path>\r\n                                <path d=\"m378.285,236.5c-24.813,0-45,20.187-45,45s20.187,45 45,45 45-20.187 45-45-20.187-45-45-45zm0,80c-19.299,0-35-15.701-35-35s15.701-35 35-35 35,15.701 35,35-15.702,35-35,35z\"></path>\r\n                                <path d=\"m378.285,265.461c-8.844,0-16.039,7.195-16.039,16.039s7.195,16.039 16.039,16.039 16.039-7.195 16.039-16.039-7.196-16.039-16.039-16.039zm0,22.078c-3.33,0-6.039-2.709-6.039-6.039s2.709-6.039 6.039-6.039c3.33,0 6.039,2.709 6.039,6.039s-2.709,6.039-6.039,6.039z\"></path>\r\n                                <path d=\"m391.785,168.997c-17.369,0-31.5,14.131-31.5,31.5s14.131,31.5 31.5,31.5 31.5-14.131 31.5-31.5-14.131-31.5-31.5-31.5zm0,53c-11.855,0-21.5-9.645-21.5-21.5s9.645-21.5 21.5-21.5 21.5,9.645 21.5,21.5-9.645,21.5-21.5,21.5z\"></path>\r\n                                <path d=\"m391.785,185.54c-8.248,0-14.957,6.709-14.957,14.957s6.709,14.957 14.957,14.957 14.958-6.709 14.958-14.957-6.711-14.957-14.958-14.957zm0,19.914c-2.733,0-4.957-2.224-4.957-4.957s2.224-4.957 4.957-4.957 4.958,2.224 4.958,4.957-2.225,4.957-4.958,4.957z\"></path>\r\n                                <path d=\"m220.602,264.5h-71.602c-2.761,0-5,2.239-5,5v66c0,2.761 2.239,5 5,5h71.602c2.761,0 5-2.239 5-5v-66c0-2.761-2.239-5-5-5zm-5,10v36h-61.602v-36h61.602zm-35.801,46v10h-7.5v-10h7.5zm10,0h7.5v10h-7.5v-10zm-35.801,0h8.301v10h-8.301v-10zm53.301,10v-10h8.301v10h-8.301z\"></path>\r\n                                <path d=\"m309,264.5h-71.603c-2.761,0-5,2.239-5,5v66c0,2.761 2.239,5 5,5h71.603c2.761,0 5-2.239 5-5v-66c0-2.761-2.239-5-5-5zm-5,10v36h-61.603v-36h61.603zm-35.8,46v10h-7.5v-10h7.5zm10,0h7.5v10h-7.5v-10zm-35.803,0h8.302v10h-8.302v-10zm53.303,10v-10h8.3v10h-8.3z\"></path>\r\n                                <path d=\"m171.803,298.499c1.32,0 2.6-0.53 3.53-1.46 0.93-0.93 1.47-2.22 1.47-3.54 0-1.32-0.54-2.6-1.47-3.53-0.93-0.93-2.21-1.47-3.53-1.47s-2.61,0.54-3.54,1.47c-0.93,0.92-1.46,2.21-1.46,3.53 0,1.32 0.53,2.61 1.46,3.54 0.93,0.93 2.22,1.46 3.54,1.46z\"></path>\r\n                                <path d=\"m197.803,298.499c1.31,0 2.6-0.53 3.53-1.46 0.93-0.93 1.47-2.22 1.47-3.54 0-1.32-0.54-2.61-1.47-3.54-0.93-0.93-2.22-1.46-3.53-1.46-1.32,0-2.61,0.53-3.54,1.46-0.93,0.93-1.46,2.22-1.46,3.54 0,1.32 0.53,2.61 1.46,3.54 0.93,0.93 2.22,1.46 3.54,1.46z\"></path>\r\n                                <path d=\"m260.203,298.499c1.31,0 2.6-0.53 3.53-1.46 0.93-0.93 1.47-2.22 1.47-3.54 0-1.32-0.54-2.6-1.47-3.53-0.93-0.94-2.22-1.47-3.53-1.47-1.32,0-2.61,0.53-3.54,1.47-0.93,0.93-1.46,2.21-1.46,3.53 0,1.32 0.53,2.61 1.46,3.54 0.93,0.93 2.22,1.46 3.54,1.46z\"></path>\r\n                                <path d=\"m286.203,298.499c1.31,0 2.6-0.53 3.53-1.46 0.93-0.94 1.47-2.22 1.47-3.54 0-1.32-0.54-2.6-1.47-3.53-0.93-0.93-2.22-1.47-3.53-1.47-1.32,0-2.61,0.54-3.54,1.47-0.93,0.93-1.46,2.21-1.46,3.53 0,1.32 0.53,2.6 1.46,3.54 0.93,0.93 2.22,1.46 3.54,1.46z\"></path>\r\n                                <path d=\"m309,154.5h-160c-2.761,0-5,2.239-5,5v15c0,2.761 2.239,5 5,5h160c2.761,0 5-2.239 5-5v-15c0-2.761-2.239-5-5-5zm-5,15h-150v-5h150v5z\"></path>\r\n                                <path d=\"m276.754,185.5h-95.508c-2.761,0-5,2.239-5,5v15c0,2.761 2.239,5 5,5h95.508c2.761,0 5-2.239 5-5v-15c0-2.761-2.239-5-5-5zm-5,15h-85.508v-5h85.508v5z\"></path>\r\n                                <path d=\"m164.267,236.5c0,9.098 7.402,16.5 16.5,16.5s16.5-7.402 16.5-16.5-7.402-16.5-16.5-16.5-16.5,7.402-16.5,16.5zm16.5-6.5c3.584,0 6.5,2.916 6.5,6.5s-2.916,6.5-6.5,6.5-6.5-2.916-6.5-6.5 2.916-6.5 6.5-6.5z\"></path>\r\n                                <path d=\"m245.5,236.5c0-9.098-7.402-16.5-16.5-16.5s-16.5,7.402-16.5,16.5 7.402,16.5 16.5,16.5 16.5-7.402 16.5-16.5zm-16.5,6.5c-3.584,0-6.5-2.916-6.5-6.5s2.916-6.5 6.5-6.5 6.5,2.916 6.5,6.5-2.916,6.5-6.5,6.5z\"></path>\r\n                                <path d=\"m260.732,236.5c0,9.098 7.402,16.5 16.5,16.5s16.5-7.402 16.5-16.5-7.402-16.5-16.5-16.5-16.5,7.402-16.5,16.5zm23,0c0,3.584-2.916,6.5-6.5,6.5s-6.5-2.916-6.5-6.5 2.916-6.5 6.5-6.5 6.5,2.916 6.5,6.5z\"></path></g></svg></div>\r\n                    <div class=\"pricing-table-title\">Pro</div>\r\n                    <div class=\"card-divider card-divider-xl\"></div>\r\n                    <div class=\"pricing-table-price\"><span class=\"currency\">$</span><span class=\"value\">18</span><span class=\"frecuency\">/mo</span></div>\r\n                    <ul class=\"pricing-table-features\"><li>Lorem ipsum dolor sit amet</li>\r\n                        <li>Pellentesque sit amet odio elit</li>\r\n                        <li>Integer felis odio</li></ul>\r\n                    <button class=\"btn btn-success btn-outline\" type=\"button\">Get Started</button></div></div>\r\n            <div class=\"col-lg-3\"><div class=\"pricing-table pricing-table-color pricing-table-danger\"><div class=\"pricing-table-image\"><svg version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" width=\"78\" height=\"70\" viewbox=\"0 15 473 440\" xmlns:xlink=\"http://-www.w3.org/1999/xlink\" enable-background=\"new 0 15 473 440\"><g><path d=\"m55,91.278c12.131,0 22-9.869 22-22s-9.869-22-22-22-22,9.869-22,22 9.869,22 22,22zm0-34c6.617,0 12,5.383 12,12s-5.383,12-12,12-12-5.383-12-12 5.383-12 12-12z\"></path>\r\n                                <path d=\"m55.003,74.279c1.31,0 2.6-0.53 3.53-1.46 0.93-0.94 1.47-2.23 1.47-3.54 0-1.31-0.54-2.6-1.47-3.54-0.931-0.93-2.221-1.46-3.53-1.46-1.32,0-2.61,0.53-3.54,1.46s-1.46,2.22-1.46,3.54c0,1.32 0.53,2.6 1.46,3.54 0.93,0.93 2.22,1.46 3.54,1.46z\"></path>\r\n                                <path d=\"m55,143.762c12.131,0 22-9.869 22-22s-9.869-22-22-22-22,9.869-22,22 9.869,22 22,22zm0-34c6.617,0 12,5.383 12,12s-5.383,12-12,12-12-5.383-12-12 5.383-12 12-12z\"></path>\r\n                                <path d=\"m55.003,126.759c1.31,0 2.6-0.53 3.53-1.46 0.93-0.93 1.47-2.22 1.47-3.54 0-1.31-0.54-2.6-1.47-3.53-0.931-0.93-2.221-1.47-3.53-1.47-1.32,0-2.61,0.54-3.54,1.47s-1.46,2.22-1.46,3.53c0,1.32 0.53,2.61 1.46,3.54 0.93,0.93 2.22,1.46 3.54,1.46z\"></path>\r\n                                <path d=\"m55,196.246c12.131,0 22-9.869 22-22s-9.869-22-22-22-22,9.869-22,22 9.869,22 22,22zm0-34c6.617,0 12,5.383 12,12s-5.383,12-12,12-12-5.383-12-12 5.383-12 12-12z\"></path>\r\n                                <path d=\"m55.003,179.249c1.31,0 2.6-0.54 3.53-1.47 0.93-0.93 1.47-2.22 1.47-3.53 0-1.32-0.54-2.61-1.47-3.54-0.931-0.93-2.221-1.46-3.53-1.46-1.32,0-2.61,0.53-3.54,1.46s-1.46,2.22-1.46,3.54c0,1.31 0.53,2.6 1.46,3.53 0.93,0.93 2.22,1.47 3.54,1.47z\"></path>\r\n                                <path d=\"m55,248.73c12.131,0 22-9.869 22-22s-9.869-22-22-22-22,9.869-22,22 9.869,22 22,22zm0-34c6.617,0 12,5.383 12,12s-5.383,12-12,12-12-5.383-12-12 5.383-12 12-12z\"></path>\r\n                                <path d=\"m55.003,231.729c1.31,0 2.6-0.53 3.53-1.46 0.93-0.94 1.47-2.22 1.47-3.54 0-1.31-0.54-2.6-1.47-3.53-0.931-0.93-2.221-1.47-3.53-1.47-1.32,0-2.61,0.54-3.54,1.47-0.93,0.92-1.46,2.21-1.46,3.53s0.53,2.61 1.46,3.54c0.93,0.93 2.22,1.46 3.54,1.46z\"></path>\r\n                                <path d=\"m102.5,432.691h-23.5v-162.654c9.895-1.542 17.5-10.097 17.5-20.418v-203.621c0-11.408-9.281-20.689-20.689-20.689h-41.622c-11.408,0-20.689,9.281-20.689,20.689v203.621c0,10.321 7.605,18.876 17.5,20.418v162.655h-23.5c-4.143,0-7.5,3.358-7.5,7.5s3.357,7.5 7.5,7.5h95c4.143,0 7.5-3.358 7.5-7.5s-3.357-7.501-7.5-7.501zm-74-183.072v-203.621c0-3.137 2.553-5.689 5.689-5.689h41.621c3.137,0 5.689,2.552 5.689,5.689v203.621c0,3.137-2.553,5.689-5.689,5.689h-41.621c-3.136,0.001-5.689-2.552-5.689-5.689zm17.5,183.072v-162.382h18v162.383h-18z\"></path>\r\n                                <path d=\"m418,91.278c12.131,0 22-9.869 22-22s-9.869-22-22-22-22,9.869-22,22 9.869,22 22,22zm0-34c6.617,0 12,5.383 12,12s-5.383,12-12,12-12-5.383-12-12 5.383-12 12-12z\"></path>\r\n                                <path d=\"m418.003,74.279c1.31,0 2.6-0.53 3.53-1.47 0.93-0.93 1.47-2.22 1.47-3.53 0-1.32-0.54-2.6-1.47-3.54-0.931-0.93-2.211-1.46-3.53-1.46-1.32,0-2.61,0.53-3.54,1.46-0.93,0.94-1.46,2.22-1.46,3.54 0,1.31 0.53,2.6 1.46,3.53 0.93,0.94 2.22,1.47 3.54,1.47z\"></path>\r\n                                <path d=\"m418,143.762c12.131,0 22-9.869 22-22s-9.869-22-22-22-22,9.869-22,22 9.869,22 22,22zm0-34c6.617,0 12,5.383 12,12s-5.383,12-12,12-12-5.383-12-12 5.383-12 12-12z\"></path>\r\n                                <path d=\"m418.003,126.759c1.31,0 2.6-0.53 3.53-1.46 0.93-0.93 1.47-2.22 1.47-3.54 0-1.31-0.54-2.6-1.47-3.53-0.931-0.93-2.211-1.47-3.53-1.47-1.32,0-2.61,0.54-3.54,1.47s-1.46,2.22-1.46,3.53c0,1.32 0.53,2.61 1.46,3.54 0.93,0.93 2.22,1.46 3.54,1.46z\"></path>\r\n                                <path d=\"m418,196.246c12.131,0 22-9.869 22-22s-9.869-22-22-22-22,9.869-22,22 9.869,22 22,22zm0-34c6.617,0 12,5.383 12,12s-5.383,12-12,12-12-5.383-12-12 5.383-12 12-12z\"></path>\r\n                                <path d=\"m418.003,179.249c1.31,0 2.6-0.54 3.53-1.47 0.93-0.93 1.47-2.22 1.47-3.53 0-1.32-0.54-2.61-1.47-3.54-0.931-0.93-2.211-1.46-3.53-1.46-1.32,0-2.61,0.53-3.54,1.46s-1.46,2.22-1.46,3.54c0,1.31 0.53,2.6 1.46,3.53 0.93,0.93 2.22,1.47 3.54,1.47z\"></path>\r\n                                <path d=\"m418,248.73c12.131,0 22-9.869 22-22s-9.869-22-22-22-22,9.869-22,22 9.869,22 22,22zm0-34c6.617,0 12,5.383 12,12s-5.383,12-12,12-12-5.383-12-12 5.383-12 12-12z\"></path>\r\n                                <path d=\"m418.003,231.729c1.31,0 2.6-0.53 3.53-1.46 0.93-0.94 1.47-2.22 1.47-3.54 0-1.31-0.54-2.6-1.47-3.53-0.931-0.93-2.211-1.47-3.53-1.47-1.32,0-2.61,0.54-3.54,1.47s-1.46,2.22-1.46,3.53c0,1.32 0.53,2.61 1.46,3.54 0.93,0.93 2.22,1.46 3.54,1.46z\"></path>\r\n                                <path d=\"m465.5,432.691h-23.5v-162.654c9.895-1.542 17.5-10.097 17.5-20.418v-203.621c0-11.408-9.281-20.689-20.689-20.689h-41.621c-11.408,0-20.689,9.281-20.689,20.689v203.621c0,10.321 7.605,18.876 17.5,20.418v162.655h-23.5c-4.143,0-7.5,3.358-7.5,7.5s3.357,7.5 7.5,7.5h95c4.143,0 7.5-3.358 7.5-7.5s-3.358-7.501-7.501-7.501zm-74-183.072v-203.621c0-3.137 2.553-5.689 5.689-5.689h41.621c3.137,0 5.689,2.552 5.689,5.689v203.621c0,3.137-2.553,5.689-5.689,5.689h-41.621c-3.136,0.001-5.689-2.552-5.689-5.689zm17.5,183.072v-162.382h18v162.383h-18z\"></path>\r\n                                <path d=\"m337.914,364.691h-21.223v-125.798c0-10.799-8.785-19.584-19.584-19.584h-121.214c-10.799,0-19.584,8.785-19.584,19.584v125.799h-21.223c-11.47,0-20.801,9.331-20.801,20.801v41.398c0,11.469 9.331,20.801 20.801,20.801h202.828c11.47,0 20.801-9.331 20.801-20.801v-41.398c0-11.47-9.331-20.802-20.801-20.802zm-166.605-125.798c0-2.528 2.057-4.584 4.584-4.584h121.215c2.527,0 4.584,2.056 4.584,4.584v125.799h-130.383v-125.799zm172.406,187.998c0,3.198-2.603,5.801-5.801,5.801h-202.828c-3.198,0-5.801-2.602-5.801-5.801v-41.398c0-3.198 2.603-5.801 5.801-5.801h202.828c3.198,0 5.801,2.602 5.801,5.801v41.398z\"></path>\r\n                                <path d=\"m315.226,384.191c-12.131,0-22,9.869-22,22s9.869,22 22,22 22-9.869 22-22-9.87-22-22-22zm0,34c-6.617,0-12-5.383-12-12s5.383-12 12-12 12,5.383 12,12-5.383,12-12,12z\"></path>\r\n                                <path d=\"m315.223,401.189c-1.32,0-2.6,0.54-3.53,1.47-0.93,0.93-1.47,2.21-1.47,3.53s0.54,2.61 1.47,3.54c0.931,0.93 2.221,1.46 3.53,1.46 1.32,0 2.6-0.53 3.54-1.46 0.93-0.93 1.46-2.22 1.46-3.54 0-1.31-0.53-2.6-1.46-3.53s-2.22-1.47-3.54-1.47z\"></path>\r\n                                <path d=\"m157.773,384.191c-12.131,0-22,9.869-22,22s9.869,22 22,22 22-9.869 22-22-9.869-22-22-22zm0,34c-6.617,0-12-5.383-12-12s5.383-12 12-12 12,5.383 12,12-5.382,12-12,12z\"></path>\r\n                                <path d=\"m157.772,401.189c-1.319,0-2.609,0.54-3.54,1.47-0.93,0.92-1.46,2.21-1.46,3.53s0.53,2.61 1.46,3.54c0.931,0.93 2.221,1.46 3.54,1.46 1.32,0 2.61-0.53 3.54-1.46 0.931-0.93 1.46-2.22 1.46-3.54 0-1.31-0.529-2.6-1.46-3.53-0.929-0.93-2.219-1.47-3.54-1.47z\"></path>\r\n                                <path d=\"m286.846,273.488l1.229-1.23c3.251-3.252 5.042-7.573 5.042-12.167 0-4.594-1.791-8.914-5.043-12.167-3.249-3.25-7.57-5.039-12.166-5.039s-8.917,1.79-12.166,5.039l-1.23,1.23c-7.797-4.045-16.639-6.346-26.012-6.346-9.373,0-18.213,2.3-26.009,6.344l-1.229-1.229c-6.712-6.712-17.633-6.711-24.343,0-6.712,6.712-6.712,17.632 0,24.344l1.23,1.23c-4.042,7.795-6.341,16.633-6.341,26.003 0,9.371 2.299,18.21 6.342,26.006l-1.233,1.233c-6.712,6.712-6.712,17.632 0,24.344 3.355,3.356 7.764,5.033 12.171,5.033 4.408,0 8.816-1.678 12.173-5.034l1.233-1.233c7.795,4.043 16.634,6.342 26.005,6.342 9.373,0 18.213-2.3 26.01-6.344l1.234,1.234c3.252,3.251 7.572,5.042 12.167,5.042s8.915-1.791 12.166-5.042c6.709-6.709 6.709-17.624 0-24.333l-1.232-1.232c4.046-7.798 6.348-16.641 6.348-26.016-0.001-9.374-2.301-18.215-6.346-26.012zm-5.843-18.492c1.363,1.363 2.114,3.173 2.114,5.095 0,1.767-0.641,3.433-1.801,4.75-2.945-3.799-6.359-7.213-10.158-10.158 2.828-2.484 7.147-2.386 9.845,0.313zm-89.014-.001c2.702-2.702 7.026-2.8 9.855-0.313-3.803,2.948-7.221,6.365-10.168,10.169-2.487-2.831-2.388-7.155 0.313-9.856zm-.001,89.016c-1.36-1.361-2.11-3.172-2.11-5.101 0-1.773 0.641-3.443 1.801-4.759 2.948,3.804 6.365,7.222 10.169,10.169-2.831,2.493-7.158,2.394-9.86-0.309zm-2.179-44.511c0-25.746 20.945-46.691 46.691-46.691s46.691,20.946 46.691,46.691-20.945,46.691-46.691,46.691-46.691-20.945-46.691-46.691zm91.196,44.51c-1.362,1.363-3.172,2.113-5.095,2.113-1.769,0-3.438-0.642-4.755-1.804 3.8-2.945 7.214-6.359 10.159-10.158 2.489,2.827 2.392,7.149-0.309,9.849z\"></path>\r\n                                <path d=\"m236.5,259.441c-22.089,0-40.06,17.97-40.06,40.059s17.971,40.059 40.06,40.059c22.088,0 40.059-17.97 40.059-40.059s-17.971-40.059-40.059-40.059zm0,70.118c-16.575,0-30.06-13.484-30.06-30.059s13.484-30.059 30.06-30.059c16.574,0 30.059,13.484 30.059,30.059s-13.485,30.059-30.059,30.059z\"></path>\r\n                                <path d=\"m236.5,281.01c-10.195,0-18.49,8.294-18.49,18.49s8.295,18.49 18.49,18.49 18.489-8.294 18.489-18.49-8.294-18.49-18.489-18.49zm0,26.98c-4.682,0-8.49-3.809-8.49-8.49s3.809-8.49 8.49-8.49c4.681,0 8.489,3.809 8.489,8.49s-3.808,8.49-8.489,8.49z\"></path>\r\n                                <path d=\"m273,388.691h-73c-2.762,0-5,2.239-5,5v25c0,2.761 2.238,5 5,5h73c2.762,0 5-2.239 5-5v-25c0-2.761-2.238-5-5-5zm-5,25h-63v-15h63v15z\"></path></g></svg></div>\r\n                    <div class=\"pricing-table-title\">Team</div>\r\n                    <div class=\"card-divider card-divider-xl\"></div>\r\n                    <div class=\"pricing-table-price\"><span class=\"currency\">$</span><span class=\"value\">25</span><span class=\"frecuency\">/mo</span></div>\r\n                    <ul class=\"pricing-table-features\"><li>Lorem ipsum dolor sit amet</li>\r\n                        <li>Pellentesque sit amet odio elit</li>\r\n                        <li>Integer felis odio</li></ul>\r\n                    <button class=\"btn btn-danger btn-outline\" type=\"button\">Get Started</button></div></div></div></div></div>\r\n");
            __builder.AddMarkupContent(1, "<nav class=\"be-right-sidebar\"><div class=\"sb-content\"><div class=\"tab-navigation\"><ul class=\"nav nav-tabs nav-justified\" role=\"tablist\"><li class=\"nav-item\" role=\"presentation\"><a class=\"nav-link active\" href=\"#tab1\" aria-controls=\"tab1\" role=\"tab\" data-toggle=\"tab\">Chat</a></li>\r\n                <li class=\"nav-item\" role=\"presentation\"><a class=\"nav-link\" href=\"#tab2\" aria-controls=\"tab2\" role=\"tab\" data-toggle=\"tab\">Todo</a></li>\r\n                <li class=\"nav-item\" role=\"presentation\"><a class=\"nav-link\" href=\"#tab3\" aria-controls=\"tab3\" role=\"tab\" data-toggle=\"tab\">Settings</a></li></ul></div>\r\n        <div class=\"tab-panel\"><div class=\"tab-content\"><div class=\"tab-pane tab-chat active\" id=\"tab1\" role=\"tabpanel\"><div class=\"chat-contacts\"><div class=\"chat-sections\"><div class=\"be-scroller-chat\"><div class=\"content\"><h2>Recent</h2>\r\n                                    <div class=\"contact-list contact-list-recent\"><div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar1.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data\"><span class=\"status away\"></span><span class=\"name\">Claire Sassu</span><span class=\"message\">Can you share the...</span></div></a></div>\r\n                                        <div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar2.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data\"><span class=\"status\"></span><span class=\"name\">Maggie jackson</span><span class=\"message\">I confirmed the info.</span></div></a></div>\r\n                                        <div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar3.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data\"><span class=\"status offline\"></span><span class=\"name\">Joel King\t\t</span><span class=\"message\">Ready for the meeti...</span></div></a></div></div>\r\n                                    <h2>Contacts</h2>\r\n                                    <div class=\"contact-list\"><div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar4.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data2\"><span class=\"status\"></span><span class=\"name\">Mike Bolthort</span></div></a></div>\r\n                                        <div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar5.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data2\"><span class=\"status\"></span><span class=\"name\">Maggie jackson</span></div></a></div>\r\n                                        <div class=\"user\"><a href=\"#\"><img src=\"assets\\img\\avatar6.png\" alt=\"Avatar\">\r\n                                                <div class=\"user-data2\"><span class=\"status offline\"></span><span class=\"name\">Jhon Voltemar</span></div></a></div></div></div></div></div>\r\n                        <div class=\"bottom-input\"><input type=\"text\" placeholder=\"Search...\" name=\"q\"><span class=\"mdi mdi-search\"></span></div></div>\r\n                    <div class=\"chat-window\"><div class=\"title\"><div class=\"user\"><img src=\"assets\\img\\avatar2.png\" alt=\"Avatar\">\r\n                                <h2>Maggie jackson</h2><span>Active 1h ago</span></div><span class=\"icon return mdi mdi-chevron-left\"></span></div>\r\n                        <div class=\"chat-messages\"><div class=\"be-scroller-messages\"><div class=\"content\"><ul><li class=\"friend\"><div class=\"msg\">Hello</div></li>\r\n                                        <li class=\"self\"><div class=\"msg\">Hi, how are you?</div></li>\r\n                                        <li class=\"friend\"><div class=\"msg\">Good, I\'ll need support with my pc</div></li>\r\n                                        <li class=\"self\"><div class=\"msg\">Sure, just tell me what is going on with your computer?</div></li>\r\n                                        <li class=\"friend\"><div class=\"msg\">I don\'t know it just turns off suddenly</div></li></ul></div></div></div>\r\n                        <div class=\"chat-input\"><div class=\"input-wrapper\"><span class=\"photo mdi mdi-camera\"></span>\r\n                                <input type=\"text\" placeholder=\"Message...\" name=\"q\" autocomplete=\"off\"><span class=\"send-msg mdi mdi-mail-send\"></span></div></div></div></div>\r\n                <div class=\"tab-pane tab-todo\" id=\"tab2\" role=\"tabpanel\"><div class=\"todo-container\"><div class=\"todo-wrapper\"><div class=\"be-scroller-todo\"><div class=\"todo-content\"><span class=\"category-title\">Today</span>\r\n                                    <ul class=\"todo-list\"><li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" checked id=\"tck1\">\r\n                                                <label class=\"custom-control-label\" for=\"tck1\">Initialize the project</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck2\">\r\n                                                <label class=\"custom-control-label\" for=\"tck2\">Create the main structure\t\t\t\t\t\t\t</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck3\">\r\n                                                <label class=\"custom-control-label\" for=\"tck3\">Updates changes to GitHub\t\t\t\t\t\t\t</label></div></li></ul><span class=\"category-title\">Tomorrow</span>\r\n                                    <ul class=\"todo-list\"><li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck4\">\r\n                                                <label class=\"custom-control-label\" for=\"tck4\">Initialize the project\t\t\t\t\t\t\t</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck5\">\r\n                                                <label class=\"custom-control-label\" for=\"tck5\">Create the main structure\t\t\t\t\t\t\t</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck6\">\r\n                                                <label class=\"custom-control-label\" for=\"tck6\">Updates changes to GitHub\t\t\t\t\t\t\t</label></div></li>\r\n                                        <li><div class=\"custom-checkbox custom-control custom-control-sm\"><span class=\"delete mdi mdi-delete\"></span>\r\n                                                <input class=\"custom-control-input\" type=\"checkbox\" id=\"tck7\">\r\n                                                <label class=\"custom-control-label\" for=\"tck7\" title=\"This task is too long to be displayed in a normal space!\">This task is too long to be displayed in a normal space!\t\t\t\t\t\t\t</label></div></li></ul></div></div></div>\r\n                        <div class=\"bottom-input\"><input type=\"text\" placeholder=\"Create new task...\" name=\"q\"><span class=\"mdi mdi-plus\"></span></div></div></div>\r\n                <div class=\"tab-pane tab-settings\" id=\"tab3\" role=\"tabpanel\"><div class=\"settings-wrapper\"><div class=\"be-scroller-settings\"><span class=\"category-title\">General</span>\r\n                            <ul class=\"settings-list\"><li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st1\" id=\"st1\"><span><label for=\"st1\"></label></span></div><span class=\"name\">Available</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st2\" id=\"st2\"><span><label for=\"st2\"></label></span></div><span class=\"name\">Enable notifications</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st3\" id=\"st3\"><span><label for=\"st3\"></label></span></div><span class=\"name\">Login with Facebook</span></li></ul><span class=\"category-title\">Notifications</span>\r\n                            <ul class=\"settings-list\"><li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" name=\"st4\" id=\"st4\"><span><label for=\"st4\"></label></span></div><span class=\"name\">Email notifications</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st5\" id=\"st5\"><span><label for=\"st5\"></label></span></div><span class=\"name\">Project updates</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" checked name=\"st6\" id=\"st6\"><span><label for=\"st6\"></label></span></div><span class=\"name\">New comments</span></li>\r\n                                <li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" name=\"st7\" id=\"st7\"><span><label for=\"st7\"></label></span></div><span class=\"name\">Chat messages</span></li></ul><span class=\"category-title\">Workflow</span>\r\n                            <ul class=\"settings-list\"><li><div class=\"switch-button switch-button-sm\"><input type=\"checkbox\" name=\"st8\" id=\"st8\"><span><label for=\"st8\"></label></span></div><span class=\"name\">Deploy on commit</span></li></ul></div></div></div></div></div></div></nav>\r\n\r\n<!-- Js Plugins\r\n");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
