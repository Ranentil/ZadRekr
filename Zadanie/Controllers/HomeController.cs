using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Zadanie.Models;

namespace Zadanie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ZadanieContext _context;

        public HomeController(ILogger<HomeController> logger, 
            ZadanieContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Zadanie1()
        {
            return View();
        }

        public IActionResult Zadanie2()
        {
            return View();
        }

        public JsonResult GetGUSdata(string nip)
        {
            nip = Regex.Replace(nip, @"[^\d]", "");

            if (nip.Length < 10)
                return Json(new { result = false, text = "Nieprawidłowy format NIPu" });
            if (_context.Entrepreneurs.Any(a => a.NIP == nip))
                return Json(new { result = false, text = "Przedsiembiorca istnieje już w bazie." } );

            BIRModel bir = new BIRModel();

            var result = bir.Search(nip);

            if (result == null)
                return Json(new { result = false, text = "Brak wyniku wyszukiwania" });
            return Json(new { result = true, data = result });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}