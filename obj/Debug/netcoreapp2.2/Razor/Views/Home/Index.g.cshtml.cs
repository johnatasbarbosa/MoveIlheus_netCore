#pragma checksum "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df5461b25886a2d55c346be657772db85ee5b471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\_ViewImports.cshtml"
using MoveIlheus;

#line default
#line hidden
#line 2 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\_ViewImports.cshtml"
using MoveIlheus.Models;

#line default
#line hidden
#line 54 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5461b25886a2d55c346be657772db85ee5b471", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7cd3b48c05bf2133f429aa2d84a7d86838293c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Projeto.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Home/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Home/Mapa.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(39, 89, true);
            WriteLiteral("\r\n<link href=\"https://fonts.googleapis.com/css?family=Nunito:200,600\" rel=\"stylesheet\">\r\n");
            EndContext();
            BeginContext(128, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "df5461b25886a2d55c346be657772db85ee5b4715067", async() => {
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
            EndContext();
            BeginContext(178, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(183, 21, false);
#line 9 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
Write(Html.Partial("_Mapa"));

#line default
#line hidden
            EndContext();
            BeginContext(204, 647, true);
            WriteLiteral(@"
<div class=""flex-center position-ref full-height"">
    <div class=""content"">
        <div id=""cadastro"" class=""container"">
            <div v-if=""formulario.id != 0 && formulario.paginas.length > 0"" id=""formulario"" class=""page"" v-bind:class=""{ paginaPequena: formulario.paginas[paginaAtual].dimensao == 0, paginaMedia: formulario.paginas[paginaAtual].dimensao == 1, paginaGrande: formulario.paginas[paginaAtual].dimensao == 2, pageMin: minPage == true, overflowyauto: minPage == false }"">
                <div v-if=""formulario.paginas.length > 0"" style=""margin: 10px;"">
                    <div class=""pageHeader"">
                        ");
            EndContext();
            BeginContext(852, 27, false);
#line 16 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
                   Write(Html.Partial("_PageHeader"));

#line default
#line hidden
            EndContext();
            BeginContext(879, 112, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"pageBody\" id=\"pageBody\">\r\n                        ");
            EndContext();
            BeginContext(992, 25, false);
#line 19 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
                   Write(Html.Partial("_PageBody"));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 1033, true);
            WriteLiteral(@"
                    </div>

                    <br />
                    <div class=""pageFooter text-center"" style=""vertical-align: text-bottom;"" v-if=""formulario.paginas.length - 1 != paginaAtual"">
                        <button id=""previous"" v-on:click=""voltarPaginaAnterior()"" v-if=""paginaAtual > 0"" class=""btn btn-default""><i class=""fa fa-chevron-left""></i></button>
                        <button id=""next"" v-on:click=""avancarProximaPagina()"" v-if=""paginaAtual < formulario.paginas.length - 1 && (formulario.paginas[paginaAtual].final == false || formulario.paginas[paginaAtual].final == 'false')"" class=""btn btn-default""><i class=""fa fa-chevron-right""></i></button>
                        <button v-bind:disabled=""(conteudoEditando != -1)"" v-on:click=""finalizarFormulario()"" v-if=""formulario.paginas[paginaAtual].final == true || formulario.paginas[paginaAtual].final == 'true'"" class=""btn btn-default""><i>Finalizar</i></button>
                    </div>
                </div>
            </div>
   ");
            WriteLiteral("         ");
            EndContext();
            BeginContext(2051, 32, false);
#line 30 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
       Write(Html.Partial("_ConteudoDesenho"));

#line default
#line hidden
            EndContext();
            BeginContext(2083, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(2098, 36, false);
#line 31 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
       Write(Html.Partial("VerificarNovoDesenho"));

#line default
#line hidden
            EndContext();
            BeginContext(2134, 482, true);
            WriteLiteral(@"
            <div>
                <div id=""defineLocalizacao"" class=""form-group"" style=""position: absolute; top: 50%; left: 50%; display: none;"">
                    <button class=""btn btn-danger"" v-on:click=""cancelarDesenho()"">Cancelar</button>
                    <!-- <button class=""btn btn-success"" v-on:click=""formulario.paginas[paginaAtual].definirLocalizacao()"">Confirmar</button> -->
                </div>
            </div>
        </div>
    </div>
</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2634, 36, true);
                WriteLiteral("\r\n    <script>\r\n        var rota = \"");
                EndContext();
                BeginContext(2671, 19, false);
#line 45 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
               Write(Url.Action("Teste"));

#line default
#line hidden
                EndContext();
                BeginContext(2690, 48, true);
                WriteLiteral("\";\r\n        var urlObterFormulariòParaEditar = \"");
                EndContext();
                BeginContext(2739, 39, false);
#line 46 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
                                       Write(Url.Action("ObterFormulariòParaEditar"));

#line default
#line hidden
                EndContext();
                BeginContext(2778, 39, true);
                WriteLiteral("\";\r\n        var urlSalvarFormulario = \"");
                EndContext();
                BeginContext(2818, 30, false);
#line 47 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
                              Write(Url.Action("SalvarFormulario"));

#line default
#line hidden
                EndContext();
                BeginContext(2848, 35, true);
                WriteLiteral("\";\r\n        var urlSalvarPagina = \"");
                EndContext();
                BeginContext(2884, 26, false);
#line 48 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
                          Write(Url.Action("SalvarPagina"));

#line default
#line hidden
                EndContext();
                BeginContext(2910, 47, true);
                WriteLiteral("\";\r\n        var urlSalvarConfiguracaoPagina = \"");
                EndContext();
                BeginContext(2958, 38, false);
#line 49 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
                                      Write(Url.Action("SalvarConfiguracaoPagina"));

#line default
#line hidden
                EndContext();
                BeginContext(2996, 37, true);
                WriteLiteral("\";\r\n        var urlSalvarConteudo = \"");
                EndContext();
                BeginContext(3034, 28, false);
#line 50 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
                            Write(Url.Action("SalvarConteudo"));

#line default
#line hidden
                EndContext();
                BeginContext(3062, 46, true);
                WriteLiteral("\";\r\n        var urlSalvarRestricaoConteudo = \"");
                EndContext();
                BeginContext(3109, 37, false);
#line 51 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
                                     Write(Url.Action("SalvarRestricaoConteudo"));

#line default
#line hidden
                EndContext();
                BeginContext(3146, 42, true);
                WriteLiteral("\";\r\n        var urlFinalizarFormulario = \"");
                EndContext();
                BeginContext(3189, 33, false);
#line 52 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
                                 Write(Url.Action("FinalizarFormulario"));

#line default
#line hidden
                EndContext();
                BeginContext(3222, 6, true);
                WriteLiteral("\";\r\n\r\n");
                EndContext();
                BeginContext(3261, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 55 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
          
            JsonSerializerSettings jsSettings = new JsonSerializerSettings();
            jsSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        

#line default
#line hidden
                BeginContext(3441, 30, true);
                WriteLiteral("        var formularioModel = ");
                EndContext();
                BeginContext(3472, 73, false);
#line 59 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\Index.cshtml"
                         Write(Html.Raw(JsonConvert.SerializeObject(Model, Formatting.None, jsSettings)));

#line default
#line hidden
                EndContext();
                BeginContext(3545, 61, true);
                WriteLiteral(";\r\n        console.log(formularioModel);\r\n    </script>\r\n    ");
                EndContext();
                BeginContext(3606, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df5461b25886a2d55c346be657772db85ee5b47115006", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3648, 186, true);
                WriteLiteral("\r\n    <script src=\"https://maps.googleapis.com/maps/api/js?key=AIzaSyA881HMoL7z4WG8xPJvXNgTeywhEwxA7JQ&libraries=places,drawing&callback=initMap\"\r\n            async defer></script>\r\n    ");
                EndContext();
                BeginContext(3834, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df5461b25886a2d55c346be657772db85ee5b47116450", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3875, 211, true);
                WriteLiteral("\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'[data-toggle=\"popover\"]\').popover();\r\n            //document.getElementById(\"map\").style.display = \"block\";\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(4089, 2, true);
            WriteLiteral("\r\n");
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
