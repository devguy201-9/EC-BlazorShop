#pragma checksum "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\Pages\Webpage\Checkout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8427d8294bdb8be80633b3a3da04e28009dc2d58"
// <auto-generated/>
#pragma warning disable 1591
namespace VegetableShop.Pages.Webpage
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Checkout")]
    public partial class Checkout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""breadcrumb-section set-bg"" data-setbg=""img/breadcrumb.jpg""><div class=""container""><div class=""row""><div class=""col-lg-12 text-center""><div class=""breadcrumb__text""><h2>Checkout</h2>
                        <div class=""breadcrumb__option""><a href=""./index.html"">Home</a>
                            <span>Checkout</span></div></div></div></div></div></section>
    
    
    ");
            __builder.AddMarkupContent(1, "<section class=\"checkout spad\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-12\"><h6><span class=\"icon_tag_alt\"></span> Have a coupon? <a href=\"#\">Click here</a> to enter your code\r\n                    </h6></div></div>\r\n            <div class=\"checkout__form\"><h4>Billing Details</h4>\r\n                <form action=\"#\"><div class=\"row\"><div class=\"col-lg-8 col-md-6\"><div class=\"row\"><div class=\"col-lg-6\"><div class=\"checkout__input\"><p>Fist Name<span>*</span></p>\r\n                                        <input type=\"text\"></div></div>\r\n                                <div class=\"col-lg-6\"><div class=\"checkout__input\"><p>Last Name<span>*</span></p>\r\n                                        <input type=\"text\"></div></div></div>\r\n                            <div class=\"checkout__input\"><p>Country<span>*</span></p>\r\n                                <input type=\"text\"></div>\r\n                            <div class=\"checkout__input\"><p>Address<span>*</span></p>\r\n                                <input type=\"text\" placeholder=\"Street Address\" class=\"checkout__input__add\">\r\n                                <input type=\"text\" placeholder=\"Apartment, suite, unite ect (optinal)\"></div>\r\n                            <div class=\"checkout__input\"><p>Town/City<span>*</span></p>\r\n                                <input type=\"text\"></div>\r\n                            <div class=\"checkout__input\"><p>Country/State<span>*</span></p>\r\n                                <input type=\"text\"></div>\r\n                            <div class=\"checkout__input\"><p>Postcode / ZIP<span>*</span></p>\r\n                                <input type=\"text\"></div>\r\n                            <div class=\"row\"><div class=\"col-lg-6\"><div class=\"checkout__input\"><p>Phone<span>*</span></p>\r\n                                        <input type=\"text\"></div></div>\r\n                                <div class=\"col-lg-6\"><div class=\"checkout__input\"><p>Email<span>*</span></p>\r\n                                        <input type=\"text\"></div></div></div>\r\n                            <div class=\"checkout__input__checkbox\"><label for=\"acc\">\r\n                                    Create an account?\r\n                                    <input type=\"checkbox\" id=\"acc\">\r\n                                    <span class=\"checkmark\"></span></label></div>\r\n                            <p>\r\n                                Create an account by entering the information below. If you are a returning customer\r\n                                please login at the top of the page\r\n                            </p>\r\n                            <div class=\"checkout__input\"><p>Account Password<span>*</span></p>\r\n                                <input type=\"text\"></div>\r\n                            <div class=\"checkout__input__checkbox\"><label for=\"diff-acc\">\r\n                                    Ship to a different address?\r\n                                    <input type=\"checkbox\" id=\"diff-acc\">\r\n                                    <span class=\"checkmark\"></span></label></div>\r\n                            <div class=\"checkout__input\"><p>Order notes<span>*</span></p>\r\n                                <input type=\"text\" placeholder=\"Notes about your order, e.g. special notes for delivery.\"></div></div>\r\n                        <div class=\"col-lg-4 col-md-6\"><div class=\"checkout__order\"><h4>Your Order</h4>\r\n                                <div class=\"checkout__order__products\">Products <span>Total</span></div>\r\n                                <ul><li>Vegetable’s Package <span>$75.99</span></li>\r\n                                    <li>Fresh Vegetable <span>$151.99</span></li>\r\n                                    <li>Organic Bananas <span>$53.99</span></li></ul>\r\n                                <div class=\"checkout__order__subtotal\">Subtotal <span>$750.99</span></div>\r\n                                <div class=\"checkout__order__total\">Total <span>$750.99</span></div>\r\n                                <div class=\"checkout__input__checkbox\"><label for=\"acc-or\">\r\n                                        Create an account?\r\n                                        <input type=\"checkbox\" id=\"acc-or\">\r\n                                        <span class=\"checkmark\"></span></label></div>\r\n                                <p>\r\n                                    Lorem ipsum dolor sit amet, consectetur adip elit, sed do eiusmod tempor incididunt\r\n                                    ut labore et dolore magna aliqua.\r\n                                </p>\r\n                                <div class=\"checkout__input__checkbox\"><label for=\"payment\">\r\n                                        Check Payment\r\n                                        <input type=\"checkbox\" id=\"payment\">\r\n                                        <span class=\"checkmark\"></span></label></div>\r\n                                <div class=\"checkout__input__checkbox\"><label for=\"paypal\">\r\n                                        Paypal\r\n                                        <input type=\"checkbox\" id=\"paypal\">\r\n                                        <span class=\"checkmark\"></span></label></div>\r\n                                <button type=\"submit\" class=\"site-btn\">PLACE ORDER</button></div></div></div></form></div></div></section>\r\n    \r\n    \r\n    ");
            __builder.AddMarkupContent(2, "<footer class=\"footer spad\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-3 col-md-6 col-sm-6\"><div class=\"footer__about\"><div class=\"footer__about__logo\"><a href=\"./index.html\"><img src=\"img/logo.png\" alt></a></div>\r\n                        <ul><li>Address: 60-49 Road 11378 New York</li>\r\n                            <li>Phone: +65 11.188.888</li>\r\n                            <li>Email: hello@colorlib.com</li></ul></div></div>\r\n                <div class=\"col-lg-4 col-md-6 col-sm-6 offset-lg-1\"><div class=\"footer__widget\"><h6>Useful Links</h6>\r\n                        <ul><li><a href=\"#\">About Us</a></li>\r\n                            <li><a href=\"#\">About Our Shop</a></li>\r\n                            <li><a href=\"#\">Secure Shopping</a></li>\r\n                            <li><a href=\"#\">Delivery infomation</a></li>\r\n                            <li><a href=\"#\">Privacy Policy</a></li>\r\n                            <li><a href=\"#\">Our Sitemap</a></li></ul>\r\n                        <ul><li><a href=\"#\">Who We Are</a></li>\r\n                            <li><a href=\"#\">Our Services</a></li>\r\n                            <li><a href=\"#\">Projects</a></li>\r\n                            <li><a href=\"#\">Contact</a></li>\r\n                            <li><a href=\"#\">Innovation</a></li>\r\n                            <li><a href=\"#\">Testimonials</a></li></ul></div></div>\r\n                <div class=\"col-lg-4 col-md-12\"><div class=\"footer__widget\"><h6>Join Our Newsletter Now</h6>\r\n                        <p>Get E-mail updates about our latest shop and special offers.</p>\r\n                        <form action=\"#\"><input type=\"text\" placeholder=\"Enter your mail\">\r\n                            <button type=\"submit\" class=\"site-btn\">Subscribe</button></form>\r\n                        <div class=\"footer__widget__social\"><a href=\"#\"><i class=\"fa fa-facebook\"></i></a>\r\n                            <a href=\"#\"><i class=\"fa fa-instagram\"></i></a>\r\n                            <a href=\"#\"><i class=\"fa fa-twitter\"></i></a>\r\n                            <a href=\"#\"><i class=\"fa fa-pinterest\"></i></a></div></div></div></div>\r\n            <div class=\"row\"><div class=\"col-lg-12\"><div class=\"footer__copyright\"><div class=\"footer__copyright__text\"><p>\r\n                                Copyright &copy;\r\n                                All rights reserved | This template is made with <i class=\"fa fa-heart\" aria-hidden=\"true\"></i> by <a href=\"https://colorlib.com\" target=\"_blank\">Colorlib</a></p></div>\r\n                        <div class=\"footer__copyright__payment\"><img src=\"img/payment-item.png\" alt></div></div></div></div></div></footer>\r\n    \r\n    <!-- Js Plugins \r\n\r\n\r\n");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
