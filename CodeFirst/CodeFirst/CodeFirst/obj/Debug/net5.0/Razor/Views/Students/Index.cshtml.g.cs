#pragma checksum "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Hw\HW_Week06_Day05_Many-To-Many\CodeFirst\CodeFirst\CodeFirst\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e41c1545d2060f3de05d3dadf004e89abfc6924"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#line 1 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Hw\HW_Week06_Day05_Many-To-Many\CodeFirst\CodeFirst\CodeFirst\Views\_ViewImports.cshtml"
using CodeFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Hw\HW_Week06_Day05_Many-To-Many\CodeFirst\CodeFirst\CodeFirst\Views\_ViewImports.cshtml"
using CodeFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e41c1545d2060f3de05d3dadf004e89abfc6924", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd5f0dc6fe3b6a8594f00d895713baeafd515ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Hw\HW_Week06_Day05_Many-To-Many\CodeFirst\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
  
    ViewData["Title"] = "Students";
    var students = (List<Student>) ViewData["Students"];
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid"">
    
</div>

<table class=""table table-hover"">
    <th>
        <tr>
        <td>Id</td>
        <td>First Name</td>
        <td>Last Name</td>
        <td>Email</td>
        </tr>
    </th>
    
    <tbody>
");
#nullable restore
#line 24 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Hw\HW_Week06_Day05_Many-To-Many\CodeFirst\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
     foreach (var student in students)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Hw\HW_Week06_Day05_Many-To-Many\CodeFirst\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
           Write(student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Hw\HW_Week06_Day05_Many-To-Many\CodeFirst\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
           Write(student.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Hw\HW_Week06_Day05_Many-To-Many\CodeFirst\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
           Write(student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Hw\HW_Week06_Day05_Many-To-Many\CodeFirst\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
           Write(student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Hw\HW_Week06_Day05_Many-To-Many\CodeFirst\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
