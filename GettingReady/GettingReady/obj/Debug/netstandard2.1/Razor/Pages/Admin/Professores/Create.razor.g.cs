#pragma checksum "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7b095b5ec8b537b7fc1491f7ffeddf76d628777"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Professores/Create")]
    public partial class Create : CreateProfessor
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <h1>Adicionar Professores</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""Admin/Professores/List"">Professores</a></li>
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
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-12");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(17);
            __builder.AddAttribute(18, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 31 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                                         HandleFile

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 33 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                 if (Professores.Count > 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "                    ");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "id", "example2");
            __builder.AddAttribute(24, "class", " mt-4 table table-striped table-bordered dataTable");
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "thead");
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n                                ");
            __builder.OpenElement(30, "th");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                                                () => SortTable("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "Matrícula ");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "class", "fa" + " " + (
#nullable restore
#line 38 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                                                                                                           SortIcon("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                ");
            __builder.OpenElement(36, "th");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                                                () => SortTable("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Nome ");
            __builder.OpenElement(39, "span");
            __builder.AddAttribute(40, "class", "fa" + " " + (
#nullable restore
#line 39 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                                                                                                 SortIcon("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                ");
            __builder.OpenElement(42, "th");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                                                () => SortTable("Area")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "Área ");
            __builder.OpenElement(45, "span");
            __builder.AddAttribute(46, "class", "fa" + " " + (
#nullable restore
#line 40 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                                                                                                 SortIcon("Area")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                <th></th>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.OpenElement(50, "tbody");
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 45 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                             foreach (var Professor in Professores)
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
#line 48 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                                         Professor.Matricula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                    ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 49 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                                         Professor.Nome.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                                    ");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 50 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                                         Professor.areaConhecimento.Nome.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                    ");
            __builder.OpenElement(64, "td");
            __builder.AddAttribute(65, "style", "width:70px;");
            __builder.AddMarkupContent(66, "\r\n                                        ");
            __builder.AddMarkupContent(67, "<button type=\"button\" class=\"btn btn-outline-warning btn-sm\"><span><i class=\"fa fa-edit\"></i></span></button>\r\n                                        ");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "type", "button");
            __builder.AddAttribute(70, "class", "btn btn-outline-danger btn-sm");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                                                                                                                ()=>DeleteProfessor(Professor.Matricula)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(72, "<span><i class=\"fa fa-trash\"></i></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 56 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 59 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "                    ");
            __builder.AddMarkupContent(80, "<p class=\"mt-4\">Aguardando carga do arquivo...</p>\r\n");
#nullable restore
#line 63 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\Create.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
