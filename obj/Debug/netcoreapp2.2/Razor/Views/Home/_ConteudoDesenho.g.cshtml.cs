#pragma checksum "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\_ConteudoDesenho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "855c235a9964bcef287081b03b8cd7632dc908b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ConteudoDesenho), @"mvc.1.0.view", @"/Views/Home/_ConteudoDesenho.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_ConteudoDesenho.cshtml", typeof(AspNetCore.Views_Home__ConteudoDesenho))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"855c235a9964bcef287081b03b8cd7632dc908b6", @"/Views/Home/_ConteudoDesenho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7cd3b48c05bf2133f429aa2d84a7d86838293c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ConteudoDesenho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1002, true);
            WriteLiteral(@"<div class=""modal fade"" id=""modalConteudoDesenho"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"" v-if=""formulario.paginas[paginaDesenho] && formulario.paginas[paginaDesenho].conteudos[conteudoSelecionado]"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">{{ formulario.paginas[paginaDesenho].conteudos[conteudoSelecionado].tituloConteudosDesenho }}</h5>
                <button type=""button"" class=""close"" aria-label=""Close"" v-on:click=""excluirDesenho()"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" style=""padding-top: unset;"">
                <div v-for=""(conteudo, index) in formulario.paginas[paginaDesenho].conteudos[conteudoSelecionado].conteudosDesenhos"">
                    <p>
                        ");
            EndContext();
            BeginContext(1003, 33, false);
#line 13 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\_ConteudoDesenho.cshtml"
                   Write(Html.Partial("_ConteudosDesenho"));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 833, true);
            WriteLiteral(@"
                    </p>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" tabindex=""-1"" class=""btn btn-danger"" v-on:click=""excluirDesenho()"">Excluir</button>
                <button type=""button"" class=""btn btn-primary"" v-if=""formulario.paginas[paginaDesenho].conteudos[conteudoSelecionado].valor != 2"" v-on:click=""formulario.paginas[paginaDesenho].conteudos[conteudoSelecionado].salvarRespostasDesenho()"">Save change</button>
                <button type=""button"" class=""btn btn-primary"" v-if=""formulario.paginas[paginaDesenho].conteudos[conteudoSelecionado].valor == 2"" v-on:click=""formulario.paginas[paginaDesenho].conteudos[conteudoSelecionado].salvarRespostasDesenhos()"">Save changes</button>
            </div>
        </div>
    </div>
</div>
");
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
