#pragma checksum "C:\Users\gabre\source\repos\CarrosMotosBob\Views\BaseClientes\Anuncios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e143cba32e9bc5471c51fd115bd7c24db66a72ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaseClientes_Anuncios), @"mvc.1.0.view", @"/Views/BaseClientes/Anuncios.cshtml")]
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
#line 1 "C:\Users\gabre\source\repos\CarrosMotosBob\Views\_ViewImports.cshtml"
using CarrosMotosBob;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gabre\source\repos\CarrosMotosBob\Views\_ViewImports.cshtml"
using CarrosMotosBob.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e143cba32e9bc5471c51fd115bd7c24db66a72ca", @"/Views/BaseClientes/Anuncios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f392620dbb6891e9ab1b62c5c67d801f203a0df7", @"/Views/_ViewImports.cshtml")]
    public class Views_BaseClientes_Anuncios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarrosMotosBob.Models.BaseClientes.AnuncioIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gabre\source\repos\CarrosMotosBob\Views\BaseClientes\Anuncios.cshtml"
  
    ViewBag.Nome = @Model.Anuncios.First().NomeCliente;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"anuncios\">\r\n    <h3>Lista anuncios do ");
#nullable restore
#line 7 "C:\Users\gabre\source\repos\CarrosMotosBob\Views\BaseClientes\Anuncios.cshtml"
                     Write(ViewBag.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h3>
    <div id=""clientesTable"">
        <table class=""table table-condensed"" id=""anunciosPorClienteIndexTable"">
            <thead>
            <tr>
                <th>Ano Do Veiculo</th>
                <th>Modelo</th>
                <th>Descricao</th>
                <th>Status</th>
                <th> </th>
                <th> </th>

            </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 22 "C:\Users\gabre\source\repos\CarrosMotosBob\Views\BaseClientes\Anuncios.cshtml"
             foreach (var anuncio in @Model.Anuncios)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"clienteRow\">\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 742, "\"", 750, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\gabre\source\repos\CarrosMotosBob\Views\BaseClientes\Anuncios.cshtml"
                            Write(anuncio.Ano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 794, "\"", 802, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\gabre\source\repos\CarrosMotosBob\Views\BaseClientes\Anuncios.cshtml"
                            Write(anuncio.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 849, "\"", 857, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\gabre\source\repos\CarrosMotosBob\Views\BaseClientes\Anuncios.cshtml"
                            Write(anuncio.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 29 "C:\Users\gabre\source\repos\CarrosMotosBob\Views\BaseClientes\Anuncios.cshtml"
                     switch (@anuncio.Status)
                    {
                        case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Publicado</td>\r\n");
#nullable restore
#line 33 "C:\Users\gabre\source\repos\CarrosMotosBob\Views\BaseClientes\Anuncios.cshtml"
                            break;
                        case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Em análise</td>\r\n");
#nullable restore
#line 36 "C:\Users\gabre\source\repos\CarrosMotosBob\Views\BaseClientes\Anuncios.cshtml"
                            break;
                        case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Expirados</td>\r\n");
#nullable restore
#line 39 "C:\Users\gabre\source\repos\CarrosMotosBob\Views\BaseClientes\Anuncios.cshtml"
                            break;
                        default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Fora De Status</td>\r\n");
#nullable restore
#line 42 "C:\Users\gabre\source\repos\CarrosMotosBob\Views\BaseClientes\Anuncios.cshtml"
                            break;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td");
            BeginWriteAttribute("class", " class=\"", 1477, "\"", 1485, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <button type=\"button\" class=\"btn btn-success\">Analter</button>\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1627, "\"", 1635, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <button type=\"button\" class=\"btn btn-danger\">Exluir</button>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\gabre\source\repos\CarrosMotosBob\Views\BaseClientes\Anuncios.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarrosMotosBob.Models.BaseClientes.AnuncioIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
