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

        public async Task<JsonResult> GetGUSdata(string nip)
        {
            nip = Regex.Replace(nip, @"[^\d]", "");

            if (nip.Length != 10)
                return Json(new { result = false, text = "Nieprawidłowy format NIPu" });

            BIRModel bir = new BIRModel();

            var result = await bir.Search(nip);

            if (result == null)
                return Json(new { result = false, text = "Brak wyniku wyszukiwania" });
            if (_context.Entrepreneurs.Any(a => a.NIP == nip))
                return Json(new { result = true, data = result, text = "Przedsiembiorca istnieje już w bazie." });
            return Json(new { result = true, data = result });
        }

        public async Task<JsonResult> SaveData(string d)
        {
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<BIRModel.BIRDane>(d);
            var entr = new Entrepreneur 
            { 
                Name = data.Nazwa,
                NIP = data.NIP,
                City = data.Miejscowosc,
                Street = data.Ulica,
                Code = data.KodPocztowy,
                Country = ""
            };
            _context.Add(entr);
            try
            {
               await _context.SaveChangesAsync();
            } 
            catch (Exception ex)
            {
                return Json(new { result = false, text = "Błąd zapisu do bazy danych" });
            }
            return Json(new { result = true, text = "Zapisano" });
        }

        public IActionResult Zadanie2()
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