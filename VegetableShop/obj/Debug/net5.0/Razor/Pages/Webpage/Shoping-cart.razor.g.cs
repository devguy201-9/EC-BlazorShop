#pragma checksum "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\Pages\Webpage\Shoping-cart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16f7a8c8cd6b5c6970e6c674caac9a66fe6adae3"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cart")]
    public partial class Shoping_cart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""breadcrumb-section set-bg"" data-setbg=""img/breadcrumb.jpg""><div class=""container""><div class=""row""><div class=""col-lg-12 text-center""><div class=""breadcrumb__text""><h2>Shopping Cart</h2>
                    <div class=""breadcrumb__option""><a href=""./index.html"">Home</a>
                        <span>Shopping Cart</span></div></div></div></div></div></section>


");
            __builder.AddMarkupContent(1, "<section class=\"shoping-cart spad\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-12\"><div class=\"shoping__cart__table\"><table><thead><tr><th class=\"shoping__product\">Products</th>\r\n                                <th>Price</th>\r\n                                <th>Quantity</th>\r\n                                <th>Total</th>\r\n                                <th></th></tr></thead>\r\n                        <tbody><tr><td class=\"shoping__cart__item\"><img src=\"img/cart/cart-1.jpg\" alt>\r\n                                    <h5>Vegetable’s Package</h5></td>\r\n                                <td class=\"shoping__cart__price\">\r\n                                    $55.00\r\n                                </td>\r\n                                <td class=\"shoping__cart__quantity\"><div class=\"quantity\"><div class=\"pro-qty\"><input type=\"text\" value=\"1\"></div></div></td>\r\n                                <td class=\"shoping__cart__total\">\r\n                                    $110.00\r\n                                </td>\r\n                                <td class=\"shoping__cart__item__close\"><span class=\"icon_close\"></span></td></tr>\r\n                            <tr><td class=\"shoping__cart__item\"><img src=\"img/cart/cart-2.jpg\" alt>\r\n                                    <h5>Fresh Garden Vegetable</h5></td>\r\n                                <td class=\"shoping__cart__price\">\r\n                                    $39.00\r\n                                </td>\r\n                                <td class=\"shoping__cart__quantity\"><div class=\"quantity\"><div class=\"pro-qty\"><input type=\"text\" value=\"1\"></div></div></td>\r\n                                <td class=\"shoping__cart__total\">\r\n                                    $39.99\r\n                                </td>\r\n                                <td class=\"shoping__cart__item__close\"><span class=\"icon_close\"></span></td></tr>\r\n                            <tr><td class=\"shoping__cart__item\"><img src=\"img/cart/cart-3.jpg\" alt>\r\n                                    <h5>Organic Bananas</h5></td>\r\n                                <td class=\"shoping__cart__price\">\r\n                                    $69.00\r\n                                </td>\r\n                                <td class=\"shoping__cart__quantity\"><div class=\"quantity\"><div class=\"pro-qty\"><input type=\"text\" value=\"1\"></div></div></td>\r\n                                <td class=\"shoping__cart__total\">\r\n                                    $69.99\r\n                                </td>\r\n                                <td class=\"shoping__cart__item__close\"><span class=\"icon_close\"></span></td></tr></tbody></table></div></div></div>\r\n        <div class=\"row\"><div class=\"col-lg-12\"><div class=\"shoping__cart__btns\"><a href=\"#\" class=\"primary-btn cart-btn\">CONTINUE SHOPPING</a>\r\n                    <a href=\"#\" class=\"primary-btn cart-btn cart-btn-right\"><span class=\"icon_loading\"></span>\r\n                        Upadate Cart\r\n                    </a></div></div>\r\n            <div class=\"col-lg-6\"><div class=\"shoping__continue\"><div class=\"shoping__discount\"><h5>Discount Codes</h5>\r\n                        <form action=\"#\"><input type=\"text\" placeholder=\"Enter your coupon code\">\r\n                            <button type=\"submit\" class=\"site-btn\">APPLY COUPON</button></form></div></div></div>\r\n            <div class=\"col-lg-6\"><div class=\"shoping__checkout\"><h5>Cart Total</h5>\r\n                    <ul><li>Subtotal <span>$454.98</span></li>\r\n                        <li>Total <span>$454.98</span></li></ul>\r\n                    <a href=\"#\" class=\"primary-btn\">PROCEED TO CHECKOUT</a></div></div></div></div></section>\r\n\r\n\r\n");
            __builder.AddMarkupContent(2, "<footer class=\"footer spad\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-3 col-md-6 col-sm-6\"><div class=\"footer__about\"><div class=\"footer__about__logo\"><a href=\"./index.html\"><img src=\"img/logo.png\" alt></a></div>\r\n                    <ul><li>Address: 60-49 Road 11378 New York</li>\r\n                        <li>Phone: +65 11.188.888</li>\r\n                        <li>Email: hello@colorlib.com</li></ul></div></div>\r\n            <div class=\"col-lg-4 col-md-6 col-sm-6 offset-lg-1\"><div class=\"footer__widget\"><h6>Useful Links</h6>\r\n                    <ul><li><a href=\"#\">About Us</a></li>\r\n                        <li><a href=\"#\">About Our Shop</a></li>\r\n                        <li><a href=\"#\">Secure Shopping</a></li>\r\n                        <li><a href=\"#\">Delivery infomation</a></li>\r\n                        <li><a href=\"#\">Privacy Policy</a></li>\r\n                        <li><a href=\"#\">Our Sitemap</a></li></ul>\r\n                    <ul><li><a href=\"#\">Who We Are</a></li>\r\n                        <li><a href=\"#\">Our Services</a></li>\r\n                        <li><a href=\"#\">Projects</a></li>\r\n                        <li><a href=\"#\">Contact</a></li>\r\n                        <li><a href=\"#\">Innovation</a></li>\r\n                        <li><a href=\"#\">Testimonials</a></li></ul></div></div>\r\n            <div class=\"col-lg-4 col-md-12\"><div class=\"footer__widget\"><h6>Join Our Newsletter Now</h6>\r\n                    <p>Get E-mail updates    about our latest shop and special offers.</p>\r\n                    <form action=\"#\"><input type=\"text\" placeholder=\"Enter your mail\">\r\n                        <button type=\"submit\" class=\"site-btn\">Subscribe</button></form>\r\n                    <div class=\"footer__widget__social\"><a href=\"#\"><i class=\"fa fa-facebook\"></i></a>\r\n                        <a href=\"#\"><i class=\"fa fa-instagram\"></i></a>\r\n                        <a href=\"#\"><i class=\"fa fa-twitter\"></i></a>\r\n                        <a href=\"#\"><i class=\"fa fa-pinterest\"></i></a></div></div></div></div>\r\n        <div class=\"row\"><div class=\"col-lg-12\"><div class=\"footer__copyright\"><div class=\"footer__copyright__text\"><p>\r\n                            Copyright &copy;\r\n                           All rights reserved | This template is made with <i class=\"fa fa-heart\" aria-hidden=\"true\"></i> by <a href=\"https://colorlib.com\" target=\"_blank\">Colorlib</a></p></div>\r\n                    <div class=\"footer__copyright__payment\"><img src=\"img/payment-item.png\" alt></div></div></div></div></div></footer>\r\n\r\n<!-- Js Plugins");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
