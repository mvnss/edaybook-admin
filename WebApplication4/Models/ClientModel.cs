using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class ClientModel
    {       
            public string Title { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public string County { get; set; }
            public string Postcode { get; set; }
            public string Telephone { get; set; }
            public string Email { get; set; }
            //public string Information { get; set; }

            [DataType(DataType.MultilineText)]
            public string Keyinfo { get; set; }

            [DataType(DataType.MultilineText)]
            public string Recenthistory { get; set; }

            [DataType(DataType.MultilineText)]
            public string Socialhistory { get; set; }

            [DataType(DataType.MultilineText)]
            public string Healthhistory { get; set; }

         
            public string Riskassess { get; set; }

            [DataType(DataType.MultilineText)]
            public string Circlesupp { get; set; }

            // Image
            public string Containername { get; set; }
            public string Resourcename { get; set; }
            public string Sasquerystring { get; set; }
            public string Imageuri { get; set; }

            //public string DUMMY { get; set; }
       
    }
}