#pragma checksum "C:\Users\paval\Desktop\Bcit\Term 4\4976\csharp\Assignment1\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aea39c644bc5ccaac52cc24964837ba5f6c5ca9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
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
#line 1 "C:\Users\paval\Desktop\Bcit\Term 4\4976\csharp\Assignment1\Views\_ViewImports.cshtml"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paval\Desktop\Bcit\Term 4\4976\csharp\Assignment1\Views\_ViewImports.cshtml"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aea39c644bc5ccaac52cc24964837ba5f6c5ca9b", @"/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f0efab5ddbb0a5c18cf004c4d9e07516f4dd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment1.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\paval\Desktop\Bcit\Term 4\4976\csharp\Assignment1\Views\Books\Details.cshtml"
  
    ViewData["Title"] = "Details";
    string s = "";
    for(int i = 0; i < 2; i++)
    {
        if(Model.volumeInfo.industryIdentifiers[i].type == "ISBN_10")
        {
            s = Model.volumeInfo.industryIdentifiers[i].identifier;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>");
#nullable restore
#line 15 "C:\Users\paval\Desktop\Bcit\Term 4\4976\csharp\Assignment1\Views\Books\Details.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<img");
            BeginWriteAttribute("src", " src=\"", 338, "\"", 387, 1);
#nullable restore
#line 17 "C:\Users\paval\Desktop\Bcit\Term 4\4976\csharp\Assignment1\Views\Books\Details.cshtml"
WriteAttributeValue("", 344, Model.volumeInfo.imageLinks.smallThumbnail, 344, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n</br>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\paval\Desktop\Bcit\Term 4\4976\csharp\Assignment1\Views\Books\Details.cshtml"
Write(Model.volumeInfo.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</br>\r\n");
#nullable restore
#line 22 "C:\Users\paval\Desktop\Bcit\Term 4\4976\csharp\Assignment1\Views\Books\Details.cshtml"
 foreach (var item in Model.volumeInfo.authors) {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\paval\Desktop\Bcit\Term 4\4976\csharp\Assignment1\Views\Books\Details.cshtml"
Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>, </span>\r\n");
#nullable restore
#line 24 "C:\Users\paval\Desktop\Bcit\Term 4\4976\csharp\Assignment1\Views\Books\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</br>\r\n");
#nullable restore
#line 26 "C:\Users\paval\Desktop\Bcit\Term 4\4976\csharp\Assignment1\Views\Books\Details.cshtml"
Write(Model.volumeInfo.publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</br>\r\n");
#nullable restore
#line 28 "C:\Users\paval\Desktop\Bcit\Term 4\4976\csharp\Assignment1\Views\Books\Details.cshtml"
Write(Model.volumeInfo.publishedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</br>\r\n");
#nullable restore
#line 30 "C:\Users\paval\Desktop\Bcit\Term 4\4976\csharp\Assignment1\Views\Books\Details.cshtml"
Write(Model.volumeInfo.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</br>\r\n");
#nullable restore
#line 32 "C:\Users\paval\Desktop\Bcit\Term 4\4976\csharp\Assignment1\Views\Books\Details.cshtml"
Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment1.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
