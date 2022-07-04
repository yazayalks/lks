#pragma checksum "C:\Users\User\Documents\GitHub\lks\lks\Views\FireSafetySystemForBath\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3940e39e81f48f7ac848bf167cf74452494e4e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FireSafetySystemForBath_Index), @"mvc.1.0.view", @"/Views/FireSafetySystemForBath/Index.cshtml")]
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
#line 1 "C:\Users\User\Documents\GitHub\lks\lks\Views\FireSafetySystemForBath\Index.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\lks\lks\Views\FireSafetySystemForBath\Index.cshtml"
using lks.DbContexts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Documents\GitHub\lks\lks\Views\FireSafetySystemForBath\Index.cshtml"
using lks.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3940e39e81f48f7ac848bf167cf74452494e4e9", @"/Views/FireSafetySystemForBath/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea84aa7af47ba1e0b2ded2c206f2de0becce4099", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_FireSafetySystemForBath_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<lks.DbContexts.Comment>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("commentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("commentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\User\Documents\GitHub\lks\lks\Views\FireSafetySystemForBath\Index.cshtml"
  
    ViewData["Title"] = "fireSafetySystemForBath";
    ViewData["Comments"] = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--introFireSafetySystemForBath-->
<div class=""introFireSafetySystemForBath"">
    <div class=""container"">
        <div class=""informationWorkHereIAm__title"">
            Разработка автономной системы пожарной безопасности в бане на Raspberry Pi
        </div>
        <video class=""videoWorkHereIAm"" src=""videos/fireSafetySystemForBath.mp4"" width=""720"" controls=""controls"" poster=""images/posterFireSafetySystemForBath.jpg""></video>
    </div>
</div>

<!--informationWorkHereIAm-->
<div class=""informationWorkHereIAm"">
    <div class=""container"">

        <div class=""informationWorkHereIAm__text"">
            Сегодня в России, да и, пожалуй, во всём нашем мире стала наиболее актуально проблема пожарной безопасности объекта. Системы автономных электронных пожарных сигнализаций сейчас являются одним из главных способов устранения пожара.
            Из-за большого использования цифровых методов обработки информации и современных электронных компонентов происходит существенное повышение технических");
            WriteLiteral(@" средств, перестающих быть всего лишь вспомогательными и приобретающими всё новые свойства. Такие технические средства могут быть осуществлены в виде полностью интегрированной автономной системы или системы, которая состоит из функционально независимых компонентов.
            Пожарные системы, состоящие из множества компонентов большой ёмкости, обычно применимы для обеспечения безопасности крупных предприятий, таких как: гостиницы, склады, банки и характеризуемы тем, что обслуживают сразу от нескольких сотен и до нескольких тысяч датчиков.
            И при этом всём, контролировать нужно не только датчики, но и также устройства различного вида, которые управляют работой системы.
            Одноплатные компьютеры же идеально подходят для организации и развития малых и средних систем пожарной безопасности. При малых затратах денежных средств и рабочего времени и можно с легкостью наладить производство датчиков, причем в таких изделиях от 30% до 90% функциональной нагрузки несёт на себе программное обеспеч");
            WriteLiteral(@"ение, которое может быть легко модифицировано и приспособлено к нуждам потребителя.
            В данном курсовом проекте реализована система пожарной безопасности в бане на базе одноплатного компьютера.

        </div>
    </div>
</div>

<!--send comment-->

");
#nullable restore
#line 39 "C:\Users\User\Documents\GitHub\lks\lks\Views\FireSafetySystemForBath\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""rating"" dataTotalValue=""0"">
        <div class=""rating__item"" dataTotalValue=""5"">5☆</div>
        <div class=""rating__item"" dataTotalValue=""4"">4☆</div>
        <div class=""rating__item"" dataTotalValue=""3"">3☆</div>
        <div class=""rating__item"" dataTotalValue=""2"">2☆</div>
        <div class=""rating__item"" dataTotalValue=""1"">1☆</div>
    </div>
    <div class=""informationWorkHereIAm__titleComment"">
        Оставить комментарий
    </div>
");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3940e39e81f48f7ac848bf167cf74452494e4e98008", async() => {
                WriteLiteral("\r\n        <p>\r\n            <textarea typeof=\"text\" name=\"Text\" id=\"comment\" cols=\"100\" rows=\"10\" > </textarea>\r\n        </p>\r\n        <input class=\"btn btn--black\" type=\"button\"  value=\"Опубликовать\" id=\"sendBtn\"/>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            WriteLiteral(@"    <script src=""js/signalr/dist/browser/signalr.min.js""></script>
    <script>
        const hubConnection = new signalR.HubConnectionBuilder()
            .withUrl(""/chatter"")
            .build();
        
        hubConnection.on(""Send"", function (data) {
            let elem = document.createElement(""div"");
            elem.innerHTML = data;
            elem.className = ""container"";
            let firstElem = document.getElementById(""AllComments"").firstChild;
            document.getElementById(""AllComments"").insertBefore(elem, firstElem);
 
        });
 
        document.getElementById(""sendBtn"").addEventListener(""click"", function (e) {
            let message = document.getElementById(""comment"").value;
            let items = [];
            items.push(message);
            items.push(""");
#nullable restore
#line 78 "C:\Users\User\Documents\GitHub\lks\lks\Views\FireSafetySystemForBath\Index.cshtml"
                   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n            items.push(\"2\");\r\n            hubConnection.invoke(\"Send\", items);\r\n        });\r\n \r\n        hubConnection.start();\r\n    </script>\r\n");
#nullable restore
#line 85 "C:\Users\User\Documents\GitHub\lks\lks\Views\FireSafetySystemForBath\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<lks.DbContexts.Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591