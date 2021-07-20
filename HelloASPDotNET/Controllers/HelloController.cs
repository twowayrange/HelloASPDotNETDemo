using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld'>" +
                "<input type='text' name='name' />" +
                "<select name='language' />"+
                "<option value='english'>English</option>"+
                "<option value='french'>French</option>" +
                "<option value='spanish'>Spanish</option>" +
                "<option value='german'>German</option>" +
                "<option value='japanese'>Japanese</option>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        // GET: /<controller>/welcome?name=value or GET: /<controller>/welcome/name
        // POST: /<controller>/welcome
        [HttpGet("welcome/{name?}")]
        [HttpPost] 

        public IActionResult Welcome(string name = "World", string language = "English")
        {
            if (language == "english")
            {
                return Content("<h1>Hello, welcome to my app, " + name + "! You are speaking " + language + "</h1>", "text / html");
            }
            else if (language == "spanish")
            {
                return Content("<h1>Hola, welcome to my app, " + name + "! You are speaking " + language + "</h1>", "text/html");
            }
            else if (language == "french")
            {
                return Content("<h1>Bonjour, welcome to my app, " + name + "! You are speaking " + language + " </ h1 > ", "text /html");
            }
            else if (language == "german")
            {
                return Content("<h1>Gutentag, welcome tag to my app, " + name + "! You are speaking " + language + " </ h1 > ", "text/html");
            }
            else if (language == "japanese")
            {
                return Content("<h1>Konichiwa, welcome to my app, " + name + "! You are speaking " + language + " </ h1 > ", "text/html");
            }
            else
            {
                return Content("<h1>Hello, welcome to my app, " + name + "! You speak are speaking " + language + " </ h1 > ", "text/html");
            }
        }
    }
}
