#pragma checksum "C:\Users\Ryland\Desktop\Inventory.Solution\Inventory\Views\Categories\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f51cedd3df212ac3b60b5f8cebe3f4f5f1bdb568"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_New), @"mvc.1.0.view", @"/Views/Categories/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/New.cshtml", typeof(AspNetCore.Views_Categories_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f51cedd3df212ac3b60b5f8cebe3f4f5f1bdb568", @"/Views/Categories/New.cshtml")]
    public class Views_Categories_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Ryland\Desktop\Inventory.Solution\Inventory\Views\Categories\New.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 348, true);
            WriteLiteral(@"
<h1>Add a category</h1>
<p>Add a category here:</p>

<form action=""/categories"" method=""post"">
  <label for=""categoryName"">Category name</label>
  <input id=""categoryName"" name=""categoryName"" type=""text"">
  <button type=""submit"">Add</button>
</form>

<p><a href=""/"">Back home</a></p>
<p><a href=""/categories"">Back to categories.</a></p>");
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
