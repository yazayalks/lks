#pragma checksum "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8922b52e03ba8d4a448b2494e02b9428017f1d0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Documents\GitHub\lks\lks\Views\_ViewImports.cshtml"
using lks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\lks\lks\Views\_ViewImports.cshtml"
using lks.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
using lks.DbContexts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
using lks.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8922b52e03ba8d4a448b2494e02b9428017f1d0f", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea84aa7af47ba1e0b2ded2c206f2de0becce4099", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"ru\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8922b52e03ba8d4a448b2494e02b9428017f1d0f4626", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\"/>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"/>\r\n    <title>");
#nullable restore
#line 9 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <!--Подключаем шрифты-->\r\n    <link rel=\"preconnect\" href=\"https://fonts.gstatic.com\">\r\n    <link href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\">\r\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8922b52e03ba8d4a448b2494e02b9428017f1d0f5495", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8922b52e03ba8d4a448b2494e02b9428017f1d0f7377", async() => {
                WriteLiteral(@"
<!--sprite-vk-->
<svg style=""display: none;"">
    <symbol id=""vk"" viewBox=""0 0 24 24"">
        <g>
            <path d=""m12.145 19.5c3.472 0 2.234-2.198 2.502-2.83-.004-.472-.008-.926.008-1.202.22.062.739.325 1.811 1.367 1.655 1.67 2.078 2.665 3.415 2.665h2.461c.78 0 1.186-.323 1.389-.594.196-.262.388-.722.178-1.438-.549-1.724-3.751-4.701-3.95-5.015.03-.058.078-.135.103-.175h-.002c.632-.835 3.044-4.449 3.399-5.895.001-.002.002-.005.002-.008.192-.66.016-1.088-.166-1.33-.274-.362-.71-.545-1.299-.545h-2.461c-.824 0-1.449.415-1.765 1.172-.529 1.345-2.015 4.111-3.129 5.09-.034-1.387-.011-2.446.007-3.233.036-1.535.152-3.029-1.441-3.029h-3.868c-.998 0-1.953 1.09-.919 2.384.904 1.134.325 1.766.52 4.912-.76-.815-2.112-3.016-3.068-5.829-.268-.761-.674-1.466-1.817-1.466h-2.461c-.998 0-1.594.544-1.594 1.455 0 2.046 4.529 13.544 12.145 13.544zm-8.09-13.499c.217 0 .239 0 .4.457.979 2.883 3.175 7.149 4.779 7.149 1.205 0 1.205-1.235 1.205-1.7l-.001-3.702c-.066-1.225-.512-1.835-.805-2.205l3.508.004c.002.017-.02 4.095.01");
                WriteLiteral(@" 5.083 0 1.403 1.114 2.207 2.853.447 1.835-2.071 3.104-5.167 3.155-5.293.075-.18.14-.241.376-.241h2.461.01c-.001.003-.001.006-.002.009-.225 1.05-2.446 4.396-3.189 5.435-.012.016-.023.033-.034.05-.327.534-.593 1.124.045 1.954h.001c.058.07.209.234.429.462.684.706 3.03 3.12 3.238 4.08-.138.022-.288.006-2.613.011-.495 0-.882-.74-2.359-2.23-1.328-1.292-2.19-1.82-2.975-1.82-1.524 0-1.413 1.237-1.399 2.733.005 1.622-.005 1.109.006 1.211-.089.035-.344.105-1.009.105-6.345 0-10.477-10.071-10.636-11.996.055-.005.812-.002 2.546-.003z""/>
        </g>
    </symbol>
</svg>
<!--sprite-instagram-->
<svg style=""display: none;"">
    <symbol id=""instagram"" viewBox=""0 0 511 511.9"">
        <g>
            <path d=""m510.949219 150.5c-1.199219-27.199219-5.597657-45.898438-11.898438-62.101562-6.5-17.199219-16.5-32.597657-29.601562-45.398438-12.800781-13-28.300781-23.101562-45.300781-29.5-16.296876-6.300781-34.898438-10.699219-62.097657-11.898438-27.402343-1.300781-36.101562-1.601562-105.601562-1.601562s-78.199219.300781-105.");
                WriteLiteral(@"5 1.5c-27.199219 1.199219-45.898438 5.601562-62.097657 11.898438-17.203124 6.5-32.601562 16.5-45.402343 29.601562-13 12.800781-23.097657 28.300781-29.5 45.300781-6.300781 16.300781-10.699219 34.898438-11.898438 62.097657-1.300781 27.402343-1.601562 36.101562-1.601562 105.601562s.300781 78.199219 1.5 105.5c1.199219 27.199219 5.601562 45.898438 11.902343 62.101562 6.5 17.199219 16.597657 32.597657 29.597657 45.398438 12.800781 13 28.300781 23.101562 45.300781 29.5 16.300781 6.300781 34.898438 10.699219 62.101562 11.898438 27.296876 1.203124 36 1.5 105.5 1.5s78.199219-.296876 105.5-1.5c27.199219-1.199219 45.898438-5.597657 62.097657-11.898438 34.402343-13.300781 61.601562-40.5 74.902343-74.898438 6.296876-16.300781 10.699219-34.902343 11.898438-62.101562 1.199219-27.300781 1.5-36 1.5-105.5s-.101562-78.199219-1.300781-105.5zm-46.097657 209c-1.101562 25-5.300781 38.5-8.800781 47.5-8.601562 22.300781-26.300781 40-48.601562 48.601562-9 3.5-22.597657 7.699219-47.5 8.796876-27 1.203124-35.097657 1.5-103.398438 1.5s-76");
                WriteLiteral(@".5-.296876-103.402343-1.5c-25-1.097657-38.5-5.296876-47.5-8.796876-11.097657-4.101562-21.199219-10.601562-29.398438-19.101562-8.5-8.300781-15-18.300781-19.101562-29.398438-3.5-9-7.699219-22.601562-8.796876-47.5-1.203124-27-1.5-35.101562-1.5-103.402343s.296876-76.5 1.5-103.398438c1.097657-25 5.296876-38.5 8.796876-47.5 4.101562-11.101562 10.601562-21.199219 19.203124-29.402343 8.296876-8.5 18.296876-15 29.398438-19.097657 9-3.5 22.601562-7.699219 47.5-8.800781 27-1.199219 35.101562-1.5 103.398438-1.5 68.402343 0 76.5.300781 103.402343 1.5 25 1.101562 38.5 5.300781 47.5 8.800781 11.097657 4.097657 21.199219 10.597657 29.398438 19.097657 8.5 8.300781 15 18.300781 19.101562 29.402343 3.5 9 7.699219 22.597657 8.800781 47.5 1.199219 27 1.5 35.097657 1.5 103.398438s-.300781 76.300781-1.5 103.300781zm0 0""/>
            <path d=""m256.449219 124.5c-72.597657 0-131.5 58.898438-131.5 131.5s58.902343 131.5 131.5 131.5c72.601562 0 131.5-58.898438 131.5-131.5s-58.898438-131.5-131.5-131.5zm0 216.800781c-47.097657 0-85.30078");
                WriteLiteral(@"1-38.199219-85.300781-85.300781s38.203124-85.300781 85.300781-85.300781c47.101562 0 85.300781 38.199219 85.300781 85.300781s-38.199219 85.300781-85.300781 85.300781zm0 0""/>
            <path d=""m423.851562 119.300781c0 16.953125-13.746093 30.699219-30.703124 30.699219-16.953126 0-30.699219-13.746094-30.699219-30.699219 0-16.957031 13.746093-30.699219 30.699219-30.699219 16.957031 0 30.703124 13.742188 30.703124 30.699219zm0 0""/>
        </g>
    </symbol>
</svg>
<!--sprite-ask-->
<svg style=""display: none;"">
    <symbol id=""ask"" viewBox=""0 0 129.36 129.36"">
        <g>
            <path d=""M120.103,2.935C118.683,1.084,116.485,0,114.152,0H73.727C47.835,0,20.172,27.558,10.748,62.737
	c-5.668,21.148-3.319,41.245,6.283,53.761c6.363,8.293,15.618,12.86,26.061,12.86c11.862,0,24.097-5.785,34.781-15.44l-1.607,5.999
	c-1.072,4.001,1.302,8.114,5.303,9.185c0.65,0.175,1.304,0.258,1.946,0.258c3.312,0,6.342-2.21,7.239-5.561l15.221-56.802
	c0.034-0.126,0.067-0.251,0.102-0.377c0.01-0.036,0.02-0.072,0.028-0.108l15.");
                WriteLiteral(@"292-57.071C122,7.188,121.522,4.784,120.103,2.935z
	 M91.496,63.077c-7.591,27.832-29.695,51.281-48.404,51.281c-5.836,0-10.6-2.353-14.159-6.991
	c-6.783-8.841-8.165-24.073-3.696-40.748C32.733,38.639,54.938,15,73.727,15h30.651L91.496,63.077z""/>
        </g>
    </symbol>
</svg>

<!--header-->
<header class=""header"">
    <div class=""container"">
        <div class=""header__inner"">
            <div class=""header__logo"">
                <img src=""/images/logo.png"">
            </div>

            <nav class=""nav"">
                <a class=""nav__link"" href=""/home"">Главная</a>
                <a class=""nav__link"" href=""/works"">Галлерея работ</a>
                <a class=""nav__link"" href=""/hobby"">Хобби</a>
                <a class=""nav__link"" href=""/contacts"">Контакты</a>
");
#nullable restore
#line 62 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
                 if (!User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a class=\"nav__link\" href=\"/authorization\">Вход</a>\r\n");
#nullable restore
#line 65 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a class=\"nav__link\" href=\"/authorization/Logout\">Выход</a>\r\n");
#nullable restore
#line 69 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </nav>\r\n        </div>\r\n    </div>\r\n</header>\r\n\r\n\r\n");
#nullable restore
#line 77 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n<!--comments-->\r\n<div id=\"AllComments\">\r\n");
#nullable restore
#line 82 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
     if (ViewData["Comments"] != null)
    {
        User user = null;
        if (User.Identity.IsAuthenticated)
        {
            user = DbHelper.dbContext.Users.Single(i => i.Email == User.Identity.Name);
        }
    
        foreach (var item in ((IEnumerable<Comment>) ViewData["Comments"]).Reverse())
        {
            var img = item.User.Photo == null ? "images/NoPhoto.png" : $"data:image/jpg;base64,{Convert.ToBase64String(item.User.Photo)}";

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"container\">\r\n                <div class=\"commentView\">\r\n                    <div class=\"commentInfo\">\r\n                        <div class=\"comment__userName\">");
#nullable restore
#line 96 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
                                                  Write(item.User.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"comment__data\">");
#nullable restore
#line 97 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
                                              Write(item.CreateDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"comment__del\">\r\n                            <li>\r\n");
#nullable restore
#line 100 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
                                 if (user != null)
                                {
                                    if (user.TypeId == 2 || user.Id == item.UserId)
                                    {
                                        var url = "/Comment?id=" + item.Id +"&page="+Context.Request.Path.ToString().Substring(1);

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <a");
                BeginWriteAttribute("href", " href=", 8255, "", 8265, 1);
#nullable restore
#line 105 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8261, url, 8261, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            <i class=\"fa fa-times-circle-o\"></i>\r\n                                        </a>\r\n");
#nullable restore
#line 108 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </li>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"img\">\r\n                        <div class=\"inner\">\r\n                            <img width=\"100\" height=\"100\"");
                BeginWriteAttribute("src", " src=", 8706, "", 8715, 1);
#nullable restore
#line 115 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8711, img, 8711, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 8715, "\"", 8721, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                    <circle cx=\"50\" cy=\"50\" r=\"50\" fill=\"img\"></circle>\r\n                    <p>");
#nullable restore
#line 119 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
                  Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 122 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>


<!--footer-->
<footer class=""footer"">
    <div class=""container"">
        <div class=""footer__inner"">
            <!--footer__block-1-->
            <div class=""footer__block"">
                <h4 class=""footer__title"">Местоположение</h4>
                <address class=""footer__text"">Россия, г. Новосибирск</address>
            </div>
            <!--footer__block-2-->
            <div class=""footer__block"">
                <h4 class=""footer__title"">Контакты</h4>
                <div class=""social"">
                    <!--social__item-vk-->
                    <a class=""social__item"" href=""https://vk.com/ya_za_ya"" target=""_blank"">
                        <svg class=""social__icon"">
                            <use xlink:href=""#vk""></use>
                        </svg>
                    </a>
                    <!--social__instagram-->
                    <a class=""social__item"" href=""https://www.instagram.com/___ya_za_ya___/"" target=""_blank"">
                        <svg cla");
                WriteLiteral(@"ss=""social__icon"">
                            <use xlink:href=""#instagram""></use>
                        </svg>
                    </a>
                    <!--social__ask-->
                    <a class=""social__item"" href=""https://ask.fm/KILLER7000LKS"" target=""_blank"">
                        <svg class=""social__icon"">
                            <use xlink:href=""#ask""></use>
                        </svg>
                    </a>
                </div>

            </div>
            <!--footer__block-3-->
            <div class=""footer__block"">
                <h4 class=""footer__title"">Нанана</h4>
                <address class=""footer__text"">Опаньки</address>
            </div>
        </div>
    </div>
</footer>


");
#nullable restore
#line 171 "C:\Users\User\Documents\GitHub\lks\lks\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
