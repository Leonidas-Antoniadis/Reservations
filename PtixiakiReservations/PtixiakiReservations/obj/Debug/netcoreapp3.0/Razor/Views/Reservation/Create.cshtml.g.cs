#pragma checksum "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35600fec356043c22a7057ca3fbb153dbe1b2f0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_Create), @"mvc.1.0.view", @"/Views/Reservation/Create.cshtml")]
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
#line 1 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\_ViewImports.cshtml"
using PtixiakiReservations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\_ViewImports.cshtml"
using PtixiakiReservations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35600fec356043c22a7057ca3fbb153dbe1b2f0c", @"/Views/Reservation/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"969a826d033cce8f9b118cb48699c205b151f70c", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PtixiakiReservations.Models.Event>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n\r\n<h4>Reservation</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        Start Time -End Time:<input class=\"form-control\" type=\"datetime\" id=\"date\"");
            BeginWriteAttribute("value", " value=\"", 266, "\"", 319, 3);
#nullable restore
#line 13 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
WriteAttributeValue("", 274, Model.StartDateTime, 274, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 294, "-", 294, 1, true);
#nullable restore
#line 13 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
WriteAttributeValue("", 295, Model.EndTime.TimeOfDay, 295, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly=\"readonly\" />\r\n        <input class=\"form-control\" type=\"hidden\" id=\"startTime\"");
            BeginWriteAttribute("value", " value=\"", 409, "\"", 447, 1);
#nullable restore
#line 14 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
WriteAttributeValue("", 417, Model.StartDateTime.TimeOfDay, 417, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly=\"readonly\" />\r\n        <input class=\"form-control\" type=\"hidden\" id=\"endTime\"");
            BeginWriteAttribute("value", " value=\"", 535, "\"", 567, 1);
#nullable restore
#line 15 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
WriteAttributeValue("", 543, Model.EndTime.TimeOfDay, 543, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly=""readonly"" />
        <div class=""col-md-6"">
            Start Time:<input class=""form-control"" type=""time"" id=""StartTime"" />From Start: <input type=""checkbox"" id=""StartCheck"" />
            <br />End Time:<input class=""form-control"" type=""time"" id=""EndTime"" />Until End: <input type=""checkbox"" id=""EndCheck"" />
        </div>
    </div>
</div>

<div>
    <input type=""submit"" value=""Go to Tables"" class=""btn btn-primary"" id=""goto"" />  
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<script>


    const qstr = window.location.search;
    const urlParams = new URLSearchParams(qstr);
    const venueId = urlParams.get('VenueId');
    const EventId = urlParams.get('EventId');


    function msToTime(s) {
    var ms = s % 1000;
    s = (s - ms) / 1000;
    var secs = s % 60;
    s = (s - secs) / 60;
    var mins = s % 60;
    var hrs = (s - mins) / 60;

    return hrs + ':' + mins;
}
    $(""#goto"").click(function () {
        var StartTime = 0;
        var EndTime = 0;
        var date = 0;
        EndTime = $(""#endTime"").val();
        date =  ");
#nullable restore
#line 53 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
           Write(Model.StartDateTime.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(" + \"-\" + ");
#nullable restore
#line 53 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
                                             Write(Model.StartDateTime.Month);

#line default
#line hidden
#nullable disable
                WriteLiteral(" +\"-\" + ");
#nullable restore
#line 53 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
                                                                               Write(Model.StartDateTime.Day);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        date = new Date(date);\r\n        date = date.setHours(date.getHours() + ");
#nullable restore
#line 55 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
                                          Write(Model.EndTime.Hour);

#line default
#line hidden
#nullable disable
                WriteLiteral(" );\r\n        date = new Date(date);\r\n        date= date.setMinutes(date.getMinutes() + ");
#nullable restore
#line 57 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
                                             Write(Model.EndTime.Minute);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" );
        if (new Date() > new Date(date)) {
            alert(""This event has passed"");
            
        } else {
            if ($(""#StartTime"").val() != 0 && $(""#StartCheck"").is(':checked')) {
                alert(""Check the Box Or Fill the Time"");
            } else
                if ($(""#StartTime"").val() != 0) {
                    StartTime = $(""#StartTime"").val();
                    date =  ");
#nullable restore
#line 67 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
                       Write(Model.StartDateTime.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(" + \"-\" + ");
#nullable restore
#line 67 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
                                                         Write(Model.StartDateTime.Month);

#line default
#line hidden
#nullable disable
                WriteLiteral(" +\"-\" + ");
#nullable restore
#line 67 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
                                                                                           Write(Model.StartDateTime.Day);

#line default
#line hidden
#nullable disable
                WriteLiteral(" +\"T\" + StartTime;\r\n                } else if ($(\"#StartCheck\").is(\':checked\')) {\r\n                    StartTime = $(\"#startTime\").val();\r\n\r\n                    console.log(StartTime);\r\n                    date =  ");
#nullable restore
#line 72 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
                       Write(Model.StartDateTime.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(" + \"-\" + ");
#nullable restore
#line 72 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
                                                         Write(Model.StartDateTime.Month);

#line default
#line hidden
#nullable disable
                WriteLiteral(" +\"-\" + ");
#nullable restore
#line 72 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
                                                                                           Write(Model.StartDateTime.Day);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" +""T"" + StartTime;
                    console.log(date);
                }
            if ($(""#EndTime"").val() != 0 && $(""#EndCheck"").is(':checked')) {
                alert(""Check the Box Or Fill the Time"");
            } else
                if ($(""#EndTime"").val() != 0) {
                    EndTime = $(""#EndTime"").val();
                } else if ($(""#EndCheck"").is(':checked')) {
                    EndTime = ");
#nullable restore
#line 81 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
                         Write(Model.EndTime.Hour);

#line default
#line hidden
#nullable disable
                WriteLiteral(" +\':\' +");
#nullable restore
#line 81 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
                                                   Write(Model.EndTime.Minute);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                }
            if (StartTime == 0 || EndTime == 0) {
                alert(""Fill start time and end time or check the boxes"");
            }
            else {
                var timeStart = new Date(""01/01/2007 "" + StartTime);
                var timeEnd = new Date(""01/01/2007 "" + EndTime);
                var difference = timeEnd - timeStart;
                var Duration = msToTime(difference);
                if (difference < 0) {
                    alert(""your end time must higer than your start"");
                } else {
                    var url = ""/SubAreas/ChooseSubArea?VenueId="" + venueId + ""&EventId="" + ");
#nullable restore
#line 94 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\Reservation\Create.cshtml"
                                                                                      Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(" + \"&Duration=\" + Duration + \"&ResDate=\" + date;\r\n                       window.location.href = url;\r\n                }\r\n            }\r\n        }\r\n        });\r\n\r\n</script>\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PtixiakiReservations.Models.Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
