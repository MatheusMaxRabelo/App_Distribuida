#pragma checksum "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "482240843400b8bfab05d9025992dd1a0bcc227f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Disciplinas/Create")]
    public partial class Create : CreateBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <h1>Adicionar Disciplinas</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""Admin/Disciplinas/Index"">Disciplinas</a></li>
                    <li class=""breadcrumb-item active"">Adicionar</li>
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
                    <i class=""fas fa-arrow-up mr-2""></i>
                    <b>Enviar arquivo</b>
                    <i class=""fas fa-arrow-up ml-2""></i>
                </h3>
            </div>
            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 30 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                 if (isLoading)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                    ");
            __builder.AddMarkupContent(15, "<svg style=\"margin: auto; background: none; display: block; shape-rendering: auto;\" width=\"251px\" height=\"251px\" viewBox=\"0 0 100 100\" preserveAspectRatio=\"xMidYMid\">\r\n                        <rect x=\"17.5\" y=\"30\" width=\"15\" height=\"40\" fill=\"#30b3e9\">\r\n                            <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"10;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.3s\"></animate>\r\n                            <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"80;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.3s\"></animate>\r\n                        </rect>\r\n                        <rect x=\"42.5\" y=\"30\" width=\"15\" height=\"40\" fill=\"#15e99c\">\r\n                            <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"15;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.2s\"></animate>\r\n                            <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"70;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.2s\"></animate>\r\n                        </rect>\r\n                        <rect x=\"67.5\" y=\"29.8408\" width=\"15\" height=\"40.3183\" fill=\"#2eaac7\">\r\n                            <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"15;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\"></animate>\r\n                            <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"70;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\"></animate>\r\n                        </rect>\r\n                        \r\n                    </svg>\r\n");
            __builder.AddContent(16, "                    ");
            __builder.AddMarkupContent(17, "<h2>\r\n                        <center>\r\n                            Aguarde\r\n                        </center>\r\n                    </h2> ");
#nullable restore
#line 52 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                          }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-12");
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(22);
            __builder.AddAttribute(23, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 56 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                                             HandleFile

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 58 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                     if (Disciplinas.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                        ");
            __builder.OpenElement(27, "table");
            __builder.AddAttribute(28, "id", "example2");
            __builder.AddAttribute(29, "class", " mt-4 table table-striped table-bordered dataTable");
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "thead");
            __builder.AddMarkupContent(32, "\r\n                                ");
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "\r\n                                    ");
            __builder.OpenElement(35, "th");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                                                    () => SortTable("Id")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "Matrícula ");
            __builder.OpenElement(38, "span");
            __builder.AddAttribute(39, "class", "fa" + " " + (
#nullable restore
#line 63 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                                                                                                        SortIcon("Id")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                                    ");
            __builder.OpenElement(41, "th");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                                                    () => SortTable("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, "Nome ");
            __builder.OpenElement(44, "span");
            __builder.AddAttribute(45, "class", "fa" + " " + (
#nullable restore
#line 64 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                                                                                                     SortIcon("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                    ");
            __builder.AddMarkupContent(47, "<th>Favorito</th>\r\n                                    <th></th>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                            ");
            __builder.OpenElement(50, "tbody");
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 70 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                                 foreach (var disciplina in Disciplinas)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                                ");
            __builder.OpenElement(53, "tr");
            __builder.AddMarkupContent(54, "\r\n                                    ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 73 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                                         disciplina.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                    ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 74 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                                         disciplina.Nome.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                                    ");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 75 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                                         disciplina.Favorito

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                    ");
            __builder.OpenElement(64, "td");
            __builder.AddAttribute(65, "style", "width:30px;");
            __builder.AddMarkupContent(66, "\r\n                                        ");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "type", "button");
            __builder.AddAttribute(69, "class", "btn btn-outline-danger btn-sm");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                                                                                                                ()=>DeleteDisciplina(disciplina.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(71, "<span><i class=\"fa fa-trash\"></i></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 80 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.OpenElement(78, "button");
            __builder.AddAttribute(79, "type", "button");
            __builder.AddAttribute(80, "class", "btn btn-outline-info btn-sm");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                                                                                            (()=>Add())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(82, "<span><i class=\"fa fa-save\"></i> Salvar</span>");
            __builder.CloseElement();
            __builder.AddContent(83, " ");
#nullable restore
#line 83 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                                                                                                                                                                 }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "                        ");
            __builder.AddMarkupContent(85, "<p class=\"mt-4\">Aguardando carga do arquivo...</p>\r\n                        ");
            __builder.AddMarkupContent(86, "<button type=\"button\" class=\"btn btn-outline-info btn-sm disabled\"><span><i class=\"fa fa-save mr-1\"></i>Salvar</span></button>");
#nullable restore
#line 87 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                                                                                                                                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Disciplinas\Create.razor"
                                                                                                                                                       }

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
