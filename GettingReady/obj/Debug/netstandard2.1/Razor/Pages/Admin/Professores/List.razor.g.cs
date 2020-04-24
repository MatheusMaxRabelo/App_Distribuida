#pragma checksum "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8dfacd57068577ab269daad2901ba6908a74eaa"
// <auto-generated/>
#pragma warning disable 1591
namespace GettingReady.Pages.Admin.Professores
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Professores/Index")]
    public partial class List : ListProfessor
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <h1>Todos os Professores</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item active"">Professores</li>
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
            __builder.AddMarkupContent(10, @"<div class=""card-header"">
                <h3 class=""card-title"">
                    <i class=""fa fa-list""></i>
                    <b class=""ml-3"" style=""font-size:15pt"">Lista de Professores</b>
                </h3>
                <a href=""/Admin/Professores/Create"" class=""btn btn-info btn-sm"" style=""float:right""><span><i class=""fa fa-plus mr-1""></i>Adicionar</span></a>
            </div>
            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\n                ");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "style", (
#nullable restore
#line 29 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                              MessageColor

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(16, 
#nullable restore
#line 29 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                              Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
#nullable restore
#line 30 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                 if (Professores.Count > 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                    ");
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "id", "example2");
            __builder.AddAttribute(21, "class", "table table-striped table-bordered dataTable");
            __builder.AddMarkupContent(22, "\n                        ");
            __builder.OpenElement(23, "thead");
            __builder.AddMarkupContent(24, "\n                            ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\n                                ");
            __builder.OpenElement(27, "th");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                                () => SortTable("Id")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "Matrícula ");
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "class", "fa" + " " + (
#nullable restore
#line 35 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                                                                                    SortIcon("Id")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                                ");
            __builder.OpenElement(33, "th");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                                () => SortTable("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Nome ");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "fa" + " " + (
#nullable restore
#line 36 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                                                                                 SortIcon("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                                <th></th>\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                        ");
            __builder.OpenElement(41, "tbody");
            __builder.AddMarkupContent(42, "\n");
#nullable restore
#line 41 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                             foreach (var Professor in Professores)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "                                ");
            __builder.OpenElement(44, "tr");
            __builder.AddMarkupContent(45, "\n                                    ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 44 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                         Professor.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                                    ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 45 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                         Professor.Nome.ToUpperInvariant()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n                                    ");
            __builder.OpenElement(52, "td");
            __builder.AddAttribute(53, "style", "width:105px;");
            __builder.AddMarkupContent(54, "\n                                        ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "type", "button");
            __builder.AddAttribute(57, "class", "btn btn-outline-info btn-sm");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                                                                                            (()=>NavigateTo(Professor.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "<span><i class=\"fa fa-eye\"></i></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n                                        ");
            __builder.AddMarkupContent(61, "<button type=\"button\" class=\"btn btn-outline-warning btn-sm\"><span><i class=\"fa fa-edit\"></i></span></button>\n                                        ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "type", "button");
            __builder.AddAttribute(64, "class", "btn btn-outline-danger btn-sm");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                                                                                              (()=>ConfirmDelete(Professor.Id, Professor.Nome))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(66, "<span><i class=\"fa fa-trash\"></i></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\n");
#nullable restore
#line 52 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n");
#nullable restore
#line 55 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                 if (isLoading)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "                    ");
            __builder.AddMarkupContent(74, "<svg style=\"margin: auto; background: none; display: block; shape-rendering: auto;\" width=\"150px\" height=\"150px\" viewBox=\"0 0 100 100\" preserveAspectRatio=\"xMidYMid\">\n                        <rect x=\"17.5\" y=\"30\" width=\"15\" height=\"40\" fill=\"#30b3e9\">\n                            <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"10;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.3s\"></animate>\n                            <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"80;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.3s\"></animate>\n                        </rect>\n                        <rect x=\"42.5\" y=\"30\" width=\"15\" height=\"40\" fill=\"#15e99c\">\n                            <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"15;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.2s\"></animate>\n                            <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"70;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.2s\"></animate>\n                        </rect>\n                        <rect x=\"67.5\" y=\"29.8408\" width=\"15\" height=\"40.3183\" fill=\"#2eaac7\">\n                            <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"15;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\"></animate>\n                            <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"70;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\"></animate>\n                        </rect>\n                    </svg>\n                    ");
            __builder.AddMarkupContent(75, "<h2>\n                        <center>\n                            <p class>Buscando professores aguarde...</p>\n                        </center>\n                    </h2>\n");
#nullable restore
#line 77 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                }
                else
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                 if (Professores.Count == 0 && !isLoading)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "                    ");
            __builder.AddMarkupContent(77, "<p class>Nenhum professor cadastrado!</p>\n                    ");
            __builder.OpenElement(78, "table");
            __builder.AddAttribute(79, "id", "example2");
            __builder.AddAttribute(80, "class", " mt-4 table table-striped table-bordered dataTable");
            __builder.AddMarkupContent(81, "\n                        ");
            __builder.OpenElement(82, "thead");
            __builder.AddMarkupContent(83, "\n                            ");
            __builder.OpenElement(84, "tr");
            __builder.AddMarkupContent(85, "\n                                ");
            __builder.OpenElement(86, "th");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                                () => SortTable("Id")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(88, "Id ");
            __builder.OpenElement(89, "span");
            __builder.AddAttribute(90, "class", "fa" + " " + (
#nullable restore
#line 85 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                                                                             SortIcon("Id")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\n                                ");
            __builder.OpenElement(92, "th");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                                () => SortTable("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(94, "Nome ");
            __builder.OpenElement(95, "span");
            __builder.AddAttribute(96, "class", "fa" + " " + (
#nullable restore
#line 86 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                                                                                 SortIcon("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n                                ");
            __builder.OpenElement(98, "th");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                                () => SortTable("Email")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(100, "Curso ");
            __builder.OpenElement(101, "span");
            __builder.AddAttribute(102, "class", "fa" + " " + (
#nullable restore
#line 87 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                                                                                                   SortIcon("Curso")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n                                <th></th>\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\n");
#nullable restore
#line 92 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Professores\List.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\n            \n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
