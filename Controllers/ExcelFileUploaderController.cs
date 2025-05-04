using ExcelFilesCompiler.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExcelFilesCompiler.Controllers
{
    public class ExcelFileUploaderController : Controller
    {
        

        public ExcelFileUploaderController()
        {
           
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}