#pragma checksum "C:\Users\Ryland\Desktop\Inventory.Solution\Inventory\Views\Items\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9bbfd98fa267ff4a4ee17299ed8a5080d759ef7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_New), @"mvc.1.0.view", @"/Views/Items/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/New.cshtml", typeof(AspNetCore.Views_Items_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9bbfd98fa267ff4a4ee17299ed8a5080d759ef7", @"/Views/Items/New.cshtml")]
    public class Views_Items_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Ryland\Desktop\Inventory.Solution\Inventory\Views\Items\New.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 24, true);
            WriteLiteral("\r\n<h1>Add a new item to ");
            EndContext();
            BeginContext(55, 10, false);
#line 5 "C:\Users\Ryland\Desktop\Inventory.Solution\Inventory\Views\Items\New.cshtml"
                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(65, 14, true);
            WriteLiteral("</h1>\r\n\r\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 79, "\"", 115, 3);
            WriteAttributeValue("", 88, "/categories/", 88, 12, true);
#line 7 "C:\Users\Ryland\Desktop\Inventory.Solution\Inventory\Views\Items\New.cshtml"
WriteAttributeValue("", 100, Model.Id, 100, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 109, "/items", 109, 6, true);
            EndWriteAttribute();
            BeginContext(116, 73, true);
            WriteLiteral(" method=\"post\">\r\n  <input id=\"categoryId\" name=\"categoryId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 189, "\"", 206, 1);
#line 8 "C:\Users\Ryland\Desktop\Inventory.Solution\Inventory\Views\Items\New.cshtml"
WriteAttributeValue("", 197, Model.Id, 197, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(207, 177, true);
            WriteLiteral(">\r\n  <label for=\"itemDescription\">Item Description</label>\r\n  <input id=\"itemDescription\" name=\"itemDescription\" type=\"text\">\r\n  <button type=\'submit\'>Add item</button>\r\n</form>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
