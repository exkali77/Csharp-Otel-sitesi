using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Otel_Sitesi.Class;
using System.Data.SqlClient;
using System.Data;

namespace Otel_Sitesi.Class
{

    public class Bas : System.Web.Mvc.Controller
    {
        public string username { get; set; }
        public string mesg { get; set; }
        public string local { get; set; }
        public string seller { get; set; }
        public string hname { get; set; }
        public string img { get; set; }

    }



}