#pragma checksum "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63d3ef9e9ca09cf58219e1cd2a1cd84bd24dc933"
// <auto-generated/>
#pragma warning disable 1591
namespace GettingReady.Pages.Admin.Turmas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\_Imports.razor"
using GettingReady;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\_Imports.razor"
using GettingReady.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Turmas/Create")]
    public partial class Create : CreateBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                 turma

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                  Submit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.AddContent(5, 
#nullable restore
#line 5 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
     MonitorId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.AddContent(7, 
#nullable restore
#line 6 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
     ProfessorId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.AddContent(9, 
#nullable restore
#line 7 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
     DisciplinaId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.AddContent(11, 
#nullable restore
#line 8 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
     turma.detalhesMonitoria

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.AddMarkupContent(13, @"<section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <h1>Editar</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""Admin/Turmas/Index"">Turmas</a></li>
                        <li class=""breadcrumb-item active"">Adicionar</li>
                    </ol>
                </div>
            </div>
        </div>
    </section>
    ");
                __builder2.OpenElement(14, "section");
                __builder2.AddAttribute(15, "class", "content");
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "container-fluid");
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "card");
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.AddMarkupContent(23, "<div class=\"card-header\">\r\n                    <h3 class=\"card-title\">\r\n                        <b>Adicionar Turma</b>\r\n                    </h3>\r\n                </div>\r\n                ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "card-body");
                __builder2.AddMarkupContent(26, "\r\n                    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "row");
                __builder2.AddMarkupContent(29, "\r\n                        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-sm-5 mb-3");
                __builder2.AddMarkupContent(32, "\r\n                            ");
                __builder2.AddMarkupContent(33, "<label for=\"Data\">Monitor</label>\r\n                            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "input-group");
                __builder2.AddMarkupContent(36, "\r\n                                ");
                __Blazor.GettingReady.Pages.Admin.Turmas.Create.TypeInference.CreateInputSelect_0(__builder2, 37, 38, "form-control", 39, "Data", 40, "Data", 41, 
#nullable restore
#line 37 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                          MonitorId

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => MonitorId = __value, MonitorId)), 43, () => MonitorId, 44, (__builder3) => {
                    __builder3.AddMarkupContent(45, "\r\n");
#nullable restore
#line 38 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                     foreach (var monitor in Alunos)
                                    {
                                        if (monitor.Matricula == turma.monitorMatricula)
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(46, "                                            ");
                    __builder3.OpenElement(47, "option");
                    __builder3.AddAttribute(48, "value", 
#nullable restore
#line 42 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                           monitor.Matricula

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(49, "selected", true);
                    __builder3.AddContent(50, 
#nullable restore
#line 42 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                                                       monitor.Nome

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddContent(51, " ");
#nullable restore
#line 42 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                                                                             }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(52, "                                            ");
                    __builder3.OpenElement(53, "option");
                    __builder3.AddAttribute(54, "value", 
#nullable restore
#line 45 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                           monitor.Matricula

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(55, 
#nullable restore
#line 45 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                                              monitor.Nome

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 45 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                                                                   }
                                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(56, "                                ");
                }
                );
                __builder2.AddMarkupContent(57, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                        ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "col-sm-5 mb-3");
                __builder2.AddMarkupContent(62, "\r\n                            ");
                __builder2.AddMarkupContent(63, "<label for=\"Data\">Professor</label>\r\n                            ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "input-group");
                __builder2.AddMarkupContent(66, "\r\n                                ");
                __Blazor.GettingReady.Pages.Admin.Turmas.Create.TypeInference.CreateInputSelect_1(__builder2, 67, 68, "form-control", 69, "Data", 70, "Data", 71, 
#nullable restore
#line 53 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                          ProfessorId

#line default
#line hidden
#nullable disable
                , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ProfessorId = __value, ProfessorId)), 73, () => ProfessorId, 74, (__builder3) => {
                    __builder3.AddMarkupContent(75, "\r\n");
#nullable restore
#line 54 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                     foreach (var professor in Professores)
                                    {
                                        if (professor.Id == turma.ProfessorId)
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(76, "                                            ");
                    __builder3.OpenElement(77, "option");
                    __builder3.AddAttribute(78, "value", 
#nullable restore
#line 58 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                           professor.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(79, "selected", true);
                    __builder3.AddContent(80, 
#nullable restore
#line 58 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                                                  professor.Nome

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddContent(81, " ");
#nullable restore
#line 58 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                                                                          }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(82, "                                            ");
                    __builder3.OpenElement(83, "option");
                    __builder3.AddAttribute(84, "value", 
#nullable restore
#line 61 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                           professor.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(85, 
#nullable restore
#line 61 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                                         professor.Nome

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 61 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                                                                }
                                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(86, "                                ");
                }
                );
                __builder2.AddMarkupContent(87, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "row");
                __builder2.AddMarkupContent(93, "\r\n                        ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "col-sm-5 mb-3");
                __builder2.AddMarkupContent(96, "\r\n                            ");
                __builder2.AddMarkupContent(97, "<label for=\"Data\">Disciplina</label>\r\n                            ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "input-group");
                __builder2.AddMarkupContent(100, "\r\n                                ");
                __Blazor.GettingReady.Pages.Admin.Turmas.Create.TypeInference.CreateInputSelect_2(__builder2, 101, 102, "form-control", 103, "Data", 104, "Data", 105, 
#nullable restore
#line 71 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                          DisciplinaId

#line default
#line hidden
#nullable disable
                , 106, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DisciplinaId = __value, DisciplinaId)), 107, () => DisciplinaId, 108, (__builder3) => {
                    __builder3.AddMarkupContent(109, "\r\n");
#nullable restore
#line 72 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                     foreach (var disciplina in Disciplinas)
                                    {
                                        if (disciplina.Id == turma.DisciplinaId)
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(110, "                                            ");
                    __builder3.OpenElement(111, "option");
                    __builder3.AddAttribute(112, "value", 
#nullable restore
#line 76 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                           disciplina.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(113, "selected", true);
                    __builder3.AddContent(114, 
#nullable restore
#line 76 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                                                   disciplina.Nome

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddContent(115, " ");
#nullable restore
#line 76 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                                                                            }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(116, "                                            ");
                    __builder3.OpenElement(117, "option");
                    __builder3.AddAttribute(118, "value", 
#nullable restore
#line 79 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                           disciplina.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(119, 
#nullable restore
#line 79 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                                          disciplina.Nome

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 79 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                                                                  }
                                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(120, "                                ");
                }
                );
                __builder2.AddMarkupContent(121, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n                    ");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "col-sm-5 mb-3");
                __builder2.AddMarkupContent(127, "\r\n                        ");
                __builder2.AddMarkupContent(128, "<label for=\"Data\">Curso</label>\r\n                        ");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "input-group");
                __builder2.AddMarkupContent(131, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(132);
                __builder2.AddAttribute(133, "class", "form-control");
                __builder2.AddAttribute(134, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 88 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                                         turma.detalhesMonitoria

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(135, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => turma.detalhesMonitoria = __value, turma.detalhesMonitoria))));
                __builder2.AddAttribute(136, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => turma.detalhesMonitoria));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(137, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                    ");
                __builder2.OpenElement(140, "button");
                __builder2.AddAttribute(141, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "C:\Users\mathe\Desktop\Dad_Ready\GettingReady\Pages\Admin\Turmas\Create.razor"
                                        ()=>Navigation.NavigateTo("/Admin/Alunos/List")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(142, "class", "btn btn-outline-danger btn-sm ml-1 mr-1");
                __builder2.AddAttribute(143, "style", "float:right");
                __builder2.AddContent(144, "Cancelar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n                    ");
                __builder2.AddMarkupContent(146, "<button type=\"submit\" class=\"btn btn-outline-info btn-sm\" style=\"float:right\">Salvar</button>\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.GettingReady.Pages.Admin.Turmas.Create
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591