#pragma checksum "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4f5385b10bb0822731dd964f0b79da3de71533f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Category_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Category/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Category/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Category_Default))]
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
#line 1 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\_ViewImports.cshtml"
using RentCourse;

#line default
#line hidden
#line 2 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\_ViewImports.cshtml"
using RentCourse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4f5385b10bb0822731dd964f0b79da3de71533f", @"/Views/Shared/Components/Category/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77d38f739bb18d1af091cd6138dbac75590b6920", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Category_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 732, true);
            WriteLiteral(@"<style>
    nav {
        font-family: sans-serif;
    }

    a {
        color: #04049d;
        text-decoration: none;
    }

    li input {
        border-color: #04049d;
        border-width: 2px;
    }

    li label {
        color: #04049d;
        font-family: sans-serif;
    }
</style>
<nav id=""sidebar"" style=""        width: 25%;
        padding: 2em;
        margin: 2em;
        border: 0.3em dashed #04049d;
        /*        background-image: url('https://pbs.twimg.com/media/EuxzjKNWQAUSiYC?format=jpg&name=large');
*/ background-size: cover;"">
    <div class=""label"" style=""font-family:sans-serif; color:#2acdc1; font-size:3em; text-transform:uppercase; font-weight:600"">Фільтри</div>
    ");
            EndContext();
            BeginContext(732, 4544, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e7984f04ede4cf3bfbf7b4e99f585b0", async() => {
                BeginContext(738, 522, true);
                WriteLiteral(@"
        <input class=""form-control mr-sm-2"" type=""search"" placeholder=""ПОШУК"" style=""border-width:2px;border-color:#04049d;margin-bottom:2em;margin-top:2em"" aria-label=""Search"">
        <ul class=""list-unstyled components mb-5"">
            <li>
                <a href=""#pageSubmenu1"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle"" style=""text-transform: uppercase; font-weight: 600; font-family:sans-serif"">Категорія</a>
                <ul class=""collapse list-unstyled"" id=""pageSubmenu1"">
");
                EndContext();
#line 34 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
                     foreach (var category in Model.Categories)
                    {
                        if (ViewData["Title"].ToString() == "MainThings" && category.TypeId == 1)
                        {

#line default
#line hidden
                BeginContext(1474, 101, true);
                WriteLiteral("                            <li>\r\n                                <input name=\"category\" type=\"radio\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1575, "\"", 1594, 1);
#line 39 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 1580, category.Name, 1580, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1595, "\"", 1617, 1);
#line 39 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 1603, category.Name, 1603, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1618, 43, true);
                WriteLiteral(" />\r\n                                <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 1661, "\"", 1681, 1);
#line 40 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 1667, category.Name, 1667, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1682, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1684, 13, false);
#line 40 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
                                                       Write(category.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1697, 45, true);
                WriteLiteral("</label>\r\n                            </li>\r\n");
                EndContext();
#line 42 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
                        }
                        else if (ViewData["Title"].ToString() == "MainRealEstate" && category.TypeId == 2)
                        {

#line default
#line hidden
                BeginContext(1904, 101, true);
                WriteLiteral("                            <li>\r\n                                <input name=\"category\" type=\"radio\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2005, "\"", 2024, 1);
#line 46 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2010, category.Name, 2010, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2025, "\"", 2047, 1);
#line 46 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2033, category.Name, 2033, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2048, 43, true);
                WriteLiteral(" />\r\n                                <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 2091, "\"", 2111, 1);
#line 47 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2097, category.Name, 2097, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2112, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2114, 13, false);
#line 47 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
                                                       Write(category.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2127, 45, true);
                WriteLiteral("</label>\r\n                            </li>\r\n");
                EndContext();
#line 49 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
                        }
                        else if (ViewData["Title"].ToString() == "MainCars" && category.TypeId == 3)
                        {

#line default
#line hidden
                BeginContext(2328, 101, true);
                WriteLiteral("                            <li>\r\n                                <input name=\"category\" type=\"radio\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2429, "\"", 2448, 1);
#line 53 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2434, category.Name, 2434, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2449, "\"", 2471, 1);
#line 53 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2457, category.Name, 2457, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2472, 43, true);
                WriteLiteral(" />\r\n                                <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 2515, "\"", 2535, 1);
#line 54 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 2521, category.Name, 2521, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2536, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2538, 13, false);
#line 54 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
                                                       Write(category.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2551, 45, true);
                WriteLiteral("</label>\r\n                            </li>\r\n");
                EndContext();
#line 56 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(2646, 338, true);
                WriteLiteral(@"                </ul>
            </li>
            <li>
                <a href=""#pageSubmenu2"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle"" style=""text-transform: uppercase; font-weight: 600; font-family:sans-serif"">Місцезнаходження</a>
                <ul class=""collapse list-unstyled"" id=""pageSubmenu2"">
");
                EndContext();
#line 63 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
                     foreach (var location in Model.Locations)
                    {

#line default
#line hidden
                BeginContext(3071, 93, true);
                WriteLiteral("                        <li>\r\n                            <input name=\"location\" type=\"radio\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3164, "\"", 3183, 1);
#line 66 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 3169, location.City, 3169, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3184, "\"", 3206, 1);
#line 66 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 3192, location.City, 3192, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3207, 39, true);
                WriteLiteral(" />\r\n                            <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 3246, "\"", 3266, 1);
#line 67 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 3252, location.City, 3252, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3267, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(3269, 13, false);
#line 67 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
                                                   Write(location.City);

#line default
#line hidden
                EndContext();
                BeginContext(3282, 41, true);
                WriteLiteral("</label>\r\n                        </li>\r\n");
                EndContext();
#line 69 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\Category\Default.cshtml"
                    }

#line default
#line hidden
                BeginContext(3346, 1923, true);
                WriteLiteral(@"                </ul>
            </li>
            <li>
                <a href=""#pageSubmenu3"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle"" style=""text-transform: uppercase; font-weight: 600; font-family:sans-serif"">Ціна</a>
                <ul class=""collapse list-unstyled"" id=""pageSubmenu3"">
                    <li style=""display:flex;flex-direction:column"">
                        <input class=""form-control mr-sm-2"" type=""text"" placeholder=""Мінімальна ціна"" aria-label=""MinPrice"" style=""margin-bottom:0.5em"" />
                        <input class=""form-control mr-sm-2"" type=""text"" placeholder=""Максимальна ціна"" aria-label=""MaxPrice"" />
                    </li>
                </ul>
            </li>
            <li>
                <a href=""#pageSubmenu4"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle"" style=""text-transform: uppercase; font-weight: 600; font-family:sans-serif"">Сортувати за</a>
                <ul class=""collapse list-unstyled"" id=");
                WriteLiteral(@"""pageSubmenu4"">
                    <li>
                        <input name=""sort"" type=""radio"" id=""new"" value=""new"">
                        <label for=""new"">Найновіші</label><br>

                        <input name=""sort"" type=""radio"" id=""min"" value=""min"">
                        <label for=""min"">Ціна (мін->макс)</label><br>

                        <input name=""sort"" type=""radio"" id=""max"" value=""max"">
                        <label for=""max"">Ціна (макс->мін)</label><br>
                    </li>
                </ul>
            </li>
            <li style=""display:flex;justify-content:center"">

                <button type=""submit"" style=""font-size:1em;font-family:sans-serif;font-weight:600;margin-top:1em !important;color:#04049d;border-color:#04049d;border-width:2px"" id=""addbtn"" class=""btn btn-outline-success"">ШУКАТИ</button>
            </li>
        </ul>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5276, 687, true);
            WriteLiteral(@"
    <div class=""mb-5"">
        <div class=""label"" style=""color:#04049d; text-transform:uppercase; font-size:1.3em; font-weight:600"">Tag Cloud</div>
        <div class=""tagcloud"">
            <a href=""#"" class=""tag-cloud-link"">dish</a>
            <a href=""#"" class=""tag-cloud-link"">menu</a>
            <a href=""#"" class=""tag-cloud-link"">food</a>
            <a href=""#"" class=""tag-cloud-link"">sweet</a>
            <a href=""#"" class=""tag-cloud-link"">tasty</a>
            <a href=""#"" class=""tag-cloud-link"">delicious</a>
            <a href=""#"" class=""tag-cloud-link"">desserts</a>
            <a href=""#"" class=""tag-cloud-link"">drinks</a>
        </div>
    </div>
</nav>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
