#pragma checksum "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Cadastro\_PageHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aae33b6db33c37d4eaa979e2a1f0edcfc702c5f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro__PageHeader), @"mvc.1.0.view", @"/Views/Cadastro/_PageHeader.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastro/_PageHeader.cshtml", typeof(AspNetCore.Views_Cadastro__PageHeader))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae33b6db33c37d4eaa979e2a1f0edcfc702c5f5", @"/Views/Cadastro/_PageHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7cd3b48c05bf2133f429aa2d84a7d86838293c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro__PageHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 631, true);
            WriteLiteral(@"<div class=""input-group"">
    <h2>
        <span v-if=""editandoTitulo == false"">
            {{ formulario.paginas[paginaAtual].titulo }}
        </span>
        <input v-if=""editandoTitulo == true"" v-model=""formulario.paginas[paginaAtual].titulo"" type=""text"" class=""form-control"">
    </h2>
    <h3>
        <span v-if=""editandoTitulo == false"" class=""fa fa-edit btnEdit"" v-on:click=""editandoTitulo = !editandoTitulo""></span>
        <span v-if=""editandoTitulo == true"" class=""fa fa-check btnEdit"" v-on:click=""editandoTitulo = !editandoTitulo; formulario.paginas[paginaAtual].salvarPagina();""></span>
    </h3>
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
