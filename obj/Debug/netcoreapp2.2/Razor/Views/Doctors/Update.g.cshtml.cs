#pragma checksum "F:\programming\Asp.netCore\hospital\Views\Doctors\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f0cc61d89025426cc1442442998eb31f2423eef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Update), @"mvc.1.0.view", @"/Views/Doctors/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doctors/Update.cshtml", typeof(AspNetCore.Views_Doctors_Update))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f0cc61d89025426cc1442442998eb31f2423eef", @"/Views/Doctors/Update.cshtml")]
    public class Views_Doctors_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<hospital.Models.Doctors>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 696, true);
            WriteLiteral(@"<section class=""content-header"">
    <h1>
    Doctors
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <!-- Horizontal Form -->
    <div class=""box box-info"">
    <div class=""box-header with-border"">
        <h3 class=""box-title"">Update Doctor</h3>
    </div>
    <!-- /.box-header -->
    <!-- form start -->
    <form class=""form-horizontal"" method=""post"" action=""/Doctors/UpdateDoctor"">
        <div class=""box-body"">
        <div class=""form-group"">
            <label for=""inputEmail3"" class=""col-sm-2 control-label"">Email</label>
            <div class=""col-sm-10"">
            <input type=""Email"" class=""form-control"" name=""Email""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 728, "\"", 748, 1);
#line 21 "F:\programming\Asp.netCore\hospital\Views\Doctors\Update.cshtml"
WriteAttributeValue("", 736, Model.Email, 736, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(749, 274, true);
            WriteLiteral(@">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""inputEmail3"" class=""col-sm-2 control-label"">Name</label>
            <div class=""col-sm-10"">
            <input type=""text"" class=""form-control"" name=""Name"" placeholder=""Name""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1023, "\"", 1042, 1);
#line 27 "F:\programming\Asp.netCore\hospital\Views\Doctors\Update.cshtml"
WriteAttributeValue("", 1031, Model.Name, 1031, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1043, 277, true);
            WriteLiteral(@">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""inputEmail3"" class=""col-sm-2 control-label"">Phone</label>
            <div class=""col-sm-10"">
            <input type=""text"" class=""form-control"" name=""Phone"" placeholder=""Phone""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1320, "\"", 1340, 1);
#line 33 "F:\programming\Asp.netCore\hospital\Views\Doctors\Update.cshtml"
WriteAttributeValue("", 1328, Model.Phone, 1328, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1341, 292, true);
            WriteLiteral(@">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""inputEmail3"" class=""col-sm-2 control-label"">Specialist</label>
            <div class=""col-sm-10"">
            <input type=""text"" class=""form-control"" name=""Specialist"" placeholder=""Specialist""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1633, "\"", 1658, 1);
#line 39 "F:\programming\Asp.netCore\hospital\Views\Doctors\Update.cshtml"
WriteAttributeValue("", 1641, Model.Specialist, 1641, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1659, 77, true);
            WriteLiteral(">\r\n            </div>\r\n        </div>\r\n        <input type=\"hidden\" name=\"Id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1736, "\"", 1753, 1);
#line 42 "F:\programming\Asp.netCore\hospital\Views\Doctors\Update.cshtml"
WriteAttributeValue("", 1744, Model.Id, 1744, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1754, 335, true);
            WriteLiteral(@"/>
        </div>
        <!-- /.box-body -->
        <div class=""box-footer"">
        <button type=""submit"" class=""btn btn-default"">Cancel</button>
        <button type=""submit"" class=""btn btn-info pull-right"">Update</button>
        </div>
        <!-- /.box-footer -->
    </form>
    </div>
    <!-- /.box -->
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<hospital.Models.Doctors> Html { get; private set; }
    }
}
#pragma warning restore 1591
