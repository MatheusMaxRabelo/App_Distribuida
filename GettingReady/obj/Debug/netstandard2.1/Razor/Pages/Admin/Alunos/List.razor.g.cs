#pragma checksum "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "870b198de06e7e0a90583d1d5190bb02ac8d693c"
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
                <a href=""/Admin/Alunos/Create"" class=""btn btn-info btn-sm"" style=""float:right""><span><i class=""fa fa-plus mr-1""></i>Adicionar</span></a>
            </div>
            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "style", 
#nullable restore
#line 29 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                              MessageColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, 
#nullable restore
#line 29 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                             Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 30 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                 if (Alunos.Count > 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                    ");
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "id", "example2");
            __builder.AddAttribute(21, "class", "table table-striped table-bordered dataTable");
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "thead");
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\r\n                                ");
            __builder.OpenElement(27, "th");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                () => SortTable("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "Matrícula ");
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "class", "fa" + " " + (
#nullable restore
#line 35 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                           SortIcon("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                                ");
            __builder.OpenElement(33, "th");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                () => SortTable("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Nome ");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "fa" + " " + (
#nullable restore
#line 36 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                 SortIcon("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                ");
            __builder.OpenElement(39, "th");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                () => SortTable("Curso")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Curso ");
            __builder.OpenElement(42, "span");
            __builder.AddAttribute(43, "class", "fa" + " " + (
#nullable restore
#line 37 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                   SortIcon("Curso")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                <th></th>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.OpenElement(47, "tbody");
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 42 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                             foreach (var Aluno in Alunos)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                                ");
            __builder.OpenElement(50, "tr");
            __builder.AddMarkupContent(51, "\r\n                                    ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 45 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                         Aluno.Matricula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                    ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 46 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                         Aluno.Nome.ToUpperInvariant()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                    ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 47 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                         Aluno.Curso.Nome.ToUpperInvariant()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                                    ");
            __builder.OpenElement(61, "td");
            __builder.AddAttribute(62, "style", "width:105px;");
            __builder.AddMarkupContent(63, "\r\n                                        ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "class", "btn btn-outline-info btn-sm");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                            (()=>NavigateTo(Aluno.Matricula))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(68, "<span><i class=\"fa fa-eye\"></i></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                                        ");
            __builder.AddMarkupContent(70, "<button type=\"button\" class=\"btn btn-outline-warning btn-sm\"><span><i class=\"fa fa-edit\"></i></span></button>\r\n                                        ");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "type", "button");
            __builder.AddAttribute(73, "class", "btn btn-outline-danger btn-sm");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                              (()=>ConfirmDelete(Aluno.Matricula,Aluno.Nome))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(75, "<span><i class=\"fa fa-trash\"></i></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 54 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.AddMarkupContent(82, @"<nav aria-label=""Page navigation example"">
                        <ul class=""pagination justify-content-end"">
                            <li class=""page-item "">
                                <a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
                            </li>
                           
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">Next</a>
                            </li>
                        </ul>
                    </nav>
");
#nullable restore
#line 68 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                 if (Alunos.Count == 0 && !isLoading)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(83, "                    ");
            __builder.AddMarkupContent(84, "<p class>Nenhum aluno cadastrado!</p>\r\n                    ");
            __builder.OpenElement(85, "table");
            __builder.AddAttribute(86, "id", "example2");
            __builder.AddAttribute(87, "class", " mt-4 table table-striped table-bordered dataTable");
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.OpenElement(89, "thead");
            __builder.AddMarkupContent(90, "\r\n                            ");
            __builder.OpenElement(91, "tr");
            __builder.AddMarkupContent(92, "\r\n                                ");
            __builder.OpenElement(93, "th");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                () => SortTable("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(95, "Matrícula ");
            __builder.OpenElement(96, "span");
            __builder.AddAttribute(97, "class", "fa" + " " + (
#nullable restore
#line 75 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                           SortIcon("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                                ");
            __builder.OpenElement(99, "th");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                () => SortTable("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(101, "Nome ");
            __builder.OpenElement(102, "span");
            __builder.AddAttribute(103, "class", "fa" + " " + (
#nullable restore
#line 76 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                 SortIcon("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                                ");
            __builder.OpenElement(105, "th");
            __builder.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                () => SortTable("Email")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(107, "Curso ");
            __builder.OpenElement(108, "span");
            __builder.AddAttribute(109, "class", "fa" + " " + (
#nullable restore
#line 77 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                                                                                                   SortIcon("Curso")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                                <th></th>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n");
#nullable restore
#line 82 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                 if (isLoading)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(114, "                    ");
            __builder.AddMarkupContent(115, "<svg style=\"margin: auto; background: none; display: block; shape-rendering: auto;\" width=\"150px\" height=\"150px\" viewBox=\"0 0 100 100\" preserveAspectRatio=\"xMidYMid\">\r\n                        <rect x=\"17.5\" y=\"30\" width=\"15\" height=\"40\" fill=\"#30b3e9\">\r\n                            <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"10;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.3s\"></animate>\r\n                            <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"80;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.3s\"></animate>\r\n                        </rect>\r\n                        <rect x=\"42.5\" y=\"30\" width=\"15\" height=\"40\" fill=\"#15e99c\">\r\n                            <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"15;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.2s\"></animate>\r\n                            <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"70;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.2s\"></animate>\r\n                        </rect>\r\n                        <rect x=\"67.5\" y=\"29.8408\" width=\"15\" height=\"40.3183\" fill=\"#2eaac7\">\r\n                            <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"15;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\"></animate>\r\n                            <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"70;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\"></animate>\r\n                        </rect>\r\n                    </svg>\r\n                    ");
            __builder.AddMarkupContent(116, "<h2>\r\n                        <center>\r\n                            <p class>Buscando alunos aguarde...</p>\r\n                        </center>\r\n                    </h2>\r\n");
#nullable restore
#line 104 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\GettingReady\Pages\Admin\Alunos\List.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(117, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591