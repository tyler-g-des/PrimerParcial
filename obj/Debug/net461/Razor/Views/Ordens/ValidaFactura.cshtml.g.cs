#pragma checksum "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5057b26adc96975beec04f093d3ab060e12ebd4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ordens_ValidaFactura), @"mvc.1.0.view", @"/Views/Ordens/ValidaFactura.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ordens/ValidaFactura.cshtml", typeof(AspNetCore.Views_Ordens_ValidaFactura))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5057b26adc96975beec04f093d3ab060e12ebd4b", @"/Views/Ordens/ValidaFactura.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a49c96d267825d6e4e5875e2249f7b27f117d1de", @"/Views/_ViewImports.cshtml")]
    public class Views_Ordens_ValidaFactura : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrimerParcial.ViewModels.OrdenView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Factura", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuardarImpresion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fa fa-download"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
  
    ViewData["Title"] = "ValidaFactura";
    var id = Model.Orden.ordenID;

#line default
#line hidden
            BeginContext(129, 961, true);
            WriteLiteral(@"
    <div class=""invoice"" style=""margin-left: 0 !important; margin-right: 0 !important;"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <h2 class=""page-header"">
                    <i class=""fa fa-globe""></i> Tyler Anthony Company
                    <small class=""pull-right col-sm-4 invoice-col"">
                        Fecha:

                        <script>
                            var f = new Date();
                            document.write(f.getDate() + ""/"" + (f.getMonth() + 1) + ""/"" + f.getFullYear());
                            console.write(f.getDate() + ""/"" + (f.getMonth() + 1) + ""/"" + f.getFullYear());
                        </script>
                    </small>
                </h2>
            </div>
        </div>
        <div class=""row invoice-info"">
            <div class=""col-sm-4 invoice-col"">
                From
                <address>
                    <strong>");
            EndContext();
            BeginContext(1091, 57, false);
#line 29 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                       Write(Html.DisplayFor(modelItem => Model.Orden.Suplidor.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 50, true);
            WriteLiteral("</strong><br>\r\n                    Clasificacion: ");
            EndContext();
            BeginContext(1199, 87, false);
#line 30 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                              Write(Html.DisplayFor(modelItem => Model.Orden.Suplidor.clasificacionSuplidor.TipoDeSuplidor));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 33, true);
            WriteLiteral("<br>\r\n                    Phone: ");
            EndContext();
            BeginContext(1320, 59, false);
#line 31 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                      Write(Html.DisplayFor(modelItem => Model.Orden.Suplidor.telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 33, true);
            WriteLiteral("<br>\r\n                    Email: ");
            EndContext();
            BeginContext(1413, 56, false);
#line 32 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                      Write(Html.DisplayFor(modelItem => Model.Orden.Suplidor.email));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 1394, true);
            WriteLiteral(@"
                </address>
            </div>
            <div class=""col-sm-4 invoice-col"">
                To
                <address>
                    <strong>Empresa Tyler - Anthony</strong><br>
                    Phone: (555) 539-1037<br>
                    Email: tyler-Anthony@hotmail.com
                </address>
            </div>
            <div class=""col-sm-4 invoice-col"">
                <b>Invoice #007612</b><br>
                <b>Order ID:</b> 4F3S8J<br>
                <b>Payment Due:</b> 2/22/2014<br>
                <b>Account:</b> 968-34567
            </div>
        </div>
        <!-- Tabla -->
        <div class=""x_content"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <div class=""card-box table-responsive"">
                        <table id=""grid"" name=""grid"" class=""table table-striped table-bordered"">
                            <thead>
                                <tr>
                                  ");
            WriteLiteral(@"  <th>Codigo</th>
                                    <th>Nombre</th>
                                    <th>Precio</th>
                                    <th>Cantidad</th>
                                    <th>Precio Total</th>
                                </tr>
                            </thead>

                            <tbody class=""data"">

");
            EndContext();
#line 68 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                                 foreach (var item in Model.Articulos)
                                {

#line default
#line hidden
            BeginContext(2970, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3103, 54, false);
#line 72 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Articulo.idArticulo));

#line default
#line hidden
            EndContext();
            BeginContext(3157, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3297, 50, false);
#line 75 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Articulo.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(3347, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3487, 41, false);
#line 78 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.precio));

#line default
#line hidden
            EndContext();
            BeginContext(3528, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3668, 43, false);
#line 81 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(3711, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3851, 49, false);
#line 84 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Orden.subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(3900, 93, true);
            WriteLiteral("v\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 87 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                                }

#line default
#line hidden
            BeginContext(4028, 859, true);
            WriteLiteral(@"
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>

        </div>
        <div class=""row"">
            <div class=""col-xs-6"">
                <p class=""lead"">Forma de pago:</p>
                <img src=""../../AdminLTE/dist/img/credit/visa.png"" alt=""Visa"">
                <img src=""../../AdminLTE/dist/img/credit/mastercard.png"" alt=""Mastercard"">
                <img src=""../../AdminLTE/dist/img/credit/american-express.png"" alt=""American Express"">
                <img src=""../../AdminLTE/dist/img/credit/paypal2.png"" alt=""Paypal"">
                <p class=""text-muted well well-sm no-shadow"" style=""margin-top: 10px;"">
                    <strong> Gracias queridos Suplidores</strong> la forma de pago seleccionada fue
                    <strong> ");
            EndContext();
            BeginContext(4888, 72, false);
#line 105 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                        Write(Html.DisplayFor(modelItem => Model.Orden.FormaPago.formaPagoDescripcion));

#line default
#line hidden
            EndContext();
            BeginContext(4960, 523, true);
            WriteLiteral(@" </strong>
                </p>

            </div>
        </div>

        <div class=""row"">
            <!--Detalles numeros-->
            <div class=""col-xs-6"">
                <p class=""lead""> Detalles </p>

                <div class=""table-responsive"">
                    <table class=""table"">

                        <tbody class=""data"">
                            <tr>
                                <th>SubTotal:</th>
                                <td>
                                    ");
            EndContext();
            BeginContext(5484, 50, false);
#line 123 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                               Write(Html.DisplayFor(modelItem => Model.Orden.subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(5534, 238, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <th>Impuesto:</th>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(5773, 50, false);
#line 130 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                               Write(Html.DisplayFor(modelItem => Model.Orden.impuesto));

#line default
#line hidden
            EndContext();
            BeginContext(5823, 235, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <th>Envio:</th>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(6059, 74, false);
#line 137 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                               Write(Html.DisplayFor(modelItem => Model.Orden.FormaEnvio.formaEnvioDescripcion));

#line default
#line hidden
            EndContext();
            BeginContext(6133, 236, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <th>Total: </th>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(6370, 47, false);
#line 144 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                               Write(Html.DisplayFor(modelItem => Model.Orden.total));

#line default
#line hidden
            EndContext();
            BeginContext(6417, 289, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""row no-print"">
            <div class=""col-xs-12"">
                ");
            EndContext();
            BeginContext(6706, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "733fe56dffcd45dcada4f466c2d2818a", async() => {
                BeginContext(6789, 33, true);
                WriteLiteral("<i class=\"fa fa-print\"></i> Print");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 154 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                                          WriteLiteral(id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6826, 309, true);
            WriteLiteral(@"
                <button type=""button"" class=""btn btn-success pull-right"">
                    <i class=""fa fa-credit-card""></i> Submit Payment
                </button>
                <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px;"">
                    Generate PDF ");
            EndContext();
            BeginContext(7135, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a3a6d93cfc3455a9132ad72526f3349", async() => {
                BeginContext(7210, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 159 "C:\Users\tyler.diaz\Desktop\PrimerParcial-desarrollo\Views\Ordens\ValidaFactura.cshtml"
                                                                    WriteLiteral(id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7215, 119, true);
            WriteLiteral("\r\n                </button>\r\n            </div>\r\n        </div>\r\n        <div class=\"clearfix\"></div>\r\n    </div>\r\n\r\n\r\n");
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
