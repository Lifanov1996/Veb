using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index(string qwery)
        {
            ViewBag.Client = new ClientOptional().GetClientSearch(qwery);
            return View();
        }
    }
}
