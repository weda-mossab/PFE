#pragma checksum "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43199cda165babbcfda572fb0a20d8bee1013350"
// <auto-generated/>
#pragma warning disable 1591
namespace Interface_APP.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\_Imports.razor"
using Interface_APP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\_Imports.razor"
using Interface_APP.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\Pages\Index.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : ViewImg
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Index");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, @"<div id=""sidebar-wrapper"" b-ico2ku25x8><ul class=""sidebar-nav nav navbar-inverse flex-column mb-auto"" b-ico2ku25x8><li b-ico2ku25x8><div b-ico2ku25x8><br b-ico2ku25x8>
        <h5 class=""title"" b-ico2ku25x8><span class=""bi bi-braces"" b-ico2ku25x8></span> Prediction results</h5></div></li><br b-ico2ku25x8></ul></div> 
 ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-5");
            __builder.AddAttribute(7, "b-ico2ku25x8");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "image-container");
            __builder.AddAttribute(10, "b-ico2ku25x8");
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "class", "preview-image");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 25 "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\Pages\Index.razor"
                                            imagePreview

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "b-ico2ku25x8");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenComponent<global::BlazorInputFile.InputFile>(16);
            __builder.AddAttribute(17, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::BlazorInputFile.IFileListEntry[]>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 27 "C:\Users\MedNourBn\Desktop\STAGE PFE\DevTest\Interface_APP\Pages\Index.razor"
                                              ViewImage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
