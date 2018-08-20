using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Payroll.Controllers
{
    public class TestController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public string Hello()
        {
            return "Hola";
        }

        public string Welcome(string name, int id = 0)
        {
            //Use HtmlEncoder.Default.Encode to protect the app from malicious input(namely JavaScript).
            return HtmlEncoder.Default.Encode($"Name: {name}, Unique identifier: {id}");
        }
    }
}