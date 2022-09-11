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
            PersonModel model = new PersonModel();
            Persone persone = new Persone();
            model.PersonCollectoin = persone.GetClientSearch(qwery);

            return View(model);
        }
    }
}
