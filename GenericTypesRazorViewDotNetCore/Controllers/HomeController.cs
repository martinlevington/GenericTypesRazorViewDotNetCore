using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenericTypesRazorViewDotNetCore.Models;

namespace GenericTypesRazorViewDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var vm = new ItemsViewModel();


            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
