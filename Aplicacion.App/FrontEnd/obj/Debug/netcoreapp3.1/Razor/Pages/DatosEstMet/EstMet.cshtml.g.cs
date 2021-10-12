#pragma checksum "C:\Users\mshec\OneDrive\Escritorio\Projects\C_Sharp\Integracion\Aplicacion.App\FrontEnd\Pages\DatosEstMet\EstMet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43dd060f116090e36f6256a7bdf6dc024166810c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.DatosEstMet.Pages_DatosEstMet_EstMet), @"mvc.1.0.razor-page", @"/Pages/DatosEstMet/EstMet.cshtml")]
namespace FrontEnd.Pages.DatosEstMet
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43dd060f116090e36f6256a7bdf6dc024166810c", @"/Pages/DatosEstMet/EstMet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2897937179e1d46cc629a52c919bacfd79ade30d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DatosEstMet_EstMet : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 btn btn-lg btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./IngrEstMet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 btn btn-lg btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditEstMet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./IngrDatosMet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\mshec\OneDrive\Escritorio\Projects\C_Sharp\Integracion\Aplicacion.App\FrontEnd\Pages\DatosEstMet\EstMet.cshtml"
  
    ViewData["Title"] = "Estación Meteorológica";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container py-3\">\r\n    <header>\r\n        <div class=\"pricing-header p-3 pb-md-4 mx-auto text-center\">\r\n            <h1 class=\"display-4 fw-normal\">");
#nullable restore
#line 11 "C:\Users\mshec\OneDrive\Escritorio\Projects\C_Sharp\Integracion\Aplicacion.App\FrontEnd\Pages\DatosEstMet\EstMet.cshtml"
                                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
            <p class=""fs-5 text-muted"">Visualización y monitoreo del estado de las Estaciones Meteorológicas</p>
        </div>
    </header>

    <main>
        <div class=""row row-cols-1 row-cols-md-3 mb-3 text-center"">
            <div class=""col"">
                <div class=""card mb-4 rounded-3 shadow-sm"">
                    <div class=""card-header py-3"">
                        <h4 class=""my-0 fw-normal"">Crear Estación</h4>
                    </div>
                    <div class=""card-body"">
                        <i class=""bi bi-shop-window"" style=""font-size: 50px""></i>
                        <ul class=""list-unstyled mt-3 mb-4"">
                            <li>Ingresa los datos de una</li>
                            <li>Estación Meteorológica</li>
                            <li>nueva</li>
                        </ul>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43dd060f116090e36f6256a7bdf6dc024166810c6949", async() => {
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
                        <h4 class=""my-0 fw-normal"">Editar Estación</h4>
                    </div>
                    <div class=""card-body"">
                        <i class=""bi bi-sliders"" style=""font-size: 50px""></i>
                        <ul class=""list-unstyled mt-3 mb-4"">
                            <li>Edita los datos de una</li>
                            <li>Estación Meteorológica</li>
                            <li>existente</li>
                        </ul>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43dd060f116090e36f6256a7bdf6dc024166810c9213", async() => {
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
            <div class=""col"">
                <div class=""card mb-4 rounded-3 shadow-sm border-primary"">
                    <div class=""card-header py-3 text-white bg-primary border-primary"">
                        <h4 class=""my-0 fw-normal"">Visualizar Datos</h4>
                    </div>
                    <div class=""card-body"">
                        <i class=""bi bi-braces"" style=""font-size: 50px""></i>
                        <ul class=""list-unstyled mt-3 mb-4"">
                            <li>Consulta los Datos Meteorológicos:</li>
                            <li>Temperatura</li>
                            <li>Presión Atmosférica</li>
                            <li>más..</li>
                        </ul>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43dd060f116090e36f6256a7bdf6dc024166810c11586", async() => {
                WriteLiteral("Consultar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
        </div>
    </main>
</div>



<!--
<section id=""contenido"">
    <h2>titulo parrafo 1</h2>
    <form>
        <p>Ingrese Nombre: <input type=""text"" name=""nombre""></p>
        <p>Ingrese Contraseña: <input type=""password"" name=""clave""></p>
        <p><input type=""submit"" value=""guardar""></p>
    </form>
</section>
<section id=""contenido2"">
    <h2>titulo parrafo 2</h2>
    <form>
        <p><input type=""radio"" name=""grupo1"" value=""opcion1"">op1</p>
        <p><input type=""radio"" name=""grupo1"" value=""opcion2"">op2</p>
        <p><input type=""radio"" name=""grupo1"" value=""opcion3"">op3</p>
        <p><input type=""radio"" name=""grupo1"" value=""opcion4"">op4</p>
    </form>
    <form>
        <p><input type=""checkbox"" value=""opcion1"">op1</p>
        <p><input type=""checkbox"" value=""opcion2"">op2</p>
        <p><input type=""checkbox"" value=""opcion3"">op3</p>
        <p><input type=""checkbox"" value=""opcion4"">op4</p>
   ");
            WriteLiteral(" </form>\r\n</section>\r\n<aside>\r\n    <h2>informacion</h2>\r\n    <form>\r\n      <input type=\"datetime-local\" name=\"fechahora\">\r\n    </form>\r\n</aside> -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrontEnd.Pages.EstMetModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FrontEnd.Pages.EstMetModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FrontEnd.Pages.EstMetModel>)PageContext?.ViewData;
        public FrontEnd.Pages.EstMetModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
