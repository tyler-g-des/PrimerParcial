#pragma checksum "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "639f64a94b220dafb4d254c438d1be6999e31ef0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_formaEnvioView_formaEnvioView), @"mvc.1.0.view", @"/Views/formaEnvioView/formaEnvioView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/formaEnvioView/formaEnvioView.cshtml", typeof(AspNetCore.Views_formaEnvioView_formaEnvioView))]
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
#line 1 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\_ViewImports.cshtml"
using PrimerParcial;

#line default
#line hidden
#line 2 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\_ViewImports.cshtml"
using PrimerParcial.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639f64a94b220dafb4d254c438d1be6999e31ef0", @"/Views/formaEnvioView/formaEnvioView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a49c96d267825d6e4e5875e2249f7b27f117d1de", @"/Views/_ViewImports.cshtml")]
    public class Views_formaEnvioView_formaEnvioView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrimerParcial.ViewModels.formaEnvioView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"
  
    ViewData["Title"] = "Nueva Orden de Compra";

#line default
#line hidden
            BeginContext(105, 19, true);
            WriteLiteral("\r\n<h2>View</h2>\r\n\r\n");
            EndContext();
            BeginContext(196, 541, true);
            WriteLiteral(@"<div class=""modal fade"" id=""adicionarArticulo"" tabindex=""-1"" role=""dialog"" aria-labelledby=""gridSystemModalLabel"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <h4 class=""modal-title"" id=""gridSystemModalLabel"">Adicionar Artículo</h4>
            </div>
            <div class=""modal-body"">
");
            EndContext();
            BeginContext(963, 174, true);
            WriteLiteral("             \r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-danger\" data-dismiss=\"modal\">Cerrar</button>\r\n");
            EndContext();
            BeginContext(1226, 119, true);
            WriteLiteral("            </div>\r\n        </div><!-- /.modal-content -->\r\n    </div><!-- /.modal-dialog -->\r\n</div><!-- /.modal -->\r\n");
            EndContext();
            BeginContext(1425, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 34 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"
 using (Html.BeginForm("View", "PurchaseOrders", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(1507, 23, false);
#line 36 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1534, 304, true);
            WriteLiteral(@"    <div class=""box box-default"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Seleccione</h3>
            <div class=""box-tools pull-right"">
                <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse""><i class=""fa fa-minus""></i></button>
");
            EndContext();
            BeginContext(1965, 159, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"box-body\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    ");
            EndContext();
            BeginContext(2125, 64, false);
#line 49 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2189, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(2614, 94, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"box-footer\">\r\n");
            EndContext();
            BeginContext(2863, 28, true);
            WriteLiteral("        </div>\r\n    </div>\r\n");
            EndContext();
#line 66 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"

    //Boton de Adicionar Articulo y Guardar la Orden

#line default
#line hidden
            BeginContext(2947, 30, true);
            WriteLiteral("    <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(3149, 280, true);
            WriteLiteral(@"
        <!-- modal -->
        <button type=""button"" class=""btn btn-success btn-large"" data-toggle=""modal"" data-target=""#adicionarArticulo"">Adicionar Artículo</button>

        <input type=""submit"" value=""Guardar Orden"" id=""SavePurchaseOrder"" class=""btn btn-instagram"" />

");
            EndContext();
            BeginContext(3449, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 79 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"
}

#line default
#line hidden
            BeginContext(3464, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3510, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3547, 366, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-xs-12"">
        <div class=""box box-primary"">
            <div class=""box-header"">
                <h3 class=""box-title"">Detalle de la Orden de compra</h3>
            </div>
            <div class=""box-body"">
                <table id=""example1"" class=""table table-bordered table-striped"">
                    <thead>
");
            EndContext();
            BeginContext(3995, 98, true);
            WriteLiteral("\r\n                        <tr>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(4094, 65, false);
#line 97 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"
                           Write(Html.DisplayNameFor(model => model.formaPagoArticulo.ArticleCost));

#line default
#line hidden
            EndContext();
            BeginContext(4159, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(4263, 82, false);
#line 100 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"
                           Write(Html.DisplayNameFor(model => model.formaPagoArticulo.ArticlePurchaseOrderQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(4345, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(4449, 59, false);
#line 103 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"
                           Write(Html.DisplayNameFor(model => model.formaPagoArticulo.Value));

#line default
#line hidden
            EndContext();
            BeginContext(4508, 139, true);
            WriteLiteral("\r\n                            </th>\r\n\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n");
            EndContext();
#line 109 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"
                     for (int i = 0; i < Model.formaPagoArticulos.Count; i++)
                    {

#line default
#line hidden
            BeginContext(4749, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4846, 69, false);
#line 113 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"
                           Write(Html.DisplayFor(modelItem => Model.formaPagoArticulos[i].ArticleCost));

#line default
#line hidden
            EndContext();
            BeginContext(4915, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5019, 86, false);
#line 116 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"
                           Write(Html.DisplayFor(modelItem => Model.formaPagoArticulos[i].ArticlePurchaseOrderQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(5105, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5209, 63, false);
#line 119 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"
                           Write(Html.DisplayFor(modelItem => Model.formaPagoArticulos[i].Value));

#line default
#line hidden
            EndContext();
            BeginContext(5272, 71, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            EndContext();
            BeginContext(5494, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(5527, 155, false);
#line 123 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"
                           Write(Html.ActionLink("Eliminar", "EliminarArticulo", "NewPurchaseOrder", new { id = Model.formaPagoArticulos[i].idArticulo }, new { @Class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5682, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 126 "C:\Users\tyler.diaz\Documents\PrimerParcial-desarrollo\Views\formaEnvioView\formaEnvioView.cshtml"
                    }

#line default
#line hidden
            BeginContext(5773, 28, true);
            WriteLiteral("\r\n                </table>\r\n");
            EndContext();
            BeginContext(5861, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrimerParcial.ViewModels.formaEnvioView> Html { get; private set; }
    }
}
#pragma warning restore 1591