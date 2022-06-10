#pragma checksum "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2e4a096721adcfdd4e3d7e7ff3dbca38395296b"
// <auto-generated/>
#pragma warning disable 1591
namespace ComicsStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\_Imports.razor"
using ComicsStore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/comics/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/comics/create")]
    public partial class Editor : OwningComponentBase<IComicsStoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\ndiv.validation-message {\r\ncolor: rgb(220, 53, 69);\r\nfont-weight: 500\r\n}\r\n</style>\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "bg-" + (
#nullable restore
#line 10 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
               ThemeColor

#line default
#line hidden
#nullable disable
            ) + " text-white" + " text-center" + " p-1");
#nullable restore
#line 10 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
__builder.AddContent(3, TitleText);

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, " a Comic");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
                 Comic

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
                                       Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n");
#nullable restore
#line 13 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
 if (Comic.ComicID != 0)
{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "\r\n");
                __builder2.AddMarkupContent(16, "<label>ID</label>\r\n");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "disabled", true);
                __builder2.AddAttribute(20, "value", 
#nullable restore
#line 17 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
                                             Comic.ComicID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n");
#nullable restore
#line 19 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
}

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "\r\n");
                __builder2.AddMarkupContent(26, "<label>Tên Truyện</label>\r\n");
                __Blazor.ComicsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_0(__builder2, 27, 28, 
#nullable restore
#line 22 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
                          () => Comic.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(29, "\r\n");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
                                             Comic.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Comic.Title = __value, Comic.Title))));
                __builder2.AddAttribute(34, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Comic.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n\r\n");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "\r\n");
                __builder2.AddMarkupContent(40, "<label>Mô Tả</label>\r\n");
                __Blazor.ComicsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_1(__builder2, 41, 42, 
#nullable restore
#line 29 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
                          () => Comic.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(43, "\r\n");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
                                             Comic.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Comic.Description = __value, Comic.Description))));
                __builder2.AddAttribute(48, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Comic.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group");
                __builder2.AddMarkupContent(53, "\r\n");
                __builder2.AddMarkupContent(54, "<label>Thể Loại</label>\r\n");
                __Blazor.ComicsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_2(__builder2, 55, 56, 
#nullable restore
#line 34 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
                          () => Comic.Genre

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(57, "\r\n");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
                                             Comic.Genre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Comic.Genre = __value, Comic.Genre))));
                __builder2.AddAttribute(62, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Comic.Genre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\r\n\r\n");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group");
                __builder2.AddMarkupContent(67, "\r\n");
                __builder2.AddMarkupContent(68, "<label>Giá</label>\r\n");
                __Blazor.ComicsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_3(__builder2, 69, 70, 
#nullable restore
#line 41 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
                          () => Comic.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(71, "\r\n");
                __Blazor.ComicsStore.Pages.Admin.Editor.TypeInference.CreateInputNumber_4(__builder2, 72, 73, "form-control", 74, 
#nullable restore
#line 42 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
                                               Comic.Price

#line default
#line hidden
#nullable disable
                , 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Comic.Price = __value, Comic.Price)), 76, () => Comic.Price);
                __builder2.AddMarkupContent(77, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n");
                __builder2.OpenElement(79, "button");
                __builder2.AddAttribute(80, "type", "submit");
                __builder2.AddAttribute(81, "class", "btn" + " btn-" + (
#nullable restore
#line 44 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
                                      ThemeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(82, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(84);
                __builder2.AddAttribute(85, "class", "btn btn-secondary");
                __builder2.AddAttribute(86, "href", "/admin");
                __builder2.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(88, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Editor.razor"
       
public IComicsStoreRepository Repository => Service;
[Inject]
public NavigationManager NavManager { get; set; }
[Parameter]
public long Id { get; set; } = 0;public Comic Comic { get; set; } = new Comic();
protected override void OnParametersSet()
{
if (Id != 0)
{
Comic = Repository.Comics.FirstOrDefault(b => b.ComicID == Id);
}
}
public void Save()
{
if (Id == 0)
{
Repository.Create(Comic);
}
else
{
Repository.Save(Comic);
}
NavManager.NavigateTo("/admin/comics");
}
public string ThemeColor => Id == 0 ? "primary" : "warning";
public string TitleText => Id == 0 ? "Create" : "Edit";

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ComicsStore.Pages.Admin.Editor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
