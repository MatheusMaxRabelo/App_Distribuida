#pragma checksum "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e510100b281a3ec15dbebae8c687ae30d3575fb"
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
#line 1 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\_Imports.razor"
using GettingReady;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\_Imports.razor"
using GettingReady.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\_Imports.razor"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Alunos/List")]
    public partial class List : ListPage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <h1>Todos os alunos</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item active"">Alunos</li>
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
            __builder.AddMarkupContent(10, @"<div class=""card-header"">
                    <h3 class=""card-title"">
                        <i class=""fa fa-list""></i>
                        <b class=""ml-3"" style=""font-size:15pt"">Lista de alunos</b>
                    </h3>
                        <a href=""/Admin/Alunos/Create"" class=""btn btn-info btn-sm"" style=""float:right""><span><i class=""fa fa-plus""></i> Adicionar </span></a>
            </div>
            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 29 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                 if (Alunos.Count > 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                    ");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "id", "example2");
            __builder.AddAttribute(17, "class", "table table-striped table-bordered dataTable");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "thead");
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n                                ");
            __builder.OpenElement(23, "th");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                () => SortTable("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "Matrícula ");
            __builder.OpenElement(26, "span");
            __builder.AddAttribute(27, "class", "fa" + " " + (
#nullable restore
#line 34 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                           SortIcon("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                ");
            __builder.OpenElement(29, "th");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                () => SortTable("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Nome ");
            __builder.OpenElement(32, "span");
            __builder.AddAttribute(33, "class", "fa" + " " + (
#nullable restore
#line 35 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                 SortIcon("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                ");
            __builder.OpenElement(35, "th");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                () => SortTable("Curso")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Curso ");
            __builder.OpenElement(38, "span");
            __builder.AddAttribute(39, "class", "fa" + " " + (
#nullable restore
#line 36 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                   SortIcon("Curso")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                                <th></th>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "tbody");
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 41 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                             foreach (var Aluno in Alunos)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                                ");
            __builder.OpenElement(46, "tr");
            __builder.AddMarkupContent(47, "\r\n                                        ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 44 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                             Aluno.Matricula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                                        ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 45 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                             Aluno.Nome.ToUpperInvariant()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                                        ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 46 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                             Aluno.Curso.Nome.ToUpperInvariant()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                                        ");
            __builder.OpenElement(57, "td");
            __builder.AddAttribute(58, "style", "width:105px;");
            __builder.AddMarkupContent(59, "\r\n                                            ");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "type", "button");
            __builder.AddAttribute(62, "class", "btn btn-outline-info btn-sm");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                                 (()=>NavigateTo(Aluno.Matricula))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "<span><i class=\"fa fa-eye\"></i></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                                            ");
            __builder.AddMarkupContent(66, "<button type=\"button\" class=\"btn btn-outline-warning btn-sm\"><span><i class=\"fa fa-edit\"></i></span></button>\r\n                                            ");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "type", "button");
            __builder.AddAttribute(69, "class", "btn btn-outline-danger btn-sm");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                                  (()=>ConfirmDelete(Aluno.Matricula,Aluno.Nome))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(71, "<span><i class=\"fa fa-trash\"></i></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 53 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 56 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                 if (Alunos.Count == 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "                    ");
            __builder.AddMarkupContent(79, "<p class>Nenhum aluno cadastrado!</p>\r\n                    ");
            __builder.OpenElement(80, "table");
            __builder.AddAttribute(81, "id", "example2");
            __builder.AddAttribute(82, "class", " mt-4 table table-striped table-bordered dataTable");
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.OpenElement(84, "thead");
            __builder.AddMarkupContent(85, "\r\n                            ");
            __builder.OpenElement(86, "tr");
            __builder.AddMarkupContent(87, "\r\n                                ");
            __builder.OpenElement(88, "th");
            __builder.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                () => SortTable("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(90, "Matrícula ");
            __builder.OpenElement(91, "span");
            __builder.AddAttribute(92, "class", "fa" + " " + (
#nullable restore
#line 63 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                           SortIcon("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                                ");
            __builder.OpenElement(94, "th");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                () => SortTable("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(96, "Nome ");
            __builder.OpenElement(97, "span");
            __builder.AddAttribute(98, "class", "fa" + " " + (
#nullable restore
#line 64 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                 SortIcon("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                                ");
            __builder.OpenElement(100, "th");
            __builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                () => SortTable("Email")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(102, "Curso ");
            __builder.OpenElement(103, "span");
            __builder.AddAttribute(104, "class", "fa" + " " + (
#nullable restore
#line 65 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                   SortIcon("Curso")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                                <th></th>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n");
#nullable restore
#line 70 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                 if(Alunos ==null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(109, "                    ");
            __builder.AddMarkupContent(110, "<p class>Buscando alunos aguarde...</p>\r\n");
#nullable restore
#line 74 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(111, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
