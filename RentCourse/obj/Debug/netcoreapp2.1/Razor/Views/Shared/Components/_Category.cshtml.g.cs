#pragma checksum "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\_Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a4108f8a50412a550e93adb413cb4b45c346b82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Category), @"mvc.1.0.view", @"/Views/Shared/Components/_Category.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/_Category.cshtml", typeof(AspNetCore.Views_Shared_Components__Category))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a4108f8a50412a550e93adb413cb4b45c346b82", @"/Views/Shared/Components/_Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77d38f739bb18d1af091cd6138dbac75590b6920", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 708, true);
            WriteLiteral(@"<style>
    nav{
        font-family:sans-serif;
    }
    a {
        color: #04049d;
        text-decoration: none;
    }
    li input{
        border-color:#04049d;
        border-width:2px;
    }
    li label{
        color:#04049d;
        font-family:sans-serif;
    }
</style>
<nav id=""sidebar"" style=""
        width: 20%;
        padding: 30px;
        border-right: 3px solid #04049d !important;
        background-image: url('https://pbs.twimg.com/media/EuxzjKNWQAUSiYC?format=jpg&name=large');
        background-size: cover;"">
    <div class=""label"" style=""font-family:sans-serif; color:#04049d; font-size:2em; text-transform:uppercase; font-weight:600"">Фільтри</div>
    ");
            EndContext();
            BeginContext(708, 3480, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4721ed22b034f4f8e8355e4dbaa6a0b", async() => {
                BeginContext(714, 489, true);
                WriteLiteral(@"
        <input class=""form-control mr-sm-2"" type=""search"" placeholder=""ПОШУК"" style=""border-width:2px;border-color:#04049d"" aria-label=""Search"">
        <ul class=""list-unstyled components mb-5"">
            <li>
                <a href=""#pageSubmenu1"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle"" style=""text-transform: uppercase; font-weight: 600; font-family:sans-serif"">Категорія</a>
                <ul class=""collapse list-unstyled"" id=""pageSubmenu1"">
");
                EndContext();
#line 31 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\_Category.cshtml"
                     foreach (var category in Model.Categories)
                    {
                        

#line default
#line hidden
                BeginContext(1317, 93, true);
                WriteLiteral("                        <li>\r\n                            <input name=\"category\" type=\"radio\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1410, "\"", 1429, 1);
#line 35 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\_Category.cshtml"
WriteAttributeValue("", 1415, category.Name, 1415, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1430, "\"", 1452, 1);
#line 35 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\_Category.cshtml"
WriteAttributeValue("", 1438, category.Name, 1438, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1453, 38, true);
                WriteLiteral("/>\r\n                            <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 1491, "\"", 1511, 1);
#line 36 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\_Category.cshtml"
WriteAttributeValue("", 1497, category.Name, 1497, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1512, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1514, 13, false);
#line 36 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\_Category.cshtml"
                                                   Write(category.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1527, 41, true);
                WriteLiteral("</label>\r\n                        </li>\r\n");
                EndContext();
#line 38 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\_Category.cshtml"
                    }

#line default
#line hidden
                BeginContext(1591, 338, true);
                WriteLiteral(@"                </ul>
            </li>
            <li>
                <a href=""#pageSubmenu2"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle"" style=""text-transform: uppercase; font-weight: 600; font-family:sans-serif"">Місцезнаходження</a>
                <ul class=""collapse list-unstyled"" id=""pageSubmenu2"">
");
                EndContext();
#line 44 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\_Category.cshtml"
                     foreach (var location in Model.Locations)
                    {

#line default
#line hidden
                BeginContext(2016, 93, true);
                WriteLiteral("                        <li>\r\n                            <input name=\"location\" type=\"radio\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2109, "\"", 2128, 1);
#line 47 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\_Category.cshtml"
WriteAttributeValue("", 2114, location.City, 2114, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2129, "\"", 2151, 1);
#line 47 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\_Category.cshtml"
WriteAttributeValue("", 2137, location.City, 2137, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2152, 39, true);
                WriteLiteral(" />\r\n                            <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 2191, "\"", 2211, 1);
#line 48 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\_Category.cshtml"
WriteAttributeValue("", 2197, location.City, 2197, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2212, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2214, 13, false);
#line 48 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\_Category.cshtml"
                                                   Write(location.City);

#line default
#line hidden
                EndContext();
                BeginContext(2227, 41, true);
                WriteLiteral("</label>\r\n                        </li>\r\n");
                EndContext();
#line 50 "C:\Users\andre\source\repos (old)\rent.ukraine3\RentCourse\Views\Shared\Components\_Category.cshtml"
                    }

#line default
#line hidden
                BeginContext(2291, 1890, true);
                WriteLiteral(@"                </ul>
            </li>
            <li>
                <a href=""#pageSubmenu3"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle"" style=""text-transform: uppercase; font-weight: 600; font-family:sans-serif"">Ціна</a>
                <ul class=""collapse list-unstyled"" id=""pageSubmenu3"">
                    <li style=""display:flex;flex-direction:column"">
                    <input class=""form-control mr-sm-2"" type=""text"" placeholder=""Мінімальна ціна"" aria-label=""MinPrice"" style=""margin-bottom:0.5em""/>
                    <input class=""form-control mr-sm-2"" type=""text"" placeholder=""Максимальна ціна"" aria-label=""MaxPrice"" /></li>
                </ul>
            </li>
            <li>
                <a href=""#pageSubmenu4"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle"" style=""text-transform: uppercase; font-weight: 600; font-family:sans-serif"">Сортувати за</a>
                <ul class=""collapse list-unstyled"" id=""pageSubmenu4"">
              ");
                WriteLiteral(@"      <li>
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
            BeginContext(4188, 687, true);
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