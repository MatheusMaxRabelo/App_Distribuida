#pragma checksum "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Alunos\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b525937b9453783cee848158d9f14ed14a9c58c3"
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
#line 1 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\_Imports.razor"
using GettingReady;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\_Imports.razor"
using GettingReady.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\_Imports.razor"
using GettingReady.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\_Imports.razor"
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
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "\n            ");
            __builder.AddMarkupContent(10, "<div class=\"card-header\">\n                <h3 class=\"card-title\">\n                    <i class=\"fa fa-user\"></i>\n                    <b class=\"ml-3\" style=\"font-size:15pt\">Dados do aluno</b>\n                </h3>\n            </div>\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-sm-4 mb-3");
            __builder.AddMarkupContent(19, "\n                        ");
            __builder.AddMarkupContent(20, "<label for=\"Matricula\">Matricula</label>\n                        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "id", "Matricula");
            __builder.AddContent(23, 
#nullable restore
#line 32 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Alunos\Details.razor"
                                             Aluno.AlunoInfo.Matricula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-sm-4 mb-3");
            __builder.AddMarkupContent(28, "\n                        ");
            __builder.AddMarkupContent(29, "<label for=\"Nome\">Nome</label>\n                        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "id", "Nome");
            __builder.AddContent(32, 
#nullable restore
#line 36 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Alunos\Details.razor"
                                        Aluno.AlunoInfo.Nome.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n\n                    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-sm-4 mb-3");
            __builder.AddMarkupContent(37, "\n                        ");
            __builder.AddMarkupContent(38, "<label for=\"Curso\">Curso</label>\n                        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "id", "Curso");
            __builder.AddContent(41, 
#nullable restore
#line 41 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Alunos\Details.razor"
                                         Aluno.AlunoInfo.areaConhecimento.Nome.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                    \n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "card card-widget collapsed-card");
            __builder.AddMarkupContent(47, "\n                    ");
            __builder.AddMarkupContent(48, @"<div class=""card-header bg-info"">
                        <div class=""user-block"">
                            <i class=""ion ion-ios-paper-outline mr-2""></i>Disciplinas
                        </div>
                        
                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-plus""></i>
                            </button>
                        </div>
                    </div>
                    
                    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "card-body");
            __builder.AddMarkupContent(51, "\n                        ");
            __builder.OpenElement(52, "table");
            __builder.AddAttribute(53, "id", "example2");
            __builder.AddAttribute(54, "class", "table table-striped table-bordered dataTable");
            __builder.AddMarkupContent(55, "\n                            ");
            __builder.AddMarkupContent(56, @"<thead>
                                <tr>
                                    <th>Cód. Disciplina</th>
                                    <th> Disciplina</th>
                                    <th>Curso</th>
                                </tr>
                            </thead>
                            ");
            __builder.OpenElement(57, "tbody");
            __builder.AddMarkupContent(58, "\n");
#nullable restore
#line 68 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Alunos\Details.razor"
                                 foreach (var disciplina in Aluno.Disciplinas)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "                                    ");
            __builder.OpenElement(60, "tr");
            __builder.AddMarkupContent(61, "\n                                        ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 71 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Alunos\Details.razor"
                                             disciplina.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n                                        ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 72 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Alunos\Details.razor"
                                             disciplina.Nome.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n                                        ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 73 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Alunos\Details.razor"
                                             disciplina.areaConhecimento.Nome.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\n");
#nullable restore
#line 75 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Alunos\Details.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n                    \n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\n\n        \n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
