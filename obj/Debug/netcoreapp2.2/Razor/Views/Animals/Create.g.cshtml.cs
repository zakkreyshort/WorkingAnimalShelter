#pragma checksum "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ea5532ebe6d9a1dc99cdc3e0e91f901e748b44c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animals_Create), @"mvc.1.0.view", @"/Views/Animals/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Animals/Create.cshtml", typeof(AspNetCore.Views_Animals_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea5532ebe6d9a1dc99cdc3e0e91f901e748b44c", @"/Views/Animals/Create.cshtml")]
    public class Views_Animals_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnimalShelter.Models.Animal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(68, 29, true);
            WriteLiteral("\r\n<h4>Add a new Animal</h4>\r\n");
            EndContext();
#line 8 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(132, 41, false);
#line 10 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Create.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(180, 43, false);
#line 11 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Create.cshtml"
Write(Html.TextBoxFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(225, 52, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new animal\" />\r\n");
            EndContext();
#line 13 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Create.cshtml"
}

#line default
#line hidden
            BeginContext(280, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(284, 44, false);
#line 14 "C:\Users\ThinkPad\desktop\AnimalShelter\Views\Animals\Create.cshtml"
Write(Html.ActionLink("Show all animals", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(328, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnimalShelter.Models.Animal> Html { get; private set; }
    }
}
#pragma warning restore 1591
