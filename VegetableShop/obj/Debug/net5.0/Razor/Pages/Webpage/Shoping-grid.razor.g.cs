#pragma checksum "C:\Users\tgthuan\source\repos\VegetableShop\VegetableShop\Pages\Webpage\Shoping-grid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3df7ccc090889def6105dbab41395622794bd8ea"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Grid")]
    public partial class Shoping_grid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"preloder\"><div class=\"loader\"></div></div>\r\n\r\n\r\n<div class=\"humberger__menu__overlay\"></div>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"humberger__menu__wrapper\"><div class=\"humberger__menu__logo\"><a href=\"#\"><img src=\"img/logo.png\" alt></a></div>\r\n    <div class=\"humberger__menu__cart\"><ul><li><a href=\"#\"><i class=\"fa fa-heart\"></i> <span>1</span></a></li>\r\n            <li><a href=\"#\"><i class=\"fa fa-shopping-bag\"></i> <span>3</span></a></li></ul>\r\n        <div class=\"header__cart__price\">item: <span>$150.00</span></div></div>\r\n    <div class=\"humberger__menu__widget\"><div class=\"header__top__right__language\"><img src=\"img/language.png\" alt>\r\n            <div>English</div>\r\n            <span class=\"arrow_carrot-down\"></span>\r\n            <ul><li><a href=\"#\">Spanis</a></li>\r\n                <li><a href=\"#\">English</a></li></ul></div>\r\n        <div class=\"header__top__right__auth\"><a href=\"#\"><i class=\"fa fa-user\"></i> Login</a></div></div>\r\n    <nav class=\"humberger__menu__nav mobile-menu\"><ul><li class=\"active\"><a href=\"./index.html\">Home</a></li>\r\n            <li><a href=\"./shop-grid.html\">Shop</a></li>\r\n            <li><a href=\"#\">Pages</a>\r\n                <ul class=\"header__menu__dropdown\"><li><a href=\"./shop-details.html\">Shop Details</a></li>\r\n                    <li><a href=\"./shoping-cart.html\">Shoping Cart</a></li>\r\n                    <li><a href=\"./checkout.html\">Check Out</a></li>\r\n                    <li><a href=\"./blog-details.html\">Blog Details</a></li></ul></li>\r\n            <li><a href=\"./blog.html\">Blog</a></li>\r\n            <li><a href=\"./contact.html\">Contact</a></li></ul></nav>\r\n    <div id=\"mobile-menu-wrap\"></div>\r\n    <div class=\"header__top__right__social\"><a href=\"#\"><i class=\"fa fa-facebook\"></i></a>\r\n        <a href=\"#\"><i class=\"fa fa-twitter\"></i></a>\r\n        <a href=\"#\"><i class=\"fa fa-linkedin\"></i></a>\r\n        <a href=\"#\"><i class=\"fa fa-pinterest-p\"></i></a></div>\r\n    <div class=\"humberger__menu__contact\"><ul><li><i class=\"fa fa-envelope\"></i> hello@colorlib.com</li>\r\n            <li>Free Shipping for all Order of $99</li></ul></div></div>\r\n\r\n\r\n");
            __builder.AddMarkupContent(2, "<header class=\"header\"><div class=\"header__top\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-6\"><div class=\"header__top__left\"><ul><li><i class=\"fa fa-envelope\"></i> hello@colorlib.com</li>\r\n                            <li>Free Shipping for all Order of $99</li></ul></div></div>\r\n                <div class=\"col-lg-6\"><div class=\"header__top__right\"><div class=\"header__top__right__social\"><a href=\"#\"><i class=\"fa fa-facebook\"></i></a>\r\n                            <a href=\"#\"><i class=\"fa fa-twitter\"></i></a>\r\n                            <a href=\"#\"><i class=\"fa fa-linkedin\"></i></a>\r\n                            <a href=\"#\"><i class=\"fa fa-pinterest-p\"></i></a></div>\r\n                        <div class=\"header__top__right__language\"><img src=\"img/language.png\" alt>\r\n                            <div>English</div>\r\n                            <span class=\"arrow_carrot-down\"></span>\r\n                            <ul><li><a href=\"#\">Spanis</a></li>\r\n                                <li><a href=\"#\">English</a></li></ul></div>\r\n                        <div class=\"header__top__right__auth\"><a href=\"#\"><i class=\"fa fa-user\"></i> Login</a></div></div></div></div></div></div>\r\n    <div class=\"container\"><div class=\"row\"><div class=\"col-lg-3\"><div class=\"header__logo\"><a href=\"./index.html\"><img src=\"img/logo.png\" alt></a></div></div>\r\n            <div class=\"col-lg-6\"><nav class=\"header__menu\"><ul><li><a href=\"./index.html\">Home</a></li>\r\n                        <li class=\"active\"><a href=\"./shop-grid.html\">Shop</a></li>\r\n                        <li><a href=\"#\">Pages</a>\r\n                            <ul class=\"header__menu__dropdown\"><li><a href=\"./shop-details.html\">Shop Details</a></li>\r\n                                <li><a href=\"./shoping-cart.html\">Shoping Cart</a></li>\r\n                                <li><a href=\"./checkout.html\">Check Out</a></li>\r\n                                <li><a href=\"./blog-details.html\">Blog Details</a></li></ul></li>\r\n                        <li><a href=\"./blog.html\">Blog</a></li>\r\n                        <li><a href=\"./contact.html\">Contact</a></li></ul></nav></div>\r\n            <div class=\"col-lg-3\"><div class=\"header__cart\"><ul><li><a href=\"#\"><i class=\"fa fa-heart\"></i> <span>1</span></a></li>\r\n                        <li><a href=\"#\"><i class=\"fa fa-shopping-bag\"></i> <span>3</span></a></li></ul>\r\n                    <div class=\"header__cart__price\">item: <span>$150.00</span></div></div></div></div>\r\n        <div class=\"humberger__open\"><i class=\"fa fa-bars\"></i></div></div></header>\r\n\r\n\r\n");
            __builder.AddMarkupContent(3, "<section class=\"hero hero-normal\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-3\"><div class=\"hero__categories\"><div class=\"hero__categories__all\"><i class=\"fa fa-bars\"></i>\r\n                        <span>All departments</span></div>\r\n                    <ul><li><a href=\"#\">Fresh Meat</a></li>\r\n                        <li><a href=\"#\">Vegetables</a></li>\r\n                        <li><a href=\"#\">Fruit & Nut Gifts</a></li>\r\n                        <li><a href=\"#\">Fresh Berries</a></li>\r\n                        <li><a href=\"#\">Ocean Foods</a></li>\r\n                        <li><a href=\"#\">Butter & Eggs</a></li>\r\n                        <li><a href=\"#\">Fastfood</a></li>\r\n                        <li><a href=\"#\">Fresh Onion</a></li>\r\n                        <li><a href=\"#\">Papayaya & Crisps</a></li>\r\n                        <li><a href=\"#\">Oatmeal</a></li>\r\n                        <li><a href=\"#\">Fresh Bananas</a></li></ul></div></div>\r\n            <div class=\"col-lg-9\"><div class=\"hero__search\"><div class=\"hero__search__form\"><form action=\"#\"><div class=\"hero__search__categories\">\r\n                                All Categories\r\n                                <span class=\"arrow_carrot-down\"></span></div>\r\n                            <input type=\"text\" placeholder=\"What do yo u need?\">\r\n                            <button type=\"submit\" class=\"site-btn\">SEARCH</button></form></div>\r\n                    <div class=\"hero__search__phone\"><div class=\"hero__search__phone__icon\"><i class=\"fa fa-phone\"></i></div>\r\n                        <div class=\"hero__search__phone__text\"><h5>+65 11.188.888</h5>\r\n                            <span>support 24/7 time</span></div></div></div></div></div></div></section>\r\n\r\n\r\n");
            __builder.AddMarkupContent(4, @"<section class=""breadcrumb-section set-bg"" data-setbg=""img/breadcrumb.jpg""><div class=""container""><div class=""row""><div class=""col-lg-12 text-center""><div class=""breadcrumb__text""><h2>Organi Shop</h2>
                    <div class=""breadcrumb__option""><a href=""./index.html"">Home</a>
                        <span>Shop</span></div></div></div></div></div></section>


");
            __builder.OpenElement(5, "section");
            __builder.AddAttribute(6, "class", "product spad");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "<div class=\"col-lg-3 col-md-5\"><div class=\"sidebar\"><div class=\"sidebar__item\"><h4>Department</h4>\r\n                        <ul><li><a href=\"#\">Fresh Meat</a></li>\r\n                            <li><a href=\"#\">Vegetables</a></li>\r\n                            <li><a href=\"#\">Fruit & Nut Gifts</a></li>\r\n                            <li><a href=\"#\">Fresh Berries</a></li>\r\n                            <li><a href=\"#\">Ocean Foods</a></li>\r\n                            <li><a href=\"#\">Butter & Eggs</a></li>\r\n                            <li><a href=\"#\">Fastfood</a></li>\r\n                            <li><a href=\"#\">Fresh Onion</a></li>\r\n                            <li><a href=\"#\">Papayaya & Crisps</a></li>\r\n                            <li><a href=\"#\">Oatmeal</a></li></ul></div>\r\n                    <div class=\"sidebar__item\"><h4>Price</h4>\r\n                        <div class=\"price-range-wrap\"><div class=\"price-range ui-slider ui-corner-all ui-slider-horizontal ui-widget ui-widget-content\" data-min=\"10\" data-max=\"540\"><div class=\"ui-slider-range ui-corner-all ui-widget-header\"></div>\r\n                                <span tabindex=\"0\" class=\"ui-slider-handle ui-corner-all ui-state-default\"></span>\r\n                                <span tabindex=\"0\" class=\"ui-slider-handle ui-corner-all ui-state-default\"></span></div>\r\n                            <div class=\"range-slider\"><div class=\"price-input\"><input type=\"text\" id=\"minamount\">\r\n                                    <input type=\"text\" id=\"maxamount\"></div></div></div></div>\r\n                    <div class=\"sidebar__item sidebar__item__color--option\"><h4>Colors</h4>\r\n                        <div class=\"sidebar__item__color sidebar__item__color--white\"><label for=\"white\">\r\n                                White\r\n                                <input type=\"radio\" id=\"white\"></label></div>\r\n                        <div class=\"sidebar__item__color sidebar__item__color--gray\"><label for=\"gray\">\r\n                                Gray\r\n                                <input type=\"radio\" id=\"gray\"></label></div>\r\n                        <div class=\"sidebar__item__color sidebar__item__color--red\"><label for=\"red\">\r\n                                Red\r\n                                <input type=\"radio\" id=\"red\"></label></div>\r\n                        <div class=\"sidebar__item__color sidebar__item__color--black\"><label for=\"black\">\r\n                                Black\r\n                                <input type=\"radio\" id=\"black\"></label></div>\r\n                        <div class=\"sidebar__item__color sidebar__item__color--blue\"><label for=\"blue\">\r\n                                Blue\r\n                                <input type=\"radio\" id=\"blue\"></label></div>\r\n                        <div class=\"sidebar__item__color sidebar__item__color--green\"><label for=\"green\">\r\n                                Green\r\n                                <input type=\"radio\" id=\"green\"></label></div></div>\r\n                    <div class=\"sidebar__item\"><h4>Popular Size</h4>\r\n                        <div class=\"sidebar__item__size\"><label for=\"large\">\r\n                                Large\r\n                                <input type=\"radio\" id=\"large\"></label></div>\r\n                        <div class=\"sidebar__item__size\"><label for=\"medium\">\r\n                                Medium\r\n                                <input type=\"radio\" id=\"medium\"></label></div>\r\n                        <div class=\"sidebar__item__size\"><label for=\"small\">\r\n                                Small\r\n                                <input type=\"radio\" id=\"small\"></label></div>\r\n                        <div class=\"sidebar__item__size\"><label for=\"tiny\">\r\n                                Tiny\r\n                                <input type=\"radio\" id=\"tiny\"></label></div></div>\r\n                    <div class=\"sidebar__item\"><div class=\"latest-product__text\"><h4>Latest Products</h4>\r\n                            <div class=\"latest-product__slider owl-carousel\"><div class=\"latest-prdouct__slider__item\"><a href=\"#\" class=\"latest-product__item\"><div class=\"latest-product__item__pic\"><img src=\"img/latest-product/lp-1.jpg\" alt></div>\r\n                                        <div class=\"latest-product__item__text\"><h6>Crab Pool Security</h6>\r\n                                            <span>$30.00</span></div></a>\r\n                                    <a href=\"#\" class=\"latest-product__item\"><div class=\"latest-product__item__pic\"><img src=\"img/latest-product/lp-2.jpg\" alt></div>\r\n                                        <div class=\"latest-product__item__text\"><h6>Crab Pool Security</h6>\r\n                                            <span>$30.00</span></div></a>\r\n                                    <a href=\"#\" class=\"latest-product__item\"><div class=\"latest-product__item__pic\"><img src=\"img/latest-product/lp-3.jpg\" alt></div>\r\n                                        <div class=\"latest-product__item__text\"><h6>Crab Pool Security</h6>\r\n                                            <span>$30.00</span></div></a></div>\r\n                                <div class=\"latest-prdouct__slider__item\"><a href=\"#\" class=\"latest-product__item\"><div class=\"latest-product__item__pic\"><img src=\"img/latest-product/lp-1.jpg\" alt></div>\r\n                                        <div class=\"latest-product__item__text\"><h6>Crab Pool Security</h6>\r\n                                            <span>$30.00</span></div></a>\r\n                                    <a href=\"#\" class=\"latest-product__item\"><div class=\"latest-product__item__pic\"><img src=\"img/latest-product/lp-2.jpg\" alt></div>\r\n                                        <div class=\"latest-product__item__text\"><h6>Crab Pool Security</h6>\r\n                                            <span>$30.00</span></div></a>\r\n                                    <a href=\"#\" class=\"latest-product__item\"><div class=\"latest-product__item__pic\"><img src=\"img/latest-product/lp-3.jpg\" alt></div>\r\n                                        <div class=\"latest-product__item__text\"><h6>Crab Pool Security</h6>\r\n                                            <span>$30.00</span></div></a></div></div></div></div></div></div>\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-lg-9 col-md-7");
            __builder.AddMarkupContent(14, "<div class=\"product__discount\"><div class=\"section-title product__discount__title\"><h2>Sale Off</h2></div>\r\n                    <div class=\"row\"><div class=\"product__discount__slider owl-carousel\"><div class=\"col-lg-4\"><div class=\"product__discount__item\"><div class=\"product__discount__item__pic set-bg\" data-setbg=\"img/product/discount/pd-1.jpg\"><div class=\"product__discount__percent\">-20%</div>\r\n                                        <ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                            <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                            <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                                    <div class=\"product__discount__item__text\"><span>Dried Fruit</span>\r\n                                        <h5><a href=\"#\">Raisin’n’nuts</a></h5>\r\n                                        <div class=\"product__item__price\">$30.00 <span>$36.00</span></div></div></div></div>\r\n                            <div class=\"col-lg-4\"><div class=\"product__discount__item\"><div class=\"product__discount__item__pic set-bg\" data-setbg=\"img/product/discount/pd-2.jpg\"><div class=\"product__discount__percent\">-20%</div>\r\n                                        <ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                            <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                            <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                                    <div class=\"product__discount__item__text\"><span>Vegetables</span>\r\n                                        <h5><a href=\"#\">Vegetables’package</a></h5>\r\n                                        <div class=\"product__item__price\">$30.00 <span>$36.00</span></div></div></div></div>\r\n                            <div class=\"col-lg-4\"><div class=\"product__discount__item\"><div class=\"product__discount__item__pic set-bg\" data-setbg=\"img/product/discount/pd-3.jpg\"><div class=\"product__discount__percent\">-20%</div>\r\n                                        <ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                            <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                            <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                                    <div class=\"product__discount__item__text\"><span>Dried Fruit</span>\r\n                                        <h5><a href=\"#\">Mixed Fruitss</a></h5>\r\n                                        <div class=\"product__item__price\">$30.00 <span>$36.00</span></div></div></div></div>\r\n                            <div class=\"col-lg-4\"><div class=\"product__discount__item\"><div class=\"product__discount__item__pic set-bg\" data-setbg=\"img/product/discount/pd-4.jpg\"><div class=\"product__discount__percent\">-20%</div>\r\n                                        <ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                            <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                            <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                                    <div class=\"product__discount__item__text\"><span>Dried Fruit</span>\r\n                                        <h5><a href=\"#\">Raisin’n’nuts</a></h5>\r\n                                        <div class=\"product__item__price\">$30.00 <span>$36.00</span></div></div></div></div>\r\n                            <div class=\"col-lg-4\"><div class=\"product__discount__item\"><div class=\"product__discount__item__pic set-bg\" data-setbg=\"img/product/discount/pd-5.jpg\"><div class=\"product__discount__percent\">-20%</div>\r\n                                        <ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                            <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                            <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                                    <div class=\"product__discount__item__text\"><span>Dried Fruit</span>\r\n                                        <h5><a href=\"#\">Raisin’n’nuts</a></h5>\r\n                                        <div class=\"product__item__price\">$30.00 <span>$36.00</span></div></div></div></div>\r\n                            <div class=\"col-lg-4\"><div class=\"product__discount__item\"><div class=\"product__discount__item__pic set-bg\" data-setbg=\"img/product/discount/pd-6.jpg\"><div class=\"product__discount__percent\">-20%</div>\r\n                                        <ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                            <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                            <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                                    <div class=\"product__discount__item__text\"><span>Dried Fruit</span>\r\n                                        <h5><a href=\"#\">Raisin’n’nuts</a></h5>\r\n                                        <div class=\"product__item__price\">$30.00 <span>$36.00</span></div></div></div></div></div></div></div>\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "filter__item");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "row");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-lg-4 col-md-5");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "filter__sort");
            __builder.AddMarkupContent(23, "<span>Sort By</span>\r\n                                ");
            __builder.OpenElement(24, "select");
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", "0");
            __builder.AddContent(27, "Default");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                    ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", "0");
            __builder.AddContent(31, "Default");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.AddMarkupContent(33, "<div class=\"col-lg-4 col-md-4\"><div class=\"filter__found\"><h6><span>16</span> Products found</h6></div></div>\r\n                        ");
            __builder.AddMarkupContent(34, "<div class=\"col-lg-4 col-md-3\"><div class=\"filter__option\"><span class=\"icon_grid-2x2\"></span>\r\n                                <span class=\"icon_ul\"></span></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.AddMarkupContent(36, "<div class=\"row\"><div class=\"col-lg-4 col-md-6 col-sm-6\"><div class=\"product__item\"><div class=\"product__item__pic set-bg\" data-setbg=\"img/product/product-1.jpg\"><ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                            <div class=\"product__item__text\"><h6><a href=\"#\">Crab Pool Security</a></h6>\r\n                                <h5>$30.00</h5></div></div></div>\r\n                    <div class=\"col-lg-4 col-md-6 col-sm-6\"><div class=\"product__item\"><div class=\"product__item__pic set-bg\" data-setbg=\"img/product/product-2.jpg\"><ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                            <div class=\"product__item__text\"><h6><a href=\"#\">Crab Pool Security</a></h6>\r\n                                <h5>$30.00</h5></div></div></div>\r\n                    <div class=\"col-lg-4 col-md-6 col-sm-6\"><div class=\"product__item\"><div class=\"product__item__pic set-bg\" data-setbg=\"img/product/product-3.jpg\"><ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                            <div class=\"product__item__text\"><h6><a href=\"#\">Crab Pool Security</a></h6>\r\n                                <h5>$30.00</h5></div></div></div>\r\n                    <div class=\"col-lg-4 col-md-6 col-sm-6\"><div class=\"product__item\"><div class=\"product__item__pic set-bg\" data-setbg=\"img/product/product-4.jpg\"><ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                            <div class=\"product__item__text\"><h6><a href=\"#\">Crab Pool Security</a></h6>\r\n                                <h5>$30.00</h5></div></div></div>\r\n                    <div class=\"col-lg-4 col-md-6 col-sm-6\"><div class=\"product__item\"><div class=\"product__item__pic set-bg\" data-setbg=\"img/product/product-5.jpg\"><ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                            <div class=\"product__item__text\"><h6><a href=\"#\">Crab Pool Security</a></h6>\r\n                                <h5>$30.00</h5></div></div></div>\r\n                    <div class=\"col-lg-4 col-md-6 col-sm-6\"><div class=\"product__item\"><div class=\"product__item__pic set-bg\" data-setbg=\"img/product/product-6.jpg\"><ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                            <div class=\"product__item__text\"><h6><a href=\"#\">Crab Pool Security</a></h6>\r\n                                <h5>$30.00</h5></div></div></div>\r\n                    <div class=\"col-lg-4 col-md-6 col-sm-6\"><div class=\"product__item\"><div class=\"product__item__pic set-bg\" data-setbg=\"img/product/product-7.jpg\"><ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                            <div class=\"product__item__text\"><h6><a href=\"#\">Crab Pool Security</a></h6>\r\n                                <h5>$30.00</h5></div></div></div>\r\n                    <div class=\"col-lg-4 col-md-6 col-sm-6\"><div class=\"product__item\"><div class=\"product__item__pic set-bg\" data-setbg=\"img/product/product-8.jpg\"><ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                            <div class=\"product__item__text\"><h6><a href=\"#\">Crab Pool Security</a></h6>\r\n                                <h5>$30.00</h5></div></div></div>\r\n                    <div class=\"col-lg-4 col-md-6 col-sm-6\"><div class=\"product__item\"><div class=\"product__item__pic set-bg\" data-setbg=\"img/product/product-9.jpg\"><ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                            <div class=\"product__item__text\"><h6><a href=\"#\">Crab Pool Security</a></h6>\r\n                                <h5>$30.00</h5></div></div></div>\r\n                    <div class=\"col-lg-4 col-md-6 col-sm-6\"><div class=\"product__item\"><div class=\"product__item__pic set-bg\" data-setbg=\"img/product/product-10.jpg\"><ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                            <div class=\"product__item__text\"><h6><a href=\"#\">Crab Pool Security</a></h6>\r\n                                <h5>$30.00</h5></div></div></div>\r\n                    <div class=\"col-lg-4 col-md-6 col-sm-6\"><div class=\"product__item\"><div class=\"product__item__pic set-bg\" data-setbg=\"img/product/product-11.jpg\"><ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                            <div class=\"product__item__text\"><h6><a href=\"#\">Crab Pool Security</a></h6>\r\n                                <h5>$30.00</h5></div></div></div>\r\n                    <div class=\"col-lg-4 col-md-6 col-sm-6\"><div class=\"product__item\"><div class=\"product__item__pic set-bg\" data-setbg=\"img/product/product-12.jpg\"><ul class=\"product__item__pic__hover\"><li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                                    <li><a href=\"#\"><i class=\"fa fa-shopping-cart\"></i></a></li></ul></div>\r\n                            <div class=\"product__item__text\"><h6><a href=\"#\">Crab Pool Security</a></h6>\r\n                                <h5>$30.00</h5></div></div></div></div>\r\n                ");
            __builder.AddMarkupContent(37, "<div class=\"product__pagination\"><a href=\"#\">1</a>\r\n                    <a href=\"#\">2</a>\r\n                    <a href=\"#\">3</a>\r\n                    <a href=\"#\"><i class=\"fa fa-long-arrow-right\"></i></a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(39, "<footer class=\"footer spad\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-3 col-md-6 col-sm-6\"><div class=\"footer__about\"><div class=\"footer__about__logo\"><a href=\"./index.html\"><img src=\"img/logo.png\" alt></a></div>\r\n                    <ul><li>Address: 60-49 Road 11378 New York</li>\r\n                        <li>Phone: +65 11.188.888</li>\r\n                        <li>Email: hello@colorlib.com</li></ul></div></div>\r\n            <div class=\"col-lg-4 col-md-6 col-sm-6 offset-lg-1\"><div class=\"footer__widget\"><h6>Useful Links</h6>\r\n                    <ul><li><a href=\"#\">About Us</a></li>\r\n                        <li><a href=\"#\">About Our Shop</a></li>\r\n                        <li><a href=\"#\">Secure Shopping</a></li>\r\n                        <li><a href=\"#\">Delivery infomation</a></li>\r\n                        <li><a href=\"#\">Privacy Policy</a></li>\r\n                        <li><a href=\"#\">Our Sitemap</a></li></ul>\r\n                    <ul><li><a href=\"#\">Who We Are</a></li>\r\n                        <li><a href=\"#\">Our Services</a></li>\r\n                        <li><a href=\"#\">Projects</a></li>\r\n                        <li><a href=\"#\">Contact</a></li>\r\n                        <li><a href=\"#\">Innovation</a></li>\r\n                        <li><a href=\"#\">Testimonials</a></li></ul></div></div>\r\n            <div class=\"col-lg-4 col-md-12\"><div class=\"footer__widget\"><h6>Join Our Newsletter Now</h6>\r\n                    <p>Get E-mail updates about our latest shop and special offers.</p>\r\n                    <form action=\"#\"><input type=\"text\" placeholder=\"Enter your mail\">\r\n                        <button type=\"submit\" class=\"site-btn\">Subscribe</button></form>\r\n                    <div class=\"footer__widget__social\"><a href=\"#\"><i class=\"fa fa-facebook\"></i></a>\r\n                        <a href=\"#\"><i class=\"fa fa-instagram\"></i></a>\r\n                        <a href=\"#\"><i class=\"fa fa-twitter\"></i></a>\r\n                        <a href=\"#\"><i class=\"fa fa-pinterest\"></i></a></div></div></div></div>\r\n        <div class=\"row\"><div class=\"col-lg-12\"><div class=\"footer__copyright\"><div class=\"footer__copyright__text\"><p>\r\n                            Copyright &copy;\r\n                            All rights reserved | This template is made with <i class=\"fa fa-heart\" aria-hidden=\"true\"></i> by <a href=\"https://colorlib.com\" target=\"_blank\">Colorlib</a></p></div>\r\n                    <div class=\"footer__copyright__payment\"><img src=\"img/payment-item.png\" alt></div></div></div></div></div></footer>\r\n\r\n<!-- Js Plugins\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591