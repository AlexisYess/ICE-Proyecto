#pragma checksum "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a45f2267069d57bdfeba53737228b8d99b9f43b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grupo_Index), @"mvc.1.0.view", @"/Views/Grupo/Index.cshtml")]
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
#line 1 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\_ViewImports.cshtml"
using ICE.UI.WebAspCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\_ViewImports.cshtml"
using ICE.UI.WebAspCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a45f2267069d57bdfeba53737228b8d99b9f43b6", @"/Views/Grupo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be2d3a07013edbf6f407b253b1960da89934ad3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Grupo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ICE.Control.EntidadesDeNegocio.Grupo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int numPage = 1;
    int numRegistros = 0;
    int numRegistrosPorPage = 10;
    int[] tops = { 10, 20, 50, 100, 500, 1000, 10000, -1 };
    int topActual = Convert.ToInt32(ViewBag.Top);

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Buscar</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a45f2267069d57bdfeba53737228b8d99b9f43b65223", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <label class=""control-label"">Nombre</label>
                        <input type=""text"" class=""form-control"" name=""nombre"" />
                    </div>
                 
                </div>
                <div class=""col-md-2"">
                    <div class=""form-group"">
                        <label class=""control-label"">Top</label>
                        <select name=""top_aux"" class=""form-control"">
");
#nullable restore
#line 27 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
                             foreach (var item in tops)
                            {
                                string strItem = item != -1 ? item.ToString() : "Todos";
                                if (item != topActual)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a45f2267069d57bdfeba53737228b8d99b9f43b66619", async() => {
#nullable restore
#line 32 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
                                                     Write(strItem);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
                                       WriteLiteral(item);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a45f2267069d57bdfeba53737228b8d99b9f43b68997", async() => {
#nullable restore
#line 36 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
                                                              Write(strItem);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
                                                WriteLiteral(item);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Buscar\" class=\"btn btn-outline-primary\" />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a45f2267069d57bdfeba53737228b8d99b9f43b611907", async() => {
                    WriteLiteral("Crear");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n<table class=\"table table-hover\">\r\n    <thead class=\"badge-success\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n          \r\n            <th colspan=\"3\">Acciones</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 63 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr data-page=\"");
#nullable restore
#line 65 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
                      Write(numPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n               \r\n                <td class=\"botonestabla\">\r\n                    ");
#nullable restore
#line 71 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
               Write(Html.ActionLink("Modificar", "Edit", new { id = item.Id }, new { @class = "btn btn-outline-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"botonestabla\">\r\n                    ");
#nullable restore
#line 74 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
               Write(Html.ActionLink("Ver", "Details", new { id = item.Id }, new { @class = "btn btn-outline-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"botonestabla\">\r\n                    ");
#nullable restore
#line 77 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
               Write(Html.ActionLink("Eliminar", "Delete", new { id = item.Id }, new { @class = "btn btn-outline-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 80 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
            numRegistros++;
            if (numRegistros == numRegistrosPorPage)
            {
                numPage++;
                numRegistros = 0;
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
          
            if (numRegistros == 0)
            {
                numPage--;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 95 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
 if (numPage > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\" style=\"overflow:auto\">\r\n        <div class=\"col-md-12\">\r\n            <ul class=\"pagination paginationjs\" data-numpage=\"");
#nullable restore
#line 99 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
                                                         Write(numPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-pageactive=\"1\">\r\n                <li class=\"page-item\" data-typepage=\"Previous\"><a class=\"page-link\" href=\"#\">Previous</a></li>\r\n");
#nullable restore
#line 101 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
                 for (var i = 1; i <= numPage; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\" data-page=\"");
#nullable restore
#line 103 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-typepage=\"Item\"><a class=\"page-link\" href=\"#\">");
#nullable restore
#line 103 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 104 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\" data-typepage=\"Next\"><a class=\"page-link\" href=\"#\">Next</a></li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 109 "C:\Users\melvin velasquez\Desktop\Listo\version3.1-1\version3.1\Finalizado\PROECTOICE\ICE\ICE.UI.WebAspCore\Views\Grupo\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ICE.Control.EntidadesDeNegocio.Grupo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
