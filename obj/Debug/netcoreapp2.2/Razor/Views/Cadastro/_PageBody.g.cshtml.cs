#pragma checksum "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/_PageBody.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a32f4c69f9045b1eb8de96b931decddafdfc2a9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro__PageBody), @"mvc.1.0.view", @"/Views/Cadastro/_PageBody.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastro/_PageBody.cshtml", typeof(AspNetCore.Views_Cadastro__PageBody))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a32f4c69f9045b1eb8de96b931decddafdfc2a9f", @"/Views/Cadastro/_PageBody.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7cd3b48c05bf2133f429aa2d84a7d86838293c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro__PageBody : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1596, true);
            WriteLiteral(@"<div v-for=""(conteudo, index) in formulario.paginas[paginaAtual].conteudos"" :key=""index"" style=""padding: 2%;"" class=""list-group-item col-sm-12"" v-on:mouseenter=""mouseEnter(index)"" v-on:mouseleave=""mouseLeave(index)"" v-bind:class=""{ hoverQuestion: editando[index], editingQuestion: index == conteudoEditando }"">
    <h5 class=""questionHeader col-sm-12"" style=""z-index: 1;"">
        <span style=""float: right;"" v-if=""conteudoEditando == index || conteudoEditando == -1"">
            <span v-if=""index == conteudoEditando && editando[index]"">
                <input type=""checkbox"" v-model=""conteudo.obrigatorio"" />
            </span>
            <span v-if=""index == conteudoEditando && editando[index] && conteudo.tipo == 11"" class=""fa fa-cogs btnEdit"" data-toggle=""modal"" data-target=""#modalConteudoDesenho""></span>
            <span v-if=""index == conteudoEditando && editando[index]"" class=""fa fa-cog btnEdit"" data-toggle=""modal"" data-target=""#modalRestricao""></span>
            <span v-if=""index == conteudoEdit");
            WriteLiteral(@"ando && editando[index]"" class=""fa fa-trash btnEdit"" v-on:click=""formulario.paginas[paginaAtual].excluirConteudo(conteudo, index)""></span>
            <span v-if=""index != conteudoEditando && editando[index]"" class=""fa fa-edit btnEdit"" v-on:click=""editarConteudo(index)""></span>
            <span v-if=""index == conteudoEditando"" class=""fa fa-check btnEdit"" v-on:click=""conteudo.salvar(formulario.paginas[paginaAtual].id)""></span>
            <span v-if=""index != conteudoEditando"" class=""handle""><i class=""fa fa-align-justify""></i></span>
        </span>
    </h5>
");
            EndContext();
            BeginContext(1612, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1617, 26, false);
#line 16 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/_PageBody.cshtml"
Write(Html.Partial("_Conteudos"));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1688, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1693, 26, false);
#line 18 "/home/johnatas/Documentos/Projetos/MoveIlheus/Views/Cadastro/_PageBody.cshtml"
Write(Html.Partial("_Restricao"));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 858, true);
            WriteLiteral(@"
</div>
<div v-if=""conteudoEditando == -1"" class=""col-sm-12"">
    <div class=""btn-group dropright"" id=""novoConteudo"">
        <button onclick=""redimensionarPage()"" v-on:click=""adicionandoConteudo = !adicionandoConteudo"" type=""button"" class=""btn btn-primary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            <span class=""fa fa-plus""></span>
            Adicionar Conteúdo
        </button>
        <div class=""dropdown-menu"">
            <a v-for=""opcao in options"" v-on:click=""selecionarTipoConteudo(opcao.value)"" :value=""opcao"" class=""dropdown-item"" href=""#"">{{ opcao.text }}</a>
        </div>
    </div>
</div>

<script>
    function redimensionarPage() {
        //var pageHeight = $("".page"").height();
        //if (pageHeight < 350)
        //    $("".page"").height(350);
    }
</script>");
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
