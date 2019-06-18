#pragma checksum "D:\workspace\webapi\src\App\Article.WebApp\Shared\FooterMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1e1243472629197f35a26410d8be0c8963379e8"
// <auto-generated/>
#pragma warning disable 1591
namespace Article.WebApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\workspace\webapi\src\App\Article.WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\workspace\webapi\src\App\Article.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\workspace\webapi\src\App\Article.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "D:\workspace\webapi\src\App\Article.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "D:\workspace\webapi\src\App\Article.WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\workspace\webapi\src\App\Article.WebApp\_Imports.razor"
using Article.WebApp.Shared;

#line default
#line hidden
#line 7 "D:\workspace\webapi\src\App\Article.WebApp\_Imports.razor"
using Blazorise;

#line default
#line hidden
    public class FooterMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, @"<footer class=""border-top"">
    <div class=""container-fluid footer-wrap u-clearfix"">
        <section class=""l-container c-footer"">
            <p class=""title"">© 2017 BẢN QUYỀN THUỘC VỀ SHEE Group</p>
            <div class=""content"">
                <span><a data-toggle=""modal"" data-target=""#modal-info"">Giới thiệu</a></span>
                <span><a data-toggle=""modal"" data-target=""#modal-contact"">Liên hệ</a></span>
            </div>

        </section>
    </div>
</footer>

");
            builder.AddMarkupContent(1, @"<div class=""modal fade"" id=""modal-info"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalCenterTitle"">Giới thiệu</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>© 2017 BẢN QUYỀN THUỘC VỀ SHEE Group</p>
                <p>Giấy phép số: 0042/GP-STTTT do Sở TT&TT Tp.Hồ Chí Minh cấp ngày 05/09/2017</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
            </div>
        </div>
    </div>
</div>

");
            builder.AddMarkupContent(2, @"<div class=""modal fade"" id=""modal-contact"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalCenterTitle"">Liên hệ</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p><a class=""text-decoration-none"" href=""tel:84911349349"">Hotline: (+84) 911 349 349</a></p>
                <p><a class=""text-decoration-none"" href=""mailto:shee@uranus.vn"">Email:shee@uranus.vn</a></p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
#line 54 "D:\workspace\webapi\src\App\Article.WebApp\Shared\FooterMenu.razor"
            
    private Modal modalRef;

    private void ShowModal()
    {
        modalRef.Show();
    }
    private void HideModal()
    {
        modalRef.Hide();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
