#pragma checksum "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\_PageBody.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd5bdfe5ed3f8c5fd71efc371d523ec842f13321"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__PageBody), @"mvc.1.0.view", @"/Views/Home/_PageBody.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_PageBody.cshtml", typeof(AspNetCore.Views_Home__PageBody))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd5bdfe5ed3f8c5fd71efc371d523ec842f13321", @"/Views/Home/_PageBody.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7cd3b48c05bf2133f429aa2d84a7d86838293c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__PageBody : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 163, true);
            WriteLiteral("<div v-for=\"(conteudo, index) in formulario.paginas[paginaAtual].conteudos\" style=\"padding: 2%;\" class=\"col-sm-12\" v-if=\"conteudo.restricoesValidas == true\">\r\n    ");
            EndContext();
            BeginContext(164, 26, false);
#line 2 "C:\Users\johna\Documents\MoveIlheus\MoveIlheus\Views\Home\_PageBody.cshtml"
Write(Html.Partial("_Conteudos"));

#line default
#line hidden
            EndContext();
            BeginContext(190, 8, true);
            WriteLiteral("\r\n</div>");
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
