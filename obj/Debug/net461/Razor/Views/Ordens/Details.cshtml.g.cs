#pragma checksum "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4c7edc608d09a1cca81f888e7ed45ecc74011d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ordens_Details), @"mvc.1.0.view", @"/Views/Ordens/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ordens/Details.cshtml", typeof(AspNetCore.Views_Ordens_Details))]
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
#line 1 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\_ViewImports.cshtml"
using PrimerParcial;

#line default
#line hidden
#line 2 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\_ViewImports.cshtml"
using PrimerParcial.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c7edc608d09a1cca81f888e7ed45ecc74011d2", @"/Views/Ordens/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a49c96d267825d6e4e5875e2249f7b27f117d1de", @"/Views/_ViewImports.cshtml")]
    public class Views_Ordens_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrimerParcial.ViewModels.OrdenView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ValidarImprimir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var id = Model.Orden.ordenID;

#line default
#line hidden
            BeginContext(123, 579, true);
            WriteLiteral(@"
<h2>Details</h2>

<div class=""modal fade"" id=""adicionarArticulo"" tabindex=""-1"" role=""dialog"" aria-labelledby=""gridSystemModalLabel"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <h4 class=""modal-title"" id=""gridSystemModalLabel"">Adicionar Artículo</h4>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(703, 158, false);
#line 18 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
           Write(await Html.PartialAsync("AddArticulo", Model.OrdenDetalle, new ViewDataDictionary(ViewData)
                {
                 {"id",id}
                }));

#line default
#line hidden
            EndContext();
            BeginContext(861, 383, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Cerrar</button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div><!-- /.modal -->



<div>
    <h4>Orden</h4>
    <hr />
    <dl class=""dl-horizontal"">
        <dt>
            ");
            EndContext();
            BeginContext(1245, 50, false);
#line 37 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Orden.Suplidor));

#line default
#line hidden
            EndContext();
            BeginContext(1295, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1339, 53, false);
#line 40 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Orden.Suplidor.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1436, 51, false);
#line 43 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Orden.FormaPago));

#line default
#line hidden
            EndContext();
            BeginContext(1487, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1531, 68, false);
#line 46 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Orden.FormaPago.formaPagoDescripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1643, 52, false);
#line 49 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Orden.FormaEnvio));

#line default
#line hidden
            EndContext();
            BeginContext(1695, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1739, 70, false);
#line 52 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Orden.FormaEnvio.formaEnvioDescripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1809, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1853, 52, false);
#line 55 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Orden.fechaOrden));

#line default
#line hidden
            EndContext();
            BeginContext(1905, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1949, 48, false);
#line 58 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Orden.fechaOrden));

#line default
#line hidden
            EndContext();
            BeginContext(1997, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2041, 53, false);
#line 61 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Orden.observacion));

#line default
#line hidden
            EndContext();
            BeginContext(2094, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2138, 49, false);
#line 64 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Orden.observacion));

#line default
#line hidden
            EndContext();
            BeginContext(2187, 869, true);
            WriteLiteral(@"
        </dd>
    </dl>
</div>


<div class=""form-group"">
    <!-- modal -->
    <button type=""button"" class=""btn btn-success btn-large"" data-toggle=""modal"" data-target=""#adicionarArticulo"">Adicionar Artículo</button>

    
</div>

<div class=""x_content"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""card-box table-responsive"">
                <table id=""grid"" name=""grid"" class=""table table-striped table-bordered"">
                    <thead>
                        <tr>
                            <th>Codigo</th>
                            <th>Nombre</th>
                            <th>Precio</th>
                            <th>Cantidad</th>
                            <th>Precio Total</th>
                        </tr>
                    </thead>

                    <tbody class=""data"">

");
            EndContext();
#line 94 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
                         foreach (var item in Model.Articulos)
                        {

#line default
#line hidden
            BeginContext(3147, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3256, 54, false);
#line 98 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Articulo.idArticulo));

#line default
#line hidden
            EndContext();
            BeginContext(3310, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3426, 50, false);
#line 101 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Articulo.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(3476, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3592, 41, false);
#line 104 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.precio));

#line default
#line hidden
            EndContext();
            BeginContext(3633, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3749, 43, false);
#line 107 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(3792, 117, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3910, 49, false);
#line 111 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Orden.subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(3959, 193, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                            </tr>\r\n                            <!-- <td>\r\n                 <a class=\"btn btn-primary\" asp-action=\"Edit\" asp-route-id=\"");
            EndContext();
            BeginContext(4153, 18, false);
#line 116 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
                                                                       Write(item.ordenDetallID);

#line default
#line hidden
            EndContext();
            BeginContext(4171, 101, true);
            WriteLiteral("\">Edit</a> |\r\n                 <a class=\"btn btn-danger\" asp-action=\"EliminarArticulo\" asp-route-id=\"");
            EndContext();
            BeginContext(4273, 18, false);
#line 117 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
                                                                                  Write(item.ordenDetallID);

#line default
#line hidden
            EndContext();
            BeginContext(4291, 39, true);
            WriteLiteral("\">Delete</a>\r\n             </td>  -->\r\n");
            EndContext();
#line 119 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(4357, 188, true);
            WriteLiteral("                    </tbody>\r\n\r\n                    <tbody class=\"data\">       \r\n                        <tr>\r\n                            <td>\r\n                                SubTotal:  ");
            EndContext();
            BeginContext(4546, 50, false);
#line 125 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
                                      Write(Html.DisplayFor(modelItem => Model.Orden.subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(4596, 177, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td>\r\n                                Impuesto:  ");
            EndContext();
            BeginContext(4774, 50, false);
#line 131 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
                                      Write(Html.DisplayFor(modelItem => Model.Orden.impuesto));

#line default
#line hidden
            EndContext();
            BeginContext(4824, 175, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td>\r\n                                Total:   ");
            EndContext();
            BeginContext(5000, 47, false);
#line 137 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
                                    Write(Html.DisplayFor(modelItem => Model.Orden.total));

#line default
#line hidden
            EndContext();
            BeginContext(5047, 200, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n\r\n\r\n\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n </div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(5247, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fc8dfc75e2a44968dca945361e2acec", async() => {
                BeginContext(5321, 14, true);
                WriteLiteral("Imprimir Orden");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 151 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\Details.cshtml"
                                                             WriteLiteral(id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5339, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(5345, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a988b27fb814e5cb87ab36684ef4ec7", async() => {
                BeginContext(5391, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5407, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrimerParcial.ViewModels.OrdenView> Html { get; private set; }
    }
}
#pragma warning restore 1591
