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
    }
}
