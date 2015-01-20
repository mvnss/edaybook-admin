using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using WebApplication4.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Configuration;
using System.Security.Claims;
using Azure.ActiveDirectory.AzureGraphService.Microsoft.WindowsAzure.ActiveDirectory;




namespace WebApplication4.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel Login)
        {

            return RedirectToAction("Index", "Login");
            //return RedirectToAction("Index", "Client");


            //string authority = "";
            //string resource = "";
            //string clientId = "";
            //string redirectUri = ""; 

            //AuthenticationContext authContext = new AuthenticationContext(string.Format("https://login.windows.net/{0}", authority));
            //AuthenticationResult result =authContext.AcquireToken(resource,clientId,new Uri(redirectUri),PromptBehavior.Auto); 
            
           // string metadataLocation = ConfigurationManager.AppSettings["ida:FederationMetadataLocation"];
           // Azure.ActiveDirectory.AzureTableIssuerNameRegistry.RefreshKeys(metadataLocation);


            //Azure.ActiveDirectory.AzureGraphService.Microsoft.WindowsAzure.ActiveDirectory.KeyCredential a = new Azure.ActiveDirectory.AzureGraphService.Microsoft.WindowsAzure.ActiveDirectory.KeyCredential();
            //Azure.ActiveDirectory.AzureGraphService.Microsoft.WindowsAzure.ActiveDirectory.PasswordCredential b = new Azure.ActiveDirectory.AzureGraphService.Microsoft.WindowsAzure.ActiveDirectory.PasswordCredential();
            //b.ToString();

            //Azure.ActiveDirectory.GraphClaimsAuthenticationManager abc = new Azure.ActiveDirectory.GraphClaimsAuthenticationManager();
            ////abc.Authenticate()

            //// Get Graph API credentials from web.config
            //var clientId = ConfigurationManager.AppSettings["ida:ClientID"];
            //var password = ConfigurationManager.AppSettings["ida:Password"];

            //// Get tenant from the current user.
            //var tenant = ClaimsPrincipal.Current.FindFirst("http://schemas.microsoft.com/identity/claims/tenantid").Value;


            //Azure.ActiveDirectory.AzureGraphService.Microsoft.WindowsAzure.ActiveDirectory.DirectoryDataService aa = 

            // Get Graph API credentials from web.config
            ////var clientId = ConfigurationManager.AppSettings["ida:ClientID"];
            ////var password = ConfigurationManager.AppSettings["ida:Password"];



            ////DirectoryDataService graphService = new DirectoryDataService(new Uri("https://graph.windows.net/"));
                


            // Get tenant from the current user.
            ////var tenant = ClaimsPrincipal.Current.FindFirst("http://schemas.microsoft.com/identity/claims/tenantid").Value;

            //AADJWTToken token = DirectoryDataServiceAuthorizationHelper.GetAuthorizationToken(tenant, clientId, password);

            // initialize a graphService instance using the token acquired from previous step

           // DirectoryDataService graphService = new DirectoryDataService(new Uri("https://graph.windows.net/" + token));
            
            

            
        }

       
    }
}