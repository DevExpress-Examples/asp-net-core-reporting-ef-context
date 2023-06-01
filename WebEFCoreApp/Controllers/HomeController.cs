using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.XtraReports.Web.WebDocumentViewer;


namespace WebEFCoreApp.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
        public IActionResult Error() {
            Models.ErrorModel model = new Models.ErrorModel();
            return View(model);
        }
        public IActionResult Viewer(
            [FromServices] IWebDocumentViewerClientSideModelGenerator clientSideModelGenerator,
            [FromQuery] string reportName) {

            var reportToOpen = string.IsNullOrEmpty(reportName) ? "TestReport" : reportName;
            var model = new Models.ViewerModel {
                ViewerModelToBind = clientSideModelGenerator.GetModel(reportToOpen, WebDocumentViewerController.DefaultUri)
            };
            return View(model);
        }
    }
}
