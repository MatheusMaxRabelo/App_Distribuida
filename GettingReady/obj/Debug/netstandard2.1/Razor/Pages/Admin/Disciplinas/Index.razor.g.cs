#pragma checksum "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "370896b746a367673ba1a15ab09ce4a3a94a7cd6"
// <auto-generated/>
#pragma warning disable 1591
namespace GettingReady.Pages.Admin.Disciplinas
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Disciplinas/Index")]
    public partial class Index : IndexPage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <h1>Todos as disciplinas</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item active"">Disciplinas</li>
                    </ol>
                </div>
            </div>
        </div>
    </section>
    ");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "content");
            __builder.AddMarkupContent(3, "\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.AddMarkupContent(6, "\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "\n                ");
            __builder.AddMarkupContent(10, @"<div class=""card-header"">
                    <h3 class=""card-title"">
                        <i class=""fa fa-list""></i>
                        <b class=""ml-3"" style=""font-size:15pt"">Lista de Disciplinas</b>
                    </h3>
                    <a href=""/Admin/Disciplinas/Create"" class=""btn btn-info btn-sm"" style=""float:right""><span><i class=""fa fa-plus mr-1""></i>Adicionar</span></a>
                </div>
                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "style", 
#nullable restore
#line 29 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                                  MessageColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, 
#nullable restore
#line 29 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                                                 Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
#nullable restore
#line 30 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                     if (Disciplinas.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "        ");
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "id", "example2");
            __builder.AddAttribute(21, "class", "table table-striped table-bordered dataTable");
            __builder.AddMarkupContent(22, "\n            ");
            __builder.OpenElement(23, "thead");
            __builder.AddMarkupContent(24, "\n                ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\n                    ");
            __builder.OpenElement(27, "th");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                                    () => SortTable("Id")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "Matrícula ");
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "class", "fa" + " " + (
#nullable restore
#line 35 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                                                                                        SortIcon("Id")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                    ");
            __builder.OpenElement(33, "th");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                                    () => SortTable("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Nome ");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "fa" + " " + (
#nullable restore
#line 36 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                                                                                     SortIcon("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                    ");
            __builder.AddMarkupContent(39, "<th>Favorito</th>\n                    <th></th>\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n            ");
            __builder.OpenElement(42, "tbody");
            __builder.AddMarkupContent(43, "\n");
#nullable restore
#line 42 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                 foreach (var disciplina in Disciplinas)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "    ");
            __builder.OpenElement(45, "tr");
            __builder.AddMarkupContent(46, "\n        ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 45 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
             disciplina.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n        ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 46 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
             disciplina.Nome.ToUpperInvariant()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n        ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 47 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
             disciplina.Favorito

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n        ");
            __builder.OpenElement(56, "td");
            __builder.AddAttribute(57, "style", "width:105px;");
            __builder.AddMarkupContent(58, "\n            ");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "type", "button");
            __builder.AddAttribute(61, "class", "btn btn-outline-info btn-sm");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                                                                                (()=>NavigateTo('d',disciplina.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(63, "<span><i class=\"fa fa-eye\"></i></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n            ");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "type", "button");
            __builder.AddAttribute(67, "class", "btn btn-outline-warning btn-sm");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                                                                                   (()=>NavigateTo('e',disciplina.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(69, "<span><i class=\"fa fa-edit\"></i></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n            ");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "type", "button");
            __builder.AddAttribute(73, "class", "btn btn-outline-danger btn-sm");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                                                                                  (()=>ConfirmDelete(disciplina.Id,disciplina.Nome))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(75, "<span><i class=\"fa fa-trash\"></i></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\n    ");
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
         }

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\n                        ");
            __builder.AddMarkupContent(81, @"<nav aria-label=""Page navigation example"">
                            <ul class=""pagination justify-content-end"">
                                <li class=""page-item "">
                                    <a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
                                </li>

                                <li class=""page-item"">
                                    <a class=""page-link"" href=""#"">Next</a>
                                </li>
                            </ul>
                        </nav>");
#nullable restore
#line 66 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                     if (Disciplinas.Count == 0 && !isLoading)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "        ");
            __builder.AddMarkupContent(83, "<p class>Nenhum aluno cadastrado!</p>\n                        ");
            __builder.OpenElement(84, "table");
            __builder.AddAttribute(85, "id", "example2");
            __builder.AddAttribute(86, "class", " mt-4 table table-striped table-bordered dataTable");
            __builder.AddMarkupContent(87, "\n                            ");
            __builder.OpenElement(88, "thead");
            __builder.AddMarkupContent(89, "\n                                ");
            __builder.OpenElement(90, "tr");
            __builder.AddMarkupContent(91, "\n                                    ");
            __builder.OpenElement(92, "th");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                                                    () => SortTable("Id")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(94, "Matrícula ");
            __builder.OpenElement(95, "span");
            __builder.AddAttribute(96, "class", "fa" + " " + (
#nullable restore
#line 73 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                                                                                                        SortIcon("Id")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n                                    ");
            __builder.OpenElement(98, "th");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                                                    () => SortTable("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(100, "Nome ");
            __builder.OpenElement(101, "span");
            __builder.AddAttribute(102, "class", "fa" + " " + (
#nullable restore
#line 74 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                                                                                                     SortIcon("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n                                    ");
            __builder.AddMarkupContent(104, "<th>Curso </th>\n                                    <th></th>\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\n                        ");
            __builder.CloseElement();
#nullable restore
#line 79 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                     if (isLoading)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "        ");
            __builder.AddMarkupContent(108, "<svg style=\"margin: auto; background: none; display: block; shape-rendering: auto;\" width=\"150px\" height=\"150px\" viewBox=\"0 0 100 100\" preserveAspectRatio=\"xMidYMid\">\n            <rect x=\"17.5\" y=\"30\" width=\"15\" height=\"40\" fill=\"#30b3e9\">\n                <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"10;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.3s\"></animate>\n                <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"80;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.3s\"></animate>\n            </rect>\n            <rect x=\"42.5\" y=\"30\" width=\"15\" height=\"40\" fill=\"#15e99c\">\n                <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"15;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.2s\"></animate>\n                <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"70;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.2s\"></animate>\n            </rect>\n            <rect x=\"67.5\" y=\"29.8408\" width=\"15\" height=\"40.3183\" fill=\"#2eaac7\">\n                <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"15;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\"></animate>\n                <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"70;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\"></animate>\n            </rect>\n        </svg>\n                        ");
            __builder.AddMarkupContent(109, "<h2>\n                            <center>\n                                <p class>Buscando disciplinas aguarde...</p>\n                            </center>\n                        </h2>");
#nullable restore
#line 100 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Index.razor"
                             }

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\n                \n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
