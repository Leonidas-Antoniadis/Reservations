#pragma checksum "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\SubAreas\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f577f60f83b989154e04f0cf8b24c027f3fd881"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SubAreas_Create), @"mvc.1.0.view", @"/Views/SubAreas/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f577f60f83b989154e04f0cf8b24c027f3fd881", @"/Views/SubAreas/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"969a826d033cce8f9b118cb48699c205b151f70c", @"/Views/_ViewImports.cshtml")]
    public class Views_SubAreas_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PtixiakiReservations.Models.SubArea>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\SubAreas\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n\r\n<h4>SubAreas</h4>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f577f60f83b989154e04f0cf8b24c027f3fd8815237", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\SubAreas\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f577f60f83b989154e04f0cf8b24c027f3fd8816916", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 15 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\SubAreas\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AreaName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f577f60f83b989154e04f0cf8b24c027f3fd8818470", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 16 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\SubAreas\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AreaName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""form-group"">
            <input type=""submit"" value=""Create"" class=""btn btn-primary"" id=""create"" />
            <input type=""submit"" value=""Save"" class=""btn btn-primary"" id=""save"" />

        </div>
    </div>
</div>
<canvas id=""c"" width=""600"" height=""600"" style=""border:1px solid #000000;""></canvas>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var canvas = new fabric.Canvas('c');
                $(""#create"").click(function () {
                    var rect = new fabric.Rect({
                        width: 100,
                        height: 100,
                        fill: '#eef',
                        scaleY: 0.5,
                        originX: 'center',
                        originY: 'center'

                    });
                    var name = $(""#name"").val();

               

                    var text = new fabric.Text(name, {
                     fontSize: 15,
                     originX: 'center',
                     originY: 'center',
                     selectable:false
                    });

                    var group = new fabric.Group([rect, text], {
                        left: 150,
                        top: 100, 
                        subTargetCheck: true,
                        hasControls: true,
                        id:name,
                      ");
                WriteLiteral(@"  angle: 0
                    });
                         group.on('mouse:down', function () {
                        console.log(""rect:"");
                        console.log(rect.getWidth());
                        console.log(rect.get('height'));
                         });

                    canvas.add(group);  
                    canvas.add(text);
                });

        $(""#save"").click(function () {
                    var tmp = {};
                     var SubAreas = [];                   
                     
            var canvasObjects = canvas.getObjects();
                    for (obj in canvasObjects) {                     
                      if (canvasObjects[obj].get('type') == 'group') {
                          tmp.Top = canvasObjects[obj].get('top');  
                          tmp.Left = canvasObjects[obj].get('left'); 
                          tmp.AreaName = canvasObjects[obj].get('id');
                          tmp.Rotate = canvasObjects[obj].ge");
                WriteLiteral(@"t('angle');
                          tmp.Width = canvasObjects[obj].getScaledWidth();
                          tmp.Height = canvasObjects[obj].getScaledHeight();;
                        }
                        if (canvasObjects[obj].get('type') == 'text') {                        
                            tmp.AreaName = canvasObjects[obj].get('text');                         
                            SubAreas.push(tmp);                           
                            tmp = {};
                        }           
            }
                  $.ajax(
                 {
                          type: ""Post"",
                          url: '");
#nullable restore
#line 91 "C:\Users\leonidas\source\repos\PtixiakiReservations\PtixiakiReservations\Views\SubAreas\Create.cshtml"
                           Write(Url.Action("Create", "SubAreas"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                          dataType: 'json',
                          contentType: 'application/json; charset=utf-8',
                          data: JSON.stringify(SubAreas),                   
                          success: function (data) { alert(""saved""); },
                          error: function (data) { alert(""fail to save"");},
                          accept: 'application/json'
                    })
                });      

    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PtixiakiReservations.Models.SubArea> Html { get; private set; }
    }
}
#pragma warning restore 1591