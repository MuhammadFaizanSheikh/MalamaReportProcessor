using MalamaReportProcessor.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ExcelFilesCompiler.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IOptions<FeatureToggles> _featureToggles;

        public DashboardController(IOptions<FeatureToggles> featureToggles)
        {
            _featureToggles = featureToggles;
        }

        public IActionResult Index()
        {
            ViewBag.ShowExcelUploader = _featureToggles.Value.ExcelUploader;
            return View();
        }
    }
}
