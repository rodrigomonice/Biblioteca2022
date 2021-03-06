#pragma checksum "C:\Users\digao\Desktop\Senac_TI_internet\Unidade Curricular 7\Atividades\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "824ed558d09bc96de51df8650bcc313000132a3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListaDeUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListaDeUsuarios.cshtml")]
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
#line 1 "C:\Users\digao\Desktop\Senac_TI_internet\Unidade Curricular 7\Atividades\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\digao\Desktop\Senac_TI_internet\Unidade Curricular 7\Atividades\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"824ed558d09bc96de51df8650bcc313000132a3e", @"/Views/Usuario/ListaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Usuários cadastrados no sistema</h1>\r\n<p class=\"text-danger\">");
#nullable restore
#line 3 "C:\Users\digao\Desktop\Senac_TI_internet\Unidade Curricular 7\Atividades\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
                  Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"row\">Nome</th>\r\n            <th scope=\"row\">Login</th>\r\n            <th scope=\"row\">Tipo</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\digao\Desktop\Senac_TI_internet\Unidade Curricular 7\Atividades\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\digao\Desktop\Senac_TI_internet\Unidade Curricular 7\Atividades\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\digao\Desktop\Senac_TI_internet\Unidade Curricular 7\Atividades\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 18 "C:\Users\digao\Desktop\Senac_TI_internet\Unidade Curricular 7\Atividades\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
                 if (u.Tipo == Usuario.ADMIN)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Administrador</td>\r\n");
#nullable restore
#line 21 "C:\Users\digao\Desktop\Senac_TI_internet\Unidade Curricular 7\Atividades\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Padrão</td>\r\n");
#nullable restore
#line 25 "C:\Users\digao\Desktop\Senac_TI_internet\Unidade Curricular 7\Atividades\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><a");
            BeginWriteAttribute("href", " href=\"", 709, "\"", 738, 2);
            WriteAttributeValue("", 716, "editarUsuario?id=", 716, 17, true);
#nullable restore
#line 26 "C:\Users\digao\Desktop\Senac_TI_internet\Unidade Curricular 7\Atividades\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 733, u.Id, 733, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 779, "\"", 809, 2);
            WriteAttributeValue("", 786, "ExcluirUsuario?id=", 786, 18, true);
#nullable restore
#line 27 "C:\Users\digao\Desktop\Senac_TI_internet\Unidade Curricular 7\Atividades\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 804, u.Id, 804, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">excluir</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\digao\Desktop\Senac_TI_internet\Unidade Curricular 7\Atividades\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"RegistrarUsuarios\">Registrar novo usuário</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
