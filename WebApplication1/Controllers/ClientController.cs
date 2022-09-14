using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Entity;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClientController : Controller
    {
        
        public IActionResult Index(int id)
        {
            ViewBag.Client = new ClientOptional().GetClientsAllId(id);
            return View();
 
        }

        public IActionResult Search(string qwery)
        {
            ViewBag.Client = new ClientOptional().GetClientSearch(qwery);
            return View();
        }

        public IActionResult AddClient()
        {
            return View();
        }

        public IActionResult GetAddClient(string lastname, string firstname, string patronymic, string numberphone, string address, string description)
        {
           new ClientOptional().GetAddClient(lastname, firstname, patronymic, numberphone, address, description);
           return Redirect("~/");
        }

        public IActionResult GetDeletClient(int id)
        {
            new ClientOptional().GetDeletClient(id);
            return Redirect("~/");
        }
    }
}
