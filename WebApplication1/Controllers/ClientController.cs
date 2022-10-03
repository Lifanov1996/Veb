using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Entity;
using WebApplication1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    
    public class ClientController : Controller
    {
        private readonly IClient client;
        
        
        public ClientController(IClient Client)
        {
            this.client = Client;
        }

        [HttpGet]
        public IActionResult Index(int id)
        {          
            return View(client.GetAppClient(id));
        }

        [HttpGet]
        public IActionResult Search(string qwery)
        {           
            return View(client.GetSearchClient(qwery));
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetDeletClient(int id)
        {
            client.GetDeletClient(id);
            return Redirect("~/Home/");
        }


        [HttpGet]
        public IActionResult AddClient()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetAddClient(string lastname, string firstname, string patronymic, string numberphone, string address, string description)
        {
            try
            {
                client.AddClient(lastname, firstname, patronymic, numberphone, address, description);
                return Redirect("~/");
            }
            catch (Exception)
            {
                return Redirect("~/");
            }

        }




        [Authorize]
        [HttpPost]
        public IActionResult ChangeClient(int id)
        {           
            return View(client.GetAppClient(id));
        }

        [HttpPost]   
        public IActionResult GetChangeClient(int id, string lastname, string firstname, string patronymic, string numberphone, string address, string description)
        {
            try
            {
                client.GetChangeClient(id, lastname, firstname, patronymic, numberphone, address, description);
                return Redirect("~/");
            }
            catch (Exception)
            {
                return Redirect("~/");
            }
        }
        
    }
}
