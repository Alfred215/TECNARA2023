using Microsoft.AspNetCore.Mvc;
using Mvc.Models;
using System.Diagnostics;
using static Azure.Core.HttpHeader;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext db;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            using(AppDbContext _db = new AppDbContext())
            {
                db = _db;
            }
        }

        public PartialViewResult GetListPersonas(string HtmlAttributes)
        {
            List<Person> model = db.Persons.ToList();
            ViewBag.HtmlAttributes = HtmlAttributes;
            return PartialView("~/ Views / Home / listPerson.cshtml", model);
        }

        public IActionResult Index()
        {
            return View();
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