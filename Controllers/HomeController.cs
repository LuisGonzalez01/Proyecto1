using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "<html><body>" +
                "<h1>Universidad Autonoma de Santo Domingo(UASD)</h1>" +
                "<P>Diplomado Desarrolo Web C#, MVC </P>" +
                "<body></html>";
        }
        public string Diplomado() 
        {
            return "<html><body>" +
                "<h1>Estudiantes:</h1>" +
                "<p>Yorqui Montero Sanchez<br>" +
                "Junior Maria Araujo<br>" +
                "</body><html>";
        }
    }
}