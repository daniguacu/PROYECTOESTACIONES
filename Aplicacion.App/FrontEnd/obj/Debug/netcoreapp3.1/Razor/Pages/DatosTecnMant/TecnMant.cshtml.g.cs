#pragma checksum "C:\Users\mshec\OneDrive\Escritorio\Projects\C_Sharp\Integracion\Aplicacion.App\FrontEnd\Pages\DatosTecnMant\TecnMant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68af7ebf3860df5af57314c552a50bd248411624"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.DatosTecnMant.Pages_DatosTecnMant_TecnMant), @"mvc.1.0.razor-page", @"/Pages/DatosTecnMant/TecnMant.cshtml")]
namespace FrontEnd.Pages.DatosTecnMant
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
#line 1 "C:\Users\mshec\OneDrive\Escritorio\Projects\C_Sharp\Integracion\Aplicacion.App\FrontEnd\Pages\_ViewImports.cshtml"
using FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68af7ebf3860df5af57314c552a50bd248411624", @"/Pages/DatosTecnMant/TecnMant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2897937179e1d46cc629a52c919bacfd79ade30d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DatosTecnMant_TecnMant : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 btn btn-lg btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./CrearTecnMant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 btn btn-lg btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditTecnMant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mshec\OneDrive\Escritorio\Projects\C_Sharp\Integracion\Aplicacion.App\FrontEnd\Pages\DatosTecnMant\TecnMant.cshtml"
  
    ViewData["Title"] = "T??cnico de Mantenimiento";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container py-3\">\r\n    <header>\r\n        <div class=\"pricing-header p-3 pb-md-4 mx-auto text-center\">\r\n            <h1 class=\"display-4 fw-normal\">");
#nullable restore
#line 10 "C:\Users\mshec\OneDrive\Escritorio\Projects\C_Sharp\Integracion\Aplicacion.App\FrontEnd\Pages\DatosTecnMant\TecnMant.cshtml"
                                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral(@"        </div>
    </header>

    <main>
        <div class=""row row-cols-1 row-cols-md-3 mb-3 text-center"">
            <div class=""col"">
                <div class=""card mb-4 rounded-3 shadow-sm"">
                    <div class=""card-header py-3"">
                        <h4 class=""my-0 fw-normal"">Crear Perfil</h4>
                    </div>
                    <div class=""card-body"">
                        <i class=""bi bi-person-plus"" style=""font-size: 50px""></i>
                        <ul class=""list-unstyled mt-3 mb-4"">
                            <li>Agregar una nueva</li>
                            <li>instancia de T??cnico</li>
                        </ul>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68af7ebf3860df5af57314c552a50bd2484116246539", async() => {
                WriteLiteral("Comenzar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col"">
                <div class=""card mb-4 rounded-3 shadow-sm"">
                    <div class=""card-header py-3"">
                        <h4 class=""my-0 fw-normal"">Editar Perfil</h4>
                    </div>
                    <div class=""card-body"">
                        <i class=""bi bi-input-cursor-text"" style=""font-size: 50px""></i>
                        <ul class=""list-unstyled mt-3 mb-4"">
                            <li>Editar una instancia</li>
                            <li>existente de T??cnico</li>
                        </ul>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68af7ebf3860df5af57314c552a50bd2484116248759", async() => {
                WriteLiteral("Actualizar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <!--
            <div class=""col"">
                <div class=""card mb-4 rounded-3 shadow-sm border-primary"">
                    <div class=""card-header py-3 text-white bg-primary border-primary"">
                        <h4 class=""my-0 fw-normal"">Ingresar Datos</h4>
                    </div>
                    <div class=""card-body"">
                        <i class=""bi bi-braces"" style=""font-size: 50px""></i>
                        <ul class=""list-unstyled mt-3 mb-4"">
                            <li>Ingresa Datos Meteorol??gicos:</li>
                            <li>Temperatura</li>
                            <li>Presi??n Atmosf??rica</li>
                            <li>m??s..</li>
                        </ul>
                        <a type=""button"" class=""w-100 btn btn-lg btn-primary"" asp-area="""" asp-page=""./IngrDatosMet"">Crear Registro</a>
                    </div>
                </div>
            ");
            WriteLiteral(@"</div>
            -->
        </div>
    </main>
</div>



<!--
<div class=""container"">
    <div class=""card-deck mb-3 text-center"">
        <div class=""card mb-4 shadow-sm"">
            <div class=""card-header"">
                <h4 class=""my-0 font-weight-normal"">Ingresa el c??digo de la Estaci??n</h4>
            </div>
            <div class=""card-body"">
                <ul class=""list-unstyled mt-3 mb-4"">
                    <form class=""needs-validation"" novalidate>
                        <label for=""descripcion"">C??digo</label>
                        <input type=""text"" class=""form-control"" style=""max-width: 288px; margin: auto"" name=""nombre"">
                    </form>
                </ul>
                <a type=""button"" class=""w-100 btn btn-lg btn-primary"" style=""max-width: 288px"" asp-area="""" asp-page=""./IngReporte"">Confirmar</a>
            </div>
        </div>
    </div>
</div>
-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrontEnd.Pages.TecnMantModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FrontEnd.Pages.TecnMantModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FrontEnd.Pages.TecnMantModel>)PageContext?.ViewData;
        public FrontEnd.Pages.TecnMantModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
