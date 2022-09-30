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

        
        public IActionResult Index(int id)
        {          
            return View(client.GetAppClient(id));
        }

        
        public IActionResult Search(string qwery)
        {           
            return View(client.GetSearchClient(qwery));
        }


        
        public IActionResult GetDeletClient(int id)
        {
            client.GetDeletClient(id);
            return Redirect("~/Home/");
        }


        
        public IActionResult AddClient()
        {
            return View();
        }
        
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




        
        public IActionResult ChangeClient(int id)
        {           
            return View(client.GetAppClient(id));
        }

             
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
