using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Entity;
using WebApplication1.Models;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClient client;

        public HomeController(IClient Client)
        {
            this.client = Client;
        }

        [HttpGet]
        public IActionResult Index()
        {           
            return View(client.GetClient());
        }
        
    }
}