#pragma checksum "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cae3cf88734af4d3bf20a0fabd56bd1550c8441"
// <auto-generated/>
#pragma warning disable 1591
namespace GettingReady.Pages.Admin.Alunos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\_Imports.razor"
using GettingReady;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\_Imports.razor"
using GettingReady.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Alunos/Detail/{AlunoId:int}")]
    public partial class Details : DetailsPage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <h1>Detalhe</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""Admin/Alunos/List"">Alunos</a></li>
                    <li class=""breadcrumb-item active"">Info</li>
                </ol>
            </div>
        </div>
    </div>
</section>
");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "content");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<div class=\"card-header\">\r\n                <h3 class=\"card-title\">\r\n                    <i class=\"fa fa-user\"></i>\r\n                    <b class=\"ml-3\" style=\"font-size:15pt\">Dados do aluno</b>\r\n                </h3>\r\n            </div>\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 29 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Details.razor"
                 if (Aluno.AlunoInfo != null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-sm-4 mb-3");
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.AddMarkupContent(21, "<label for=\"Matricula\">Matricula</label>\r\n                            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "id", "Matricula");
            __builder.AddContent(24, 
#nullable restore
#line 34 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Details.razor"
                                                 Aluno.AlunoInfo.Matricula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-sm-4 mb-3");
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.AddMarkupContent(30, "<label for=\"Nome\">Nome</label>\r\n                            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "id", "Nome");
            __builder.AddContent(33, 
#nullable restore
#line 38 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Details.razor"
                                            Aluno.AlunoInfo.Nome.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n                        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-sm-4 mb-3");
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.AddMarkupContent(39, "<label for=\"Curso\">Curso</label>\r\n                            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "id", "Curso");
            __builder.AddContent(42, 
#nullable restore
#line 43 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Details.razor"
                                             Aluno.AlunoInfo.Curso.Nome.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Details.razor"
                          }

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "card card-widget collapsed-card");
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 47 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Details.razor"
                     if (Aluno.Disciplinas != null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "card-header bg-gradient-info");
            __builder.AddAttribute(52, "data-card-widget", "collapse");
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "user-block");
            __builder.AddMarkupContent(56, "\r\n                                <i class=\"ion ion-ios-book-outline mr-2\"></i> Cursando ");
            __builder.OpenElement(57, "b");
            __builder.AddContent(58, 
#nullable restore
#line 51 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Details.razor"
                                                                                           Aluno.Disciplinas.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "  disciplinas\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                            \r\n                            ");
            __builder.AddMarkupContent(61, @"<div class=""card-tools"">
                                <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                    <i class=""fas fa-plus""></i>
                                </button>
                            </div>
                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, " \r\n                        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "card-body");
            __builder.AddMarkupContent(65, "\r\n                            ");
            __builder.OpenElement(66, "table");
            __builder.AddAttribute(67, "id", "example2");
            __builder.AddAttribute(68, "class", "table table-striped table-bordered dataTable");
            __builder.AddMarkupContent(69, "\r\n                                ");
            __builder.AddMarkupContent(70, @"<thead>
                                    <tr>
                                        <th>Cód. Disciplina</th>
                                        <th> Disciplina</th>
                                        <th>Curso</th>
                                    </tr>
                                </thead>
                                ");
            __builder.OpenElement(71, "tbody");
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 70 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Details.razor"
                                     foreach (var disciplina in Aluno.Disciplinas)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "                                        ");
            __builder.OpenElement(74, "tr");
            __builder.AddMarkupContent(75, "\r\n                                            ");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 73 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Details.razor"
                                                 disciplina.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                                            ");
            __builder.OpenElement(79, "td");
            __builder.AddContent(80, 
#nullable restore
#line 74 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Details.razor"
                                                 disciplina.Nome.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                            ");
            __builder.OpenElement(82, "td");
            __builder.AddContent(83, 
#nullable restore
#line 75 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Details.razor"
                                                 Aluno.AlunoInfo.Curso.Nome.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
#nullable restore
#line 77 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Details.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddContent(89, " ");
#nullable restore
#line 80 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Details.razor"
                                                     }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, " \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
