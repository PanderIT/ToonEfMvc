#pragma checksum "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f84cd4ed1af501eafb3b0943c5de217134914e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Index), @"mvc.1.0.view", @"/Views/People/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\_ViewImports.cshtml"
using ToonEfMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\_ViewImports.cshtml"
using ToonEfMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f84cd4ed1af501eafb3b0943c5de217134914e", @"/Views/People/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9516addf30ac7b7feb30c9d3659e73993d2b053", @"/Views/_ViewImports.cshtml")]
    public class Views_People_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToonEfMvc.Models.Toons.People>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Toon People</h1>\r\n\r\n<table class=\"table-striped table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Picture\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 1383, "\"", 1434, 1);
#nullable restore
#line 51 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
WriteAttributeValue("", 1389, Html.DisplayFor(modelItem=> item.PictureUrl), 1389, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1435, "\"", 1487, 1);
#nullable restore
#line 51 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
WriteAttributeValue("", 1441, Html.DisplayFor(modelItem => item.PictureUrl), 1441, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\Freyd\Desktop\COMP 4976\Apps\Lab3\ToonEfMvc\ToonEfMvc\Views\People\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToonEfMvc.Models.Toons.People>> Html { get; private set; }
    }
}
#pragma warning restore 1591
