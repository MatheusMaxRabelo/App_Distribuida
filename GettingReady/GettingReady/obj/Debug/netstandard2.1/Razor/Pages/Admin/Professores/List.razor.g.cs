#pragma checksum "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0ac80ea7a795182bcc510ec4b93ea26dd32f9fd"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Professores/List")]
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
                    <b class=""ml-3"" style=""font-size:15pt"">Lista de Professores</b>
                </h3>
                <a href=""/Admin/Professores/Create"" class=""btn btn-info btn-xs"" style=""float:right""><span><i class=""fa fa-plus""></i></span></a>
            </div>
            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 29 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                 if (Professores.Count > 0)
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
#line 34 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                                                () => SortTable("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "Matrícula ");
            __builder.OpenElement(26, "span");
            __builder.AddAttribute(27, "class", "fa" + " " + (
#nullable restore
#line 34 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
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
#line 35 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                                                () => SortTable("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Nome ");
            __builder.OpenElement(32, "span");
            __builder.AddAttribute(33, "class", "fa" + " " + (
#nullable restore
#line 35 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                                                                                                 SortIcon("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                <th></th>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "tbody");
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 40 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                             foreach (var Professor in Professores)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                                ");
            __builder.OpenElement(40, "tr");
            __builder.AddMarkupContent(41, "\r\n                                    ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 43 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                                         Professor.Matricula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                    ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 44 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                                         Professor.Nome.ToUpperInvariant()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                    ");
            __builder.OpenElement(48, "td");
            __builder.AddAttribute(49, "style", "width:105px;");
            __builder.AddMarkupContent(50, "\r\n                                        ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "class", "btn btn-outline-info btn-sm");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                                                                                                            (()=>NavigateTo(Professor.Matricula))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(55, "<span><i class=\"fa fa-eye\"></i></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                                        ");
            __builder.AddMarkupContent(57, "<button type=\"button\" class=\"btn btn-outline-warning btn-sm\"><span><i class=\"fa fa-edit\"></i></span></button>\r\n                                        ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "type", "button");
            __builder.AddAttribute(60, "class", "btn btn-outline-danger btn-sm");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                                                                                                              (()=>DeleteProfessor(Professor.Matricula))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(62, "<span><i class=\"fa fa-trash\"></i></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 51 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 54 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                 if (Professores.Count == 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "                    ");
            __builder.AddMarkupContent(70, "<p class>Nenhum professor cadastrado!</p>\r\n                    ");
            __builder.OpenElement(71, "table");
            __builder.AddAttribute(72, "id", "example2");
            __builder.AddAttribute(73, "class", " mt-4 table table-striped table-bordered dataTable");
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.OpenElement(75, "thead");
            __builder.AddMarkupContent(76, "\r\n                            ");
            __builder.OpenElement(77, "tr");
            __builder.AddMarkupContent(78, "\r\n                                ");
            __builder.OpenElement(79, "th");
            __builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                                                () => SortTable("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(81, "Id ");
            __builder.OpenElement(82, "span");
            __builder.AddAttribute(83, "class", "fa" + " " + (
#nullable restore
#line 61 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                                                                                                    SortIcon("Matricula")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                                ");
            __builder.OpenElement(85, "th");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                                                () => SortTable("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(87, "Nome ");
            __builder.OpenElement(88, "span");
            __builder.AddAttribute(89, "class", "fa" + " " + (
#nullable restore
#line 62 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                                                                                                 SortIcon("Nome")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                                ");
            __builder.OpenElement(91, "th");
            __builder.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                                                () => SortTable("Email")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(93, "Curso ");
            __builder.OpenElement(94, "span");
            __builder.AddAttribute(95, "class", "fa" + " " + (
#nullable restore
#line 63 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                                                                                                   SortIcon("Curso")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                                <th></th>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 68 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                 if (Professores == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                    ");
            __builder.AddMarkupContent(101, "<p class>Buscando professores aguarde...</p>\r\n");
#nullable restore
#line 72 "C:\Users\Merizito\Desktop\App_Distribuida-master\GettingReady\GettingReady\Pages\Admin\Professores\List.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591