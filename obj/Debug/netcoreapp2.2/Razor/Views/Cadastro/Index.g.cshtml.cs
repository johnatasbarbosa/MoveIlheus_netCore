#pragma checksum "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb83dec23e4fe0a8082d7a6be4ffbd2d6e6d1f6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_Index), @"mvc.1.0.view", @"/Views/Cadastro/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastro/Index.cshtml", typeof(AspNetCore.Views_Cadastro_Index))]
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
#line 1 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/_ViewImports.cshtml"
using MoveIlheus;

#line default
#line hidden
#line 2 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/_ViewImports.cshtml"
using MoveIlheus.Models;

#line default
#line hidden
#line 85 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb83dec23e4fe0a8082d7a6be4ffbd2d6e6d1f6f", @"/Views/Cadastro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7cd3b48c05bf2133f429aa2d84a7d86838293c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Projeto.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/Plugins/sortable.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/Plugins/vuedraggable.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Cadastro/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Cadastro/Mapa.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(39, 87, true);
            WriteLiteral("<link href=\"https://fonts.googleapis.com/css?family=Nunito:200,600\" rel=\"stylesheet\">\r\n");
            EndContext();
            BeginContext(126, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fb83dec23e4fe0a8082d7a6be4ffbd2d6e6d1f6f5771", async() => {
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
            BeginContext(180, 793, true);
            WriteLiteral(@"

<style>
    #map {
        position: unset !important;
        /*overflow: initial !important;
        width: 100%;*/
        height: 100%;
    }
</style>

<div id=""map"" style=""display: none;""></div>
<div class=""flex-center position-ref full-height"">
    <div class=""content"">
        <div id=""cadastro"" class=""container"">
            <div v-if=""formulario.id == 0"">
                <div>
                    <label>Ainda não há um formulario existente</label>
                    <input v-model=""formulario.nome"" class=""form-control"" />
                    <button v-on:click=""salvarFormulario"" class=""btn btn-primary"">Adicionar Formulário</button>
                </div>
            </div>
            <div v-if=""formulario.id != 0"" id=""formulario"">
                ");
            EndContext();
            BeginContext(974, 35, false);
#line 29 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
           Write(Html.Partial("_ConfiguracaoPagina"));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 1145, true);
            WriteLiteral(@"
                <h3 v-if=""editandoTitulo == false"" style=""position: absolute; top: 5%; left: 1%;"">
                    <span class=""fa fa-plus btnEdit"" title=""Nova página"" v-on:click=""formulario.novaPagina()""></span>
                    <span class=""fa fa-copy btnEdit"" title=""Duplicar página"" v-on:click=""formulario.duplicarPagina()""></span>
                    <span class=""fa fa-cog btnEdit"" title=""Configurações da página"" data-toggle=""modal"" data-target=""#configuracoesPagina""></span>
                    <span class=""fa fa-trash btnEdit"" title=""Excluri página"" v-on:click=""formulario.excluirPagina(paginaAtual)""></span>
                </h3>
                <div class=""row"">
                    <div class=""page"" v-if=""formulario.paginas.length > 0"" v-bind:class=""{ paginaPequena: formulario.paginas[paginaAtual].dimensao == 0, paginaMedia: formulario.paginas[paginaAtual].dimensao == 1, paginaGrande: formulario.paginas[paginaAtual].dimensao == 2 }"">
                        <div v-if=""formulario.paginas.l");
            WriteLiteral("ength > 0\" style=\"margin: 10px;\">\r\n                            <div class=\"pageHeader\">\r\n                                ");
            EndContext();
            BeginContext(2155, 27, false);
#line 40 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                           Write(Html.Partial("_PageHeader"));

#line default
#line hidden
            EndContext();
            BeginContext(2182, 352, true);
            WriteLiteral(@"
                            </div>
                            <div class=""pageBody row"">
                                <draggable :list=""formulario.paginas[paginaAtual].conteudos"" :options=""{handle:'.handle'}"" v-on:change=""formulario.paginas[paginaAtual].atualizarSequenciaConteudos()"" style=""width: 100%;"">
                                    ");
            EndContext();
            BeginContext(2535, 25, false);
#line 44 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                               Write(Html.Partial("_PageBody"));

#line default
#line hidden
            EndContext();
            BeginContext(2560, 114, true);
            WriteLiteral("\r\n                                </draggable>\r\n                            </div>\r\n\r\n                            ");
            EndContext();
            BeginContext(2675, 32, false);
#line 48 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                       Write(Html.Partial("_ConteudoDesenho"));

#line default
#line hidden
            EndContext();
            BeginContext(2707, 1182, true);
            WriteLiteral(@"

                            <div class=""pageFooter text-center"" style=""vertical-align: text-bottom;"">
                                <button v-bind:disabled=""(conteudoEditando != -1)"" v-on:click=""paginaAtual = paginaAtual - 1"" v-if=""paginaAtual > 0"" class=""btn btn-default""><i class=""fa fa-chevron-left""></i></button>
                                <button v-bind:disabled=""(conteudoEditando != -1)"" v-on:click=""paginaAtual = paginaAtual + 1"" v-if=""paginaAtual < formulario.paginas.length - 1"" class=""btn btn-default""><i class=""fa fa-chevron-right""></i></button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div>
                <div id=""defineLocalizacao"" class=""form-group"" style=""position: absolute; top: 50%; left: 50%; display: none;"">
                    <button class=""btn btn-default"" v-on:click=""mostrarFormulario()"">Voltar</button>
                    <button class=""btn btn-success"" v-on:click");
            WriteLiteral("=\"formulario.paginas[paginaAtual].definirLocalizacao()\">Confirmar</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3907, 36, true);
                WriteLiteral("\r\n    <script>\r\n        var rota = \"");
                EndContext();
                BeginContext(3944, 19, false);
#line 70 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
               Write(Url.Action("Teste"));

#line default
#line hidden
                EndContext();
                BeginContext(3963, 48, true);
                WriteLiteral("\";\r\n        var urlObterFormulariòParaEditar = \"");
                EndContext();
                BeginContext(4012, 39, false);
#line 71 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                                       Write(Url.Action("ObterFormulariòParaEditar"));

#line default
#line hidden
                EndContext();
                BeginContext(4051, 39, true);
                WriteLiteral("\";\r\n        var urlSalvarFormulario = \"");
                EndContext();
                BeginContext(4091, 30, false);
#line 72 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                              Write(Url.Action("SalvarFormulario"));

#line default
#line hidden
                EndContext();
                BeginContext(4121, 35, true);
                WriteLiteral("\";\r\n        var urlSalvarPagina = \"");
                EndContext();
                BeginContext(4157, 26, false);
#line 73 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                          Write(Url.Action("SalvarPagina"));

#line default
#line hidden
                EndContext();
                BeginContext(4183, 36, true);
                WriteLiteral("\";\r\n        var urlExcluirPagina = \"");
                EndContext();
                BeginContext(4220, 27, false);
#line 74 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                           Write(Url.Action("ExcluirPagina"));

#line default
#line hidden
                EndContext();
                BeginContext(4247, 47, true);
                WriteLiteral("\";\r\n        var urlSalvarConfiguracaoPagina = \"");
                EndContext();
                BeginContext(4295, 38, false);
#line 75 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                                      Write(Url.Action("SalvarConfiguracaoPagina"));

#line default
#line hidden
                EndContext();
                BeginContext(4333, 37, true);
                WriteLiteral("\";\r\n        var urlSalvarConteudo = \"");
                EndContext();
                BeginContext(4371, 28, false);
#line 76 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                            Write(Url.Action("SalvarConteudo"));

#line default
#line hidden
                EndContext();
                BeginContext(4399, 50, true);
                WriteLiteral("\";\r\n        var urlAtualizarSequenciaConteudos = \"");
                EndContext();
                BeginContext(4450, 41, false);
#line 77 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                                         Write(Url.Action("AtualizarSequenciaConteudos"));

#line default
#line hidden
                EndContext();
                BeginContext(4491, 38, true);
                WriteLiteral("\";\r\n        var urlExcluirConteudo = \"");
                EndContext();
                BeginContext(4530, 29, false);
#line 78 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                             Write(Url.Action("ExcluirConteudo"));

#line default
#line hidden
                EndContext();
                BeginContext(4559, 39, true);
                WriteLiteral("\";\r\n        var urlSalvarNovaPagina = \"");
                EndContext();
                BeginContext(4599, 30, false);
#line 79 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                              Write(Url.Action("SalvarNovaPagina"));

#line default
#line hidden
                EndContext();
                BeginContext(4629, 68, true);
                WriteLiteral("\";\r\n        \r\n        var urlAtualizarSequenciaConteudosDesenhos = \"");
                EndContext();
                BeginContext(4698, 49, false);
#line 81 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                                                 Write(Url.Action("AtualizarSequenciaConteudosDesenhos"));

#line default
#line hidden
                EndContext();
                BeginContext(4747, 44, true);
                WriteLiteral("\";\r\n        var urlSalvarConteudoDesenho = \"");
                EndContext();
                BeginContext(4792, 35, false);
#line 82 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                                   Write(Url.Action("SalvarConteudoDesenho"));

#line default
#line hidden
                EndContext();
                BeginContext(4827, 45, true);
                WriteLiteral("\";\r\n        var urlExcluirConteudoDesenho = \"");
                EndContext();
                BeginContext(4873, 36, false);
#line 83 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                                    Write(Url.Action("ExcluirConteudoDesenho"));

#line default
#line hidden
                EndContext();
                BeginContext(4909, 6, true);
                WriteLiteral("\";\r\n\r\n");
                EndContext();
                BeginContext(4948, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 86 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
          
            JsonSerializerSettings jsSettings = new JsonSerializerSettings();
            jsSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        

#line default
#line hidden
                BeginContext(5128, 30, true);
                WriteLiteral("        var formularioModel = ");
                EndContext();
                BeginContext(5159, 73, false);
#line 90 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/Index.cshtml"
                         Write(Html.Raw(JsonConvert.SerializeObject(Model, Formatting.None, jsSettings)));

#line default
#line hidden
                EndContext();
                BeginContext(5232, 69, true);
                WriteLiteral(";\r\n        console.log(formularioModel);        \r\n    </script>\r\n    ");
                EndContext();
                BeginContext(5301, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb83dec23e4fe0a8082d7a6be4ffbd2d6e6d1f6f18861", async() => {
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
                BeginContext(5354, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5360, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb83dec23e4fe0a8082d7a6be4ffbd2d6e6d1f6f20099", async() => {
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
                BeginContext(5417, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5423, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb83dec23e4fe0a8082d7a6be4ffbd2d6e6d1f6f21337", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5469, 186, true);
                WriteLiteral("\r\n    <script src=\"https://maps.googleapis.com/maps/api/js?key=AIzaSyA881HMoL7z4WG8xPJvXNgTeywhEwxA7JQ&libraries=places,drawing&callback=initMap\"\r\n            async defer></script>\r\n    ");
                EndContext();
                BeginContext(5655, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb83dec23e4fe0a8082d7a6be4ffbd2d6e6d1f6f22763", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5700, 140, true);
                WriteLiteral("\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'[data-toggle=\"popover\"]\').popover();\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
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
