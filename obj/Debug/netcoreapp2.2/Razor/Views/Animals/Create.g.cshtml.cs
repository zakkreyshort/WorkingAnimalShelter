#pragma checksum "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a4e281e3f6a16e8ea5d31ae1dd935f51cdf9cce"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a4e281e3f6a16e8ea5d31ae1dd935f51cdf9cce", @"/Views/Animals/Create.cshtml")]
    public class Views_Animals_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnimalShelter.Models.Animal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(63, 27, true);
            WriteLiteral("\n<h4>Add a new Animal</h4>\n");
            EndContext();
#line 8 "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(123, 41, false);
#line 10 "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(170, 43, false);
#line 11 "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml"
Write(Html.TextBoxFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(214, 9, true);
            WriteLiteral("    <br>\n");
            EndContext();
            BeginContext(228, 34, false);
#line 13 "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(268, 36, false);
#line 14 "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(305, 9, true);
            WriteLiteral("    <br>\n");
            EndContext();
            BeginContext(319, 33, false);
#line 16 "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml"
Write(Html.LabelFor(model => model.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(358, 35, false);
#line 17 "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml"
Write(Html.TextBoxFor(model => model.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(394, 9, true);
            WriteLiteral("    <br>\n");
            EndContext();
            BeginContext(408, 35, false);
#line 19 "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml"
Write(Html.LabelFor(model => model.Breed));

#line default
#line hidden
            EndContext();
            BeginContext(449, 37, false);
#line 20 "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml"
Write(Html.TextBoxFor(model => model.Breed));

#line default
#line hidden
            EndContext();
            BeginContext(487, 9, true);
            WriteLiteral("    <br>\n");
            EndContext();
            BeginContext(501, 39, false);
#line 22 "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml"
Write(Html.LabelFor(model => model.EntryDate));

#line default
#line hidden
            EndContext();
            BeginContext(546, 41, false);
#line 23 "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml"
Write(Html.TextBoxFor(model => model.EntryDate));

#line default
#line hidden
            EndContext();
            BeginContext(588, 60, true);
            WriteLiteral("    <br>\n    <input type=\"submit\" value=\"Add new animal\" />\n");
            EndContext();
#line 26 "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml"
}

#line default
#line hidden
            BeginContext(650, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(654, 44, false);
#line 27 "/Users/zakkreyshort/Desktop/AnimalShelter.Solution/Views/Animals/Create.cshtml"
Write(Html.ActionLink("Show all animals", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(698, 4, true);
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
