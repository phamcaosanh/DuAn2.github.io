#pragma checksum "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d098038e97b7e723befe430d848883ee4056718"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/comics")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Comics : OwningComponentBase<IComicsStoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\r\n");
            __builder.AddMarkupContent(3, "<thead>\r\n<tr>\r\n<th>ID</th>\r\n<th>Hình Ảnh</th>\r\n<th>Tên Truyện</th>\r\n<th>Thể Loại</th>\r\n<th>Giá</th>\r\n<td></td>\r\n</tr>\r\n</thead>");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 15 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor"
 if (ComicData?.Count() > 0)
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor"
 foreach (Comic b in ComicData)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "td");
#nullable restore
#line 20 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor"
__builder.AddContent(9, b.ComicID);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "td");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", "~/Images/" + (
#nullable restore
#line 21 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor"
                         b.ProfilePicture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "alt", "Card image cap");
            __builder.AddAttribute(15, "asp-append-version", "true");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "td");
#nullable restore
#line 22 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor"
__builder.AddContent(18, b.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "td");
#nullable restore
#line 23 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor"
__builder.AddContent(21, b.Genre);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "td");
#nullable restore
#line 24 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor"
__builder.AddContent(24, b.Price.ToString("00,0 VNĐ"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "td");
            __builder.AddMarkupContent(27, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(28);
            __builder.AddAttribute(29, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(30, "href", 
#nullable restore
#line 27 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor"
       GetDetailsUrl(b.ComicID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(32, "\r\nDetails\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
            __builder.AddAttribute(35, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(36, "href", 
#nullable restore
#line 31 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor"
       GetEditUrl(b.ComicID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(38, "\r\nEdit\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor"
            e => Delete(b)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(43, "\r\nDelete\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 40 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor"
 
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "<tr>\r\n<td colspan=\"5\" class=\"text-center\">No Comics</td>\r\n</tr>\r\n");
#nullable restore
#line 47 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
            __builder.AddAttribute(50, "class", "btn btn-primary");
            __builder.AddAttribute(51, "href", "/admin/comics/create");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(53, "Create");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\Test\ComicsStore\ComicsStore\Pages\Admin\Comics.razor"
       
public IComicsStoreRepository Repository => Service;
public IEnumerable<Comic> ComicData { get; set; }
protected async override Task OnInitializedAsync()
{
await UpdateData();
}
public async Task UpdateData()
{
ComicData = await Repository.Comics.ToListAsync();
}
public async Task Delete(Comic b)
{
Repository.Delete(b);
await UpdateData();
}
public string GetDetailsUrl(long id) => $"/admin/comics/details/{id}";
public string GetEditUrl(long id) => $"/admin/comics/edit/{id}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591