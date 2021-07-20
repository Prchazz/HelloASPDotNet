using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNet.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        
        public IActionResult Index()
        {
            string html = "<form method = 'post' action='/helloworld/'>" +
                "<input type= 'text' name='name' /> " +
                "<input type= 'submit' value= 'Greet Me!' />" +
                "</form>";
            return Content(html, "text/html");
        }

        //GET /hello/welcome
        [HttpGet("welcome/{name?}")]
        //[Route("/helloworld/welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string name = "Variant")
        {
            return Content("<h1> Welcome to my app, " + name + "!</h1>", "text/html");
        }

        public IActionResult CreateMessage(string name, string language)
        {
            string openingFormTag = "<form method = 'post' action='/helloworld/option'>";
            string closingFormTag = "</form>";
            string nameInputTag = "<input type='text' name='name'/>";
            string openingSelectTag = "<select name='languages' id='language-select'>";
            string openingOptionTag = "<option value='' value = '--Please choose a language--'</option>" +
                                      "<option value ='en' value = 'Hello'>English</option>" +
                                      "<option value ='de' value = 'Hallo'>German</option>" +
                                      "<option value ='fr' value = 'Bonjour'>French</option>" +
                                      "<option value ='it' value = 'Ciao'>Italian</option>" +
                                      "<option value ='es' value = 'Hola'>Spanish</option>";
            string closingOptionTag = "</option>";
            string closingSelectTag = "</select>";
            string submitInputTag = "<input type='submit' value='Greet Me!' />;";
            string html = openingFormTag + closingFormTag+ nameInputTag + openingSelectTag+ openingOptionTag + closingOptionTag +closingSelectTag +submitInputTag;
            return Content(html, "text/html");

            //string html = "<form method = 'post' action='/helloworld/'>" +
            //    "<input type= 'text' name='name' /> " +
            //    "<input type= 'submit' value= 'Greet Me!' />" +
            //    "<label for="language">Choose a language:</label>" +
            //    "<select language="language" id="lang - select">" +
            //      "<option value = "" > --Please choose an option--</option>" +
            //      "<option value = "Hello" > english </ option >"
            //    "<option value = "Hola" > spanish </ option >" +
            //    "<option value="Bonjour"> french</option>" +
            //    "<option value = "Ciao" > italian </ option >" +
            //    "< option value="Ola"> portuguese</option>" +
            //    "</select>"
            //    "</form>";
        }
    }
}
