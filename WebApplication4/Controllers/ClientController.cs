using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            var list = GetClients().ToList();
            
            return View(list);


        }

        public ActionResult AddClient()
        {
            return View();
        }

         [HttpPost]
        public ActionResult AddClient(ClientModel ClientDetails)
        {
   
            return RedirectToAction("EditClient", "Client");
        }

         [AllowAnonymous]
         public ActionResult EditClient()
         {
             var list = GetSingleClients();

             return View(list);
         }

        public List<ClientModel> GetClients()
        {
            var clientsList = new List<ClientModel>();
            clientsList.Add(new ClientModel { Title = "", Firstname = "Mrs Marigold Arnold", Lastname = "", Address1 = "", Address2 = "", City = "", County = "", Postcode = "", Telephone = "", Email = "", Keyinfo = "", Recenthistory = "", Socialhistory = "", Healthhistory = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididun", Riskassess = "", Circlesupp = "", Containername = "", Resourcename = "", Sasquerystring = "", Imageuri = "" });
            clientsList.Add(new ClientModel { Title = "", Firstname = "Mr Matt Campbell", Lastname = "", Address1 = "", Address2 = "", City = "", County = "", Postcode = "", Telephone = "", Email = "", Keyinfo = "", Recenthistory = "", Socialhistory = "", Healthhistory = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididun", Riskassess = "", Circlesupp = "", Containername = "", Resourcename = "", Sasquerystring = "", Imageuri = "" });
            clientsList.Add(new ClientModel { Title = "", Firstname = "Ms Deirdre Droke", Lastname = "", Address1 = "", Address2 = "", City = "", County = "", Postcode = "", Telephone = "", Email = "", Keyinfo = "", Recenthistory = "", Socialhistory = "", Healthhistory = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididun", Riskassess = "", Circlesupp = "", Containername = "", Resourcename = "", Sasquerystring = "", Imageuri = "" });
            clientsList.Add(new ClientModel { Title = "", Firstname = "Mr Erick Giles", Lastname = "", Address1 = "", Address2 = "", City = "", County = "", Postcode = "", Telephone = "", Email = "", Keyinfo = "", Recenthistory = "", Socialhistory = "", Healthhistory = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididun", Riskassess = "", Circlesupp = "", Containername = "", Resourcename = "", Sasquerystring = "", Imageuri = "" });
            clientsList.Add(new ClientModel { Title = "", Firstname = "Mr Leighton Hill", Lastname = "", Address1 = "", Address2 = "", City = "", County = "", Postcode = "", Telephone = "", Email = "", Keyinfo = "", Recenthistory = "", Socialhistory = "", Healthhistory = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididun", Riskassess = "", Circlesupp = "", Containername = "", Resourcename = "", Sasquerystring = "", Imageuri = "" });
            return clientsList;
        }
        public ClientModel GetSingleClients()
        {
            var clientsList = new ClientModel { Title = "", Firstname = "Mrs Marigold Arnold", Lastname = "", Address1 = "24 Giles Street", Address2 = "Greenton NewShire", City = "", County = "", Postcode = "NS13 5FT", Telephone = "01347 773459", Email = "", Keyinfo = "", Recenthistory = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididun", Socialhistory = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididun", Healthhistory = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididun", Riskassess = "", Circlesupp = "\r\nTerry Knightly - Family - 0135 248 255a\r\nPerin Huges - Family - 0210 445886", Containername = "", Resourcename = "", Sasquerystring = "", Imageuri = "" };
            return clientsList;
        }
    }
}