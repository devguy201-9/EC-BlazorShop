#pragma checksum "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\Pages\Webpage\Blog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6176bd697411efc457e425609e5e0928320f95a7"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Blog")]
    public partial class Blog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"preloder\"><div class=\"loader\"></div></div>\r\n\r\n    \r\n    <div class=\"humberger__menu__overlay\"></div>\r\n    ");
            __builder.AddMarkupContent(1, "<div class=\"humberger__menu__wrapper\"><div class=\"humberger__menu__logo\"><a href=\"#\"><img src=\"img/logo.png\" alt></a></div>\r\n        <div class=\"humberger__menu__cart\"><ul><li><a href=\"#\"><i class=\"fa fa-heart\"></i> <span>1</span></a></li>\r\n                <li><a href=\"#\"><i class=\"fa fa-shopping-bag\"></i> <span>3</span></a></li></ul>\r\n            <div class=\"header__cart__price\">item: <span>$150.00</span></div></div>\r\n        <div class=\"humberger__menu__widget\"><div class=\"header__top__right__language\"><img src=\"img/language.png\" alt>\r\n                <div>English</div>\r\n                <span class=\"arrow_carrot-down\"></span>\r\n                <ul><li><a href=\"#\">Spanis</a></li>\r\n                    <li><a href=\"#\">English</a></li></ul></div>\r\n            <div class=\"header__top__right__auth\"><a href=\"#\"><i class=\"fa fa-user\"></i> Login</a></div></div>\r\n        <nav class=\"humberger__menu__nav mobile-menu\"><ul><li class=\"active\"><a href>Home</a></li>\r\n                <li><a href=\"Grid\">Shop</a></li>\r\n                <li><a href=\"#\">Pages</a>\r\n                    <ul class=\"header__menu__dropdown\"><li><a href=\"Details\">Shop Details</a></li>\r\n                        <li><a href=\"Grid\">Shoping Cart</a></li>\r\n                        <li><a href=\"Checkout\">Check Out</a></li>\r\n                        <li><a href=\"Blogdetails\">Blog Details</a></li></ul></li>\r\n                <li><a href=\"Blog\">Blog</a></li>\r\n                <li><a href=\"Contact\">Contact</a></li></ul></nav>\r\n        <div id=\"mobile-menu-wrap\"></div>\r\n        <div class=\"header__top__right__social\"><a href=\"#\"><i class=\"fa fa-facebook\"></i></a>\r\n            <a href=\"#\"><i class=\"fa fa-twitter\"></i></a>\r\n            <a href=\"#\"><i class=\"fa fa-linkedin\"></i></a>\r\n            <a href=\"#\"><i class=\"fa fa-pinterest-p\"></i></a></div>\r\n        <div class=\"humberger__menu__contact\"><ul><li><i class=\"fa fa-envelope\"></i> hello@colorlib.com</li>\r\n                <li>Free Shipping for all Order of $99</li></ul></div></div>\r\n    \r\n    \r\n    ");
            __builder.AddMarkupContent(2, "<header class=\"header\"><div class=\"header__top\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-6\"><div class=\"header__top__left\"><ul><li><i class=\"fa fa-envelope\"></i> hello@colorlib.com</li>\r\n                                <li>Free Shipping for all Order of $99</li></ul></div></div>\r\n                    <div class=\"col-lg-6\"><div class=\"header__top__right\"><div class=\"header__top__right__social\"><a href=\"#\"><i class=\"fa fa-facebook\"></i></a>\r\n                                <a href=\"#\"><i class=\"fa fa-twitter\"></i></a>\r\n                                <a href=\"#\"><i class=\"fa fa-linkedin\"></i></a>\r\n                                <a href=\"#\"><i class=\"fa fa-pinterest-p\"></i></a></div>\r\n                            <div class=\"header__top__right__language\"><img src=\"img/language.png\" alt>\r\n                                <div>English</div>\r\n                                <span class=\"arrow_carrot-down\"></span>\r\n                                <ul><li><a href=\"#\">Spanis</a></li>\r\n                                    <li><a href=\"#\">English</a></li></ul></div>\r\n                            <div class=\"header__top__right__auth\"><a href=\"#\"><i class=\"fa fa-user\"></i> Login</a></div></div></div></div></div></div>\r\n        <div class=\"container\"><div class=\"row\"><div class=\"col-lg-3\"><div class=\"header__logo\"><a href=\"./index.html\"><img src=\"img/logo.png\" alt></a></div></div>\r\n                <div class=\"col-lg-6\"><nav class=\"header__menu\"><ul><li class=\"active\"><a href>Home</a></li>\r\n                            <li><a href=\"Grid\">Shop</a></li>\r\n                            <li><a href=\"#\">Pages</a>\r\n                                <ul class=\"header__menu__dropdown\"><li><a href=\"Details\">Shop Details</a></li>\r\n                                    <li><a href=\"Grid\">Shoping Cart</a></li>\r\n                                    <li><a href=\"Checkout\">Check Out</a></li>\r\n                                    <li><a href=\"Blogdetails\">Blog Details</a></li></ul></li>\r\n                            <li><a href=\"Blog\">Blog</a></li>\r\n                            <li><a href=\"Contact\">Contact</a></li></ul></nav></div>\r\n                <div class=\"col-lg-3\"><div class=\"header__cart\"><ul><li><a href=\"#\"><i class=\"fa fa-heart\"></i> <span>1</span></a></li>\r\n                            <li><a href=\"#\"><i class=\"fa fa-shopping-bag\"></i> <span>3</span></a></li></ul>\r\n                        <div class=\"header__cart__price\">item: <span>$150.00</span></div></div></div></div>\r\n            <div class=\"humberger__open\"><i class=\"fa fa-bars\"></i></div></div></header>\r\n    \r\n    \r\n    ");
            __builder.AddMarkupContent(3, "<section class=\"hero hero-normal\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-3\"><div class=\"hero__categories\"><div class=\"hero__categories__all\"><i class=\"fa fa-bars\"></i>\r\n                            <span>All departments</span></div>\r\n                        <ul><li><a href=\"#\">Fresh Meat</a></li>\r\n                            <li><a href=\"#\">Vegetables</a></li>\r\n                            <li><a href=\"#\">Fruit & Nut Gifts</a></li>\r\n                            <li><a href=\"#\">Fresh Berries</a></li>\r\n                            <li><a href=\"#\">Ocean Foods</a></li>\r\n                            <li><a href=\"#\">Butter & Eggs</a></li>\r\n                            <li><a href=\"#\">Fastfood</a></li>\r\n                            <li><a href=\"#\">Fresh Onion</a></li>\r\n                            <li><a href=\"#\">Papayaya & Crisps</a></li>\r\n                            <li><a href=\"#\">Oatmeal</a></li>\r\n                            <li><a href=\"#\">Fresh Bananas</a></li></ul></div></div>\r\n                <div class=\"col-lg-9\"><div class=\"hero__search\"><div class=\"hero__search__form\"><form action=\"#\"><div class=\"hero__search__categories\">\r\n                                    All Categories\r\n                                    <span class=\"arrow_carrot-down\"></span></div>\r\n                                <input type=\"text\" placeholder=\"What do yo u need?\">\r\n                                <button type=\"submit\" class=\"site-btn\">SEARCH</button></form></div>\r\n                        <div class=\"hero__search__phone\"><div class=\"hero__search__phone__icon\"><i class=\"fa fa-phone\"></i></div>\r\n                            <div class=\"hero__search__phone__text\"><h5>+65 11.188.888</h5>\r\n                                <span>support 24/7 time</span></div></div></div></div></div></div></section>\r\n    \r\n    \r\n    ");
            __builder.AddMarkupContent(4, @"<section class=""breadcrumb-section set-bg"" data-setbg=""img/breadcrumb.jpg""><div class=""container""><div class=""row""><div class=""col-lg-12 text-center""><div class=""breadcrumb__text""><h2>Blog</h2>
                        <div class=""breadcrumb__option""><a href=""./index.html"">Home</a>
                            <span>Blog</span></div></div></div></div></div></section>
    
    
    ");
            __builder.AddMarkupContent(5, "<section class=\"blog spad\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-4 col-md-5\"><div class=\"blog__sidebar\"><div class=\"blog__sidebar__search\"><form action=\"#\"><input type=\"text\" placeholder=\"Search...\">\r\n                                <button type=\"submit\"><span class=\"icon_search\"></span></button></form></div>\r\n                        <div class=\"blog__sidebar__item\"><h4>Categories</h4>\r\n                            <ul><li><a href=\"#\">All</a></li>\r\n                                <li><a href=\"#\">Beauty (20)</a></li>\r\n                                <li><a href=\"#\">Food (5)</a></li>\r\n                                <li><a href=\"#\">Life Style (9)</a></li>\r\n                                <li><a href=\"#\">Travel (10)</a></li></ul></div>\r\n                        <div class=\"blog__sidebar__item\"><h4>Recent News</h4>\r\n                            <div class=\"blog__sidebar__recent\"><a href=\"#\" class=\"blog__sidebar__recent__item\"><div class=\"blog__sidebar__recent__item__pic\"><img src=\"img/blog/sidebar/sr-1.jpg\" alt></div>\r\n                                    <div class=\"blog__sidebar__recent__item__text\"><h6>09 Kinds Of Vegetables<br> Protect The Liver</h6>\r\n                                        <span>MAR 05, 2019</span></div></a>\r\n                                <a href=\"#\" class=\"blog__sidebar__recent__item\"><div class=\"blog__sidebar__recent__item__pic\"><img src=\"img/blog/sidebar/sr-2.jpg\" alt></div>\r\n                                    <div class=\"blog__sidebar__recent__item__text\"><h6>Tips You To Balance<br> Nutrition Meal Day</h6>\r\n                                        <span>MAR 05, 2019</span></div></a>\r\n                                <a href=\"#\" class=\"blog__sidebar__recent__item\"><div class=\"blog__sidebar__recent__item__pic\"><img src=\"img/blog/sidebar/sr-3.jpg\" alt></div>\r\n                                    <div class=\"blog__sidebar__recent__item__text\"><h6>4 Principles Help You Lose <br>Weight With Vegetables</h6>\r\n                                        <span>MAR 05, 2019</span></div></a></div></div>\r\n                        <div class=\"blog__sidebar__item\"><h4>Search By</h4>\r\n                            <div class=\"blog__sidebar__item__tags\"><a href=\"#\">Apple</a>\r\n                                <a href=\"#\">Beauty</a>\r\n                                <a href=\"#\">Vegetables</a>\r\n                                <a href=\"#\">Fruit</a>\r\n                                <a href=\"#\">Healthy Food</a>\r\n                                <a href=\"#\">Lifestyle</a></div></div></div></div>\r\n                <div class=\"col-lg-8 col-md-7\"><div class=\"row\"><div class=\"col-lg-6 col-md-6 col-sm-6\"><div class=\"blog__item\"><div class=\"blog__item__pic\"><img src=\"img/blog/blog-2.jpg\" alt></div>\r\n                                <div class=\"blog__item__text\"><ul><li><i class=\"fa fa-calendar-o\"></i> May 4,2019</li>\r\n                                        <li><i class=\"fa fa-comment-o\"></i> 5</li></ul>\r\n                                    <h5><a href=\"#\">6 ways to prepare breakfast for 30</a></h5>\r\n                                    <p>\r\n                                        Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam\r\n                                        quaerat\r\n                                    </p>\r\n                                    <a href=\"#\" class=\"blog__btn\">READ MORE <span class=\"arrow_right\"></span></a></div></div></div>\r\n                        <div class=\"col-lg-6 col-md-6 col-sm-6\"><div class=\"blog__item\"><div class=\"blog__item__pic\"><img src=\"img/blog/blog-3.jpg\" alt></div>\r\n                                <div class=\"blog__item__text\"><ul><li><i class=\"fa fa-calendar-o\"></i> May 4,2019</li>\r\n                                        <li><i class=\"fa fa-comment-o\"></i> 5</li></ul>\r\n                                    <h5><a href=\"#\">Visit the clean farm in the US</a></h5>\r\n                                    <p>\r\n                                        Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam\r\n                                        quaerat\r\n                                    </p>\r\n                                    <a href=\"#\" class=\"blog__btn\">READ MORE <span class=\"arrow_right\"></span></a></div></div></div>\r\n                        <div class=\"col-lg-6 col-md-6 col-sm-6\"><div class=\"blog__item\"><div class=\"blog__item__pic\"><img src=\"img/blog/blog-1.jpg\" alt></div>\r\n                                <div class=\"blog__item__text\"><ul><li><i class=\"fa fa-calendar-o\"></i> May 4,2019</li>\r\n                                        <li><i class=\"fa fa-comment-o\"></i> 5</li></ul>\r\n                                    <h5><a href=\"#\">Cooking tips make cooking simple</a></h5>\r\n                                    <p>\r\n                                        Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam\r\n                                        quaerat\r\n                                    </p>\r\n                                    <a href=\"#\" class=\"blog__btn\">READ MORE <span class=\"arrow_right\"></span></a></div></div></div>\r\n                        <div class=\"col-lg-6 col-md-6 col-sm-6\"><div class=\"blog__item\"><div class=\"blog__item__pic\"><img src=\"img/blog/blog-4.jpg\" alt></div>\r\n                                <div class=\"blog__item__text\"><ul><li><i class=\"fa fa-calendar-o\"></i> May 4,2019</li>\r\n                                        <li><i class=\"fa fa-comment-o\"></i> 5</li></ul>\r\n                                    <h5><a href=\"#\">Cooking tips make cooking simple</a></h5>\r\n                                    <p>\r\n                                        Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam\r\n                                        quaerat\r\n                                    </p>\r\n                                    <a href=\"#\" class=\"blog__btn\">READ MORE <span class=\"arrow_right\"></span></a></div></div></div>\r\n                        <div class=\"col-lg-6 col-md-6 col-sm-6\"><div class=\"blog__item\"><div class=\"blog__item__pic\"><img src=\"img/blog/blog-4.jpg\" alt></div>\r\n                                <div class=\"blog__item__text\"><ul><li><i class=\"fa fa-calendar-o\"></i> May 4,2019</li>\r\n                                        <li><i class=\"fa fa-comment-o\"></i> 5</li></ul>\r\n                                    <h5><a href=\"#\">The Moment You Need To Remove Garlic From The Menu</a></h5>\r\n                                    <p>\r\n                                        Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam\r\n                                        quaerat\r\n                                    </p>\r\n                                    <a href=\"#\" class=\"blog__btn\">READ MORE <span class=\"arrow_right\"></span></a></div></div></div>\r\n                        <div class=\"col-lg-6 col-md-6 col-sm-6\"><div class=\"blog__item\"><div class=\"blog__item__pic\"><img src=\"img/blog/blog-6.jpg\" alt></div>\r\n                                <div class=\"blog__item__text\"><ul><li><i class=\"fa fa-calendar-o\"></i> May 4,2019</li>\r\n                                        <li><i class=\"fa fa-comment-o\"></i> 5</li></ul>\r\n                                    <h5><a href=\"#\">Cooking tips make cooking simple</a></h5>\r\n                                    <p>\r\n                                        Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam\r\n                                        quaerat\r\n                                    </p>\r\n                                    <a href=\"#\" class=\"blog__btn\">READ MORE <span class=\"arrow_right\"></span></a></div></div></div>\r\n                        <div class=\"col-lg-12\"><div class=\"product__pagination blog__pagination\"><a href=\"#\">1</a>\r\n                                <a href=\"#\">2</a>\r\n                                <a href=\"#\">3</a>\r\n                                <a href=\"#\"><i class=\"fa fa-long-arrow-right\"></i></a></div></div></div></div></div></div></section>\r\n    \r\n    \r\n    ");
            __builder.AddMarkupContent(6, "<footer class=\"footer spad\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-3 col-md-6 col-sm-6\"><div class=\"footer__about\"><div class=\"footer__about__logo\"><a href=\"./index.html\"><img src=\"img/logo.png\" alt></a></div>\r\n                        <ul><li>Address: 60-49 Road 11378 New York</li>\r\n                            <li>Phone: +65 11.188.888</li>\r\n                            <li>Email: hello@colorlib.com</li></ul></div></div>\r\n                <div class=\"col-lg-4 col-md-6 col-sm-6 offset-lg-1\"><div class=\"footer__widget\"><h6>Useful Links</h6>\r\n                        <ul><li><a href=\"#\">About Us</a></li>\r\n                            <li><a href=\"#\">About Our Shop</a></li>\r\n                            <li><a href=\"#\">Secure Shopping</a></li>\r\n                            <li><a href=\"#\">Delivery infomation</a></li>\r\n                            <li><a href=\"#\">Privacy Policy</a></li>\r\n                            <li><a href=\"#\">Our Sitemap</a></li></ul>\r\n                        <ul><li><a href=\"#\">Who We Are</a></li>\r\n                            <li><a href=\"#\">Our Services</a></li>\r\n                            <li><a href=\"#\">Projects</a></li>\r\n                            <li><a href=\"#\">Contact</a></li>\r\n                            <li><a href=\"#\">Innovation</a></li>\r\n                            <li><a href=\"#\">Testimonials</a></li></ul></div></div>\r\n                <div class=\"col-lg-4 col-md-12\"><div class=\"footer__widget\"><h6>Join Our Newsletter Now</h6>\r\n                        <p>Get E-mail updates about our latest shop and special offers.</p>\r\n                        <form action=\"#\"><input type=\"text\" placeholder=\"Enter your mail\">\r\n                            <button type=\"submit\" class=\"site-btn\">Subscribe</button></form>\r\n                        <div class=\"footer__widget__social\"><a href=\"#\"><i class=\"fa fa-facebook\"></i></a>\r\n                            <a href=\"#\"><i class=\"fa fa-instagram\"></i></a>\r\n                            <a href=\"#\"><i class=\"fa fa-twitter\"></i></a>\r\n                            <a href=\"#\"><i class=\"fa fa-pinterest\"></i></a></div></div></div></div>\r\n            <div class=\"row\"><div class=\"col-lg-12\"><div class=\"footer__copyright\"><div class=\"footer__copyright__text\"><p>\r\n                                Copyright &copy;\r\n                                document.write(new Date().getFullYear()); All rights reserved | This template is made with <i class=\"fa fa-heart\" aria-hidden=\"true\"></i> by <a href=\"https://colorlib.com\" target=\"_blank\">Colorlib</a></p></div>\r\n                        <div class=\"footer__copyright__payment\"><img src=\"img/payment-item.png\" alt></div></div></div></div></div></footer>\r\n    \r\n    <!-- Js Plugins\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
