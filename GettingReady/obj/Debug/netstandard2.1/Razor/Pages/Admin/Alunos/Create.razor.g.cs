#pragma checksum "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc84cc98485b62b934e12df2745511ca84dbea3e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Alunos/Create")]
    public partial class Create : CreatePage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <h1>Adicionar Alunos</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""Admin/Alunos/List"">Alunos</a></li>
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
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "style", "color:red;");
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#nullable restore
#line 30 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                                           Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 31 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                 if (isLoading)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "                    ");
            __builder.AddMarkupContent(20, "<svg style=\"margin: auto; background: none; display: block; shape-rendering: auto;\" width=\"251px\" height=\"251px\" viewBox=\"0 0 100 100\" preserveAspectRatio=\"xMidYMid\">\r\n                        <rect x=\"17.5\" y=\"30\" width=\"15\" height=\"40\" fill=\"#30b3e9\">\r\n                            <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"10;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.3s\"></animate>\r\n                            <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"80;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.3s\"></animate>\r\n                        </rect>\r\n                        <rect x=\"42.5\" y=\"30\" width=\"15\" height=\"40\" fill=\"#15e99c\">\r\n                            <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"15;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.2s\"></animate>\r\n                            <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"70;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\" begin=\"-0.2s\"></animate>\r\n                        </rect>\r\n                        <rect x=\"67.5\" y=\"29.8408\" width=\"15\" height=\"40.3183\" fill=\"#2eaac7\">\r\n                            <animate attributeName=\"y\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"15;30;30\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\"></animate>\r\n                            <animate attributeName=\"height\" repeatCount=\"indefinite\" dur=\"1s\" calcMode=\"spline\" keyTimes=\"0;0.5;1\" values=\"70;40;40\" keySplines=\"0 0.5 0.5 1;0 0.5 0.5 1\"></animate>\r\n                        </rect>\r\n                        \r\n                    </svg>\r\n");
            __builder.AddContent(21, "                    ");
            __builder.AddMarkupContent(22, "<h2>\r\n                        <center>\r\n                            Aguarde\r\n                        </center>\r\n                    </h2>\r\n");
#nullable restore
#line 54 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-12");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(27);
            __builder.AddAttribute(28, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 58 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                                             HandleFile

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 60 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                     if (Alunos.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                        ");
            __builder.OpenElement(32, "table");
            __builder.AddAttribute(33, "id", "example2");
            __builder.AddAttribute(34, "class", " mt-4 table table-striped table-bordered dataTable");
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.OpenElement(36, "thead");
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.OpenElement(38, "tr");
            __builder.AddMarkupContent(39, "\r\n                                    ");
            __builder.OpenElement(40, "th");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                                                    () => SortTable("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "Matrícula ");
            __builder.OpenElement(43, "span");
            __builder.AddAttribute(44, "class", "fa" + " " + (
#nullable restore
#line 65 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                                                                                                               SortIcon("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                    ");
            __builder.OpenElement(46, "th");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                                                    () => SortTable("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, "Nome ");
            __builder.OpenElement(49, "span");
            __builder.AddAttribute(50, "class", "fa" + " " + (
#nullable restore
#line 66 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                                                                                                     SortIcon("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                    <th></th>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.OpenElement(54, "tbody");
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 71 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                                 foreach (var Aluno in Alunos)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                                    ");
            __builder.OpenElement(57, "tr");
            __builder.AddMarkupContent(58, "\r\n                                        ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 74 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                                             Aluno.Matricula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                        ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 75 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                                             Aluno.Nome.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                        ");
            __builder.OpenElement(65, "td");
            __builder.AddAttribute(66, "style", "width:30px;");
            __builder.AddMarkupContent(67, "\r\n                                            ");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "type", "button");
            __builder.AddAttribute(70, "class", "btn btn-outline-danger btn-sm");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                                                                                                                    ()=>DeleteAluno(Aluno.Matricula)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(72, "<span><i class=\"fa fa-trash\"></i></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 80 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "type", "button");
            __builder.AddAttribute(81, "class", "btn btn-outline-info btn-sm");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                                                                                            (()=>AddAluno())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(83, "<span><i class=\"fa fa-save\"></i> Salvar</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 84 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, "                        ");
            __builder.AddMarkupContent(86, "<p class=\"mt-4\">Aguardando carga do arquivo...</p>\r\n                        ");
            __builder.AddMarkupContent(87, "<button type=\"button\" class=\"btn btn-outline-info btn-sm disabled\"><span><i class=\"fa fa-save mr-1\"></i>Salvar</span></button>\r\n");
#nullable restore
#line 89 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\mathe\Desktop\App_Distribuida\GettingReady\Pages\Admin\Alunos\Create.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
