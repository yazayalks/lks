#pragma checksum "C:\Users\User\Documents\GitHub\lks\lks\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ef33d7e349cf7ff6130b586f6f177ff0e052950"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef33d7e349cf7ff6130b586f6f177ff0e052950", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea84aa7af47ba1e0b2ded2c206f2de0becce4099", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Documents\GitHub\lks\lks\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <!--intro-->
<div class=""introIndex"">
    <div class=""container"">
        <div class=""intro__inner""></div>
        <h1 class=""intro__title"">Лысак Кирилл Сергеевич</h1>
        <h2 class=""intro__subtitle"">It специалист,<br> художник-мультипликатор</h2>
        <a class=""btn btn--black"" href=""contacts"">Связаться</a>
    </div>
</div>

<!--features-->
<div class=""container"">
    <div class=""features"">
        <!--education-->
        <div class=""features__item"">
            <img class=""features__icon"" src=""images/features/education.png""");
            BeginWriteAttribute("alt", " alt=\"", 604, "\"", 610, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <h4 class=""features__title"">Образование</h4>
            <div class=""features__text"">Студент НГТУ, факультет
                автоматики и вычислительной техники, направление:
                09.03.01 информатика и вычислительная техника (2018-…).
            </div>
        </div>
        <!--programming-->
        <div class=""features__item"">
            <img class=""features__icon"" src=""images/features/programming.png""");
            BeginWriteAttribute("alt", " alt=\"", 1056, "\"", 1062, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <h4 class=""features__title"">Программирование</h4>
            <div class=""features__text"">Есть опыт работы с языками: С++,C#, Python, JavaScript, ActionScript (3.0),
                Pascal. Владение кодовыми редакторами: Visual Studio Code, WebStorm. Навык создавания приложений и веб
                проектов.
            </div>
        </div>

        <!--art-->
        <div class=""features__item"">
            <img class=""features__icon"" src=""images/features/art.png""");
            BeginWriteAttribute("alt", " alt=\"", 1558, "\"", 1564, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <h4 class=""features__title"">Графика и мультимедия</h4>
            <div class=""features__text"">Высокий уровень работы в программах:Adobe Photoshop, Adobe Flash, Adobe Animate,
                Adobe Illustrator, Adobe Premiere. Создание мультипликации, монтаж видео, векторные и растровые арты.
            </div>
        </div>

        <!--communication-->
        <div class=""features__item"">
            <img class=""features__icon"" src=""images/features/communication.png""");
            BeginWriteAttribute("alt", " alt=\"", 2062, "\"", 2068, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <h4 class=""features__title"">Коммуникация</h4>
            <div class=""features__text"">Умение устанавливать деловые контакты и развивать их, ответственность,
                внимательность, лидерские качества, высокая работоспособность, умение быстро осваивать новую информацию
                и качественное применение её на практике.
            </div>
        </div>

        <!--health-->
        <div class=""features__item"">
            <img class=""features__icon"" src=""images/features/health.png""");
            BeginWriteAttribute("alt", " alt=\"", 2594, "\"", 2600, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <h4 class=""features__title"">Здоровье</h4>
            <div class=""features__text"">Веду здоровый образ жизни, регулярно занимаюсь спортом и люблю активный отдых
                на природе. Имею 1 взрослый разряд по лёгкой атлетике.
            </div>
        </div>

        <!--hobby-->
        <div class=""features__item"">
            <img class=""features__icon"" src=""images/features/hobby.png""");
            BeginWriteAttribute("alt", " alt=\"", 3019, "\"", 3025, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <h4 class=""features__title"">Хобби</h4>
            <div class=""features__text"">Играю на классической и электрогитаре, пишу и пою песни, занимаюсь лёгкой
                атлетикой и велоспортом, есть навыки барного дела, люблю собирать кубик Рубика
            </div>
        </div>
    </div>
</div>
<!--works-->
<div class=""works"">
    <!--skiing-->
    <div class=""works__item"">
        <img class=""works__image"" src=""images/skiing.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3490, "\"", 3496, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""works__content"">
            <div class=""works__title"">Горные лыжи</div>
            <div class=""works__text"">НПК 2014, мультфильм</div>
        </div>
    </div>
    <!--fireSafetySystemForBath-->
    <div class=""works__item"">
        <img class=""works__image"" src=""images/fireSafetySystemForBath.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3829, "\"", 3835, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""works__content"">
            <a class=""works__title"" href=""fireSafetySystemForBath"">Система пожарной безопасности в бане</a>
            <div class=""works__text"">Курсовая работа 2020, автономная система</div>
        </div>
    </div>
    <!--HereIAm-->
    <div class=""works__item"">
        <img class=""works__image"" src=""images/HereIAm.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4208, "\"", 4214, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""works__content"">
            <a class=""works__title"" href=""workHereIAm"">А вот и я</a>
            <div class=""works__text"">НПК 2015, мультфильм</div>
        </div>
    </div>
    <!--syntacticalAnalyzerPrintf-->
    <div class=""works__item"">
        <img class=""works__image"" src=""images/syntacticalAnalyzerPrintf.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4564, "\"", 4570, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""works__content"">
            <div class=""works__title"">Синтаксический анализатор Printf</div>
            <div class=""works__text"">Курсовая работа 2021, программа</div>
        </div>
    </div>
    <!--billiards-->
    <div class=""works__item"">
        <img class=""works__image"" src=""images/billiards.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4907, "\"", 4913, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""works__content"">
            <div class=""works__title"">Симмулирование физических эксперементов</div>
            <div class=""works__text"">Курсовая работа 2020, программа</div>
        </div>
    </div>
    <!--sportIsLife-->
    <div class=""works__item"">
        <img class=""works__image"" src=""images/sportIsLife.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5261, "\"", 5267, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""works__content"">
            <div class=""works__title"">Спорт - это жизнь</div>
            <div class=""works__text"">НПК 2016, мультфильм</div>
        </div>
    </div>
    <!--fallingBalls-->
    <div class=""works__item"">
        <img class=""works__image"" src=""images/fallingBalls.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5584, "\"", 5590, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""works__content"">
            <div class=""works__title"">Falling Balls</div>
            <div class=""works__text"">Лабораторная работа 2021, веб игра</div>
        </div>
    </div>
    <!--doYouLiveOrJustExist-->
    <div class=""works__item"">
        <img class=""works__image"" src=""images/doYouLiveOrJustExist.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5933, "\"", 5939, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""works__content"">
            <div class=""works__title"">Ты живёшь или просто существуешь?</div>
            <div class=""works__text"">Портрет 2017, векторная графика</div>
        </div>
    </div>
</div>

<!--hobby-->
<div class=""hobby"">
    <div class=""container"">
        <div class=""hobby__inner"">
            <!--hobbyGuitar-->
            <div class=""hobby__item"">
                <img class=""hobby__image-1"" src=""images/hobbyGuitar-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6419, "\"", 6425, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img class=\"hobby__image-2\" src=\"images/hobbyGuitar-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6503, "\"", 6509, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""hobby__title"">Гитара</div>
                <div class=""hobby__text"">Ещё с далёкого 2017 года я начал сам учиться играть на гитаре, всё начиналось
                    с обычных аккордов, сейчасже я полноценно знаю ноты, строение мелодий, пишу сам песни и пою их.
                </div>
            </div>
            <!--hobbyBike-->
            <div class=""hobby__item"">
                <img class=""hobby__image-1"" src=""images/hobbyBike-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6991, "\"", 6997, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img class=\"hobby__image-2\" src=\"images/hobbyBike-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7073, "\"", 7079, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""hobby__title"">Велик</div>
                <div class=""hobby__text"">В 2012 году у меня появился первый велосипед. Тогда я совсем не умел кататься,
                    очень быстро уставал. Сейчас я спокойно проезжаю в день 100км, объезжаю на велосипеде весь
                    Новосибирск.
                </div>
            </div>

        </div>
    </div>
</div>

<!--testimonials-->

<div class=""testimonials"">
    <div class=""container"">

        <!--testimonials-1-->
        <div class=""testimonials__item"">
            <div class=""testimonials__photo"">
                <img class=""testimonials__image"" src=""images/testimonials-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7771, "\"", 7777, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""testimonials__content"">
                <div class=""testimonials__text"">""Знаете, это мой друг. Я его люблю, как и он любит меня.
                    После ВУЗ-а мы с ним уедем жить в Америку и не будем ни в чём нуждаться!""
                </div>
                <div class=""testimonials__author"">Артём Квашнин, СПбПУ Петра Великого (Политех),
                    Институт компьютерных наук и технологий:
                    высшая школа программной инженерии
                </div>
            </div>
        </div>

    </div>
</div>

<!--contact-->
<div class=""contact"">
    <div class=""container"">
        <h3 class=""contact__title"">Вас заинтересовало резюме? Напишите мне прямо сейчас!</h3>
        <div class=""contact__text"">Свяжитесь с Кириллом, и он ответит Вам в ближайшее время.</div>
        <a class=""btn btn--black"" href=""contacts"">Связаться прямо сейчас</a>
    </div>
</div>
");
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
