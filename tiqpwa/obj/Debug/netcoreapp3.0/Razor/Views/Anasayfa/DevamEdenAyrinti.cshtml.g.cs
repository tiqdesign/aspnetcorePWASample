#pragma checksum "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenAyrinti.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79c0ab25657c4a44367866d2021147f121bac718"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anasayfa_DevamEdenAyrinti), @"mvc.1.0.view", @"/Views/Anasayfa/DevamEdenAyrinti.cshtml")]
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
#line 1 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\_ViewImports.cshtml"
using tiqpwa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\_ViewImports.cshtml"
using tiqpwa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79c0ab25657c4a44367866d2021147f121bac718", @"/Views/Anasayfa/DevamEdenAyrinti.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b07fdeb0b7afcf4528b847b82eb3cb385d801ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Anasayfa_DevamEdenAyrinti : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tiqpwa.Entities.Concrete.Proje>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/karaman.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col s12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-spacing:-50px -50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenAyrinti.cshtml"
  
    ViewData["Title"] = "Devam Eden İşler";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    $(document).ready(function () {\r\n        $(\'select\').formSelect();\r\n    });\r\n</script>\r\n<div class=\"row\" style=\"margin-top:20px\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79c0ab25657c4a44367866d2021147f121bac7185295", async() => {
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
            WriteLiteral("\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 345, "\"", 384, 1);
#nullable restore
#line 14 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenAyrinti.cshtml"
WriteAttributeValue("", 352, Url.Action("Index", "Anasayfa"), 352, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""waves-effect waves-light btn-small red lighten-1 secondary-content"" style=""margin-top:5px"" onclick=""M.toast({html: 'Sayfa Yükleniyor...'})""><b style=""color:white""> Geri </b></a>
</div>


<div class=""card-panel white hoverable"" style=""margin-top:10px;"">
    <div class=""center-align"">
        <p><b> Bilgileri Güncelle </b></p>
    </div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79c0ab25657c4a44367866d2021147f121bac7187167", async() => {
                WriteLiteral("\r\n\r\n        <div class=\"col s12\">\r\n            <div class=\"input-field\">\r\n                <input id=\"proje_adi\"");
                BeginWriteAttribute("value", " value=\"", 912, "\"", 935, 1);
#nullable restore
#line 26 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenAyrinti.cshtml"
WriteAttributeValue("", 920, Model.ProjeAdi, 920, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\">\r\n                <label for=\"proje_adi\"><b> Proje Adı :</b></label>\r\n            </div>\r\n        </div>\r\n        <div class=\"col s12\">\r\n            <div class=\"input-field\">\r\n                <input id=\"proje_adi\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1174, "\"", 1203, 1);
#nullable restore
#line 32 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenAyrinti.cshtml"
WriteAttributeValue("", 1182, Model.IlgiliPersonel, 1182, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label for=\"proje_adi\"> <b>Yetkili Kişi :</b></label>\r\n            </div>\r\n        </div>\r\n        <div class=\"col s12\">\r\n            <div class=\"input-field\">\r\n                <input id=\"proje_adi\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1433, "\"", 1462, 1);
#nullable restore
#line 38 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenAyrinti.cshtml"
WriteAttributeValue("", 1441, Model.YetkiliTelefon, 1441, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label for=\"proje_adi\"> <b>Yetkili Telefon :</b></label>\r\n            </div>\r\n        </div>\r\n        <div class=\"col s12\">\r\n            <div class=\"input-field\">\r\n                <input id=\"proje_adi\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1695, "\"", 1718, 1);
#nullable restore
#line 44 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenAyrinti.cshtml"
WriteAttributeValue("", 1703, Model.Lokasyon, 1703, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label for=\"proje_adi\" style=\"margin-left:5px\"> <b>Lokasyon :</b></label>\r\n            </div>\r\n        </div>\r\n        <div class=\"col s12\">\r\n            <div class=\"input-field\">\r\n                <input id=\"proje_adi\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1968, "\"", 1994, 1);
#nullable restore
#line 50 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenAyrinti.cshtml"
WriteAttributeValue("", 1976, Model.ProjeTarihi, 1976, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                <label for=""proje_adi"" style=""margin-left:5px""> <b>Tarih :</b></label>
            </div>
        </div>
        <div class=""col s12"">
            <div class=""input-field"">
                <input id=""proje_adi"" type=""text"">
                <label for=""proje_adi"" style=""margin-left:5px""> <b>Saat :</b></label>
            </div>
        </div>
        <div class=""col s12"">
            <div class=""input-field"">
                <input id=""proje_adi"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 2486, "\"", 2515, 1);
#nullable restore
#line 62 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenAyrinti.cshtml"
WriteAttributeValue("", 2494, Model.IsinAciklamasi, 2494, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                <label for=""proje_adi"" style=""margin-left:5px""> <b>İşin Açıklaması :</b></label>
            </div>
        </div>
        <div class=""row"">
            <div class=""file-field input-field"">
                <div class=""btn"">
                    <span>Fotoğraf Yükle</span>
                    <input type=""file"">
                </div>
                <div class=""file-path-wrapper"">
                    <input class=""file-path validate"" type=""text"">
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"center-align\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3111, "\"", 3150, 1);
#nullable restore
#line 79 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenAyrinti.cshtml"
WriteAttributeValue("", 3118, Url.Action("Index", "Anasayfa"), 3118, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"waves-effect waves-light btn-small red    darken-1 \" style=\"margin-top:5px\" onclick=\"M.toast({html: \'Sayfa Yükleniyor...\'})\"><b style=\"color:white\"> İptal Et</b></a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3336, "\"", 3375, 1);
#nullable restore
#line 80 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenAyrinti.cshtml"
WriteAttributeValue("", 3343, Url.Action("Index", "Anasayfa"), 3343, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"waves-effect waves-light btn-small yellow darken-1 \" style=\"margin-top:5px\" onclick=\"M.toast({html: \'Sayfa Yükleniyor...\'})\"><b style=\"color:white\"> Beklemeye Al </b></a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3566, "\"", 3605, 1);
#nullable restore
#line 81 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenAyrinti.cshtml"
WriteAttributeValue("", 3573, Url.Action("Index", "Anasayfa"), 3573, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"waves-effect waves-light btn-small green  darken-1 \" style=\"margin-top:5px\" onclick=\"M.toast({html: \'Kaydediliyor...\'})\"><b style=\"color:white\"> Kaydet </b></a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3786, "\"", 3825, 1);
#nullable restore
#line 82 "C:\Users\tar24\source\repos\tiqpwa\tiqpwa\Views\Anasayfa\DevamEdenAyrinti.cshtml"
WriteAttributeValue("", 3793, Url.Action("Index", "Anasayfa"), 3793, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"waves-effect waves-light btn-small blue   darken-1 \" style=\"margin-top:5px\" onclick=\"M.toast({html: \'Sayfa Yükleniyor...\'})\"><b style=\"color:white\"> Tamamlandı </b></a>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tiqpwa.Entities.Concrete.Proje> Html { get; private set; }
    }
}
#pragma warning restore 1591
