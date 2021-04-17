using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        /* public string Index()
         {
             return "This is my default action...";
         }*/

        public IActionResult Index()
        {
            return View();
        } 

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes=1)
        {
            //return "This is the Welcome action method..." ()
            //return HtmlEncoder.Default.Encode($"Hello Rick, NumTimes is: 4"); //(string name, int numTimes=1)
            //return HtmlEncoder.Default.Encode($"Hello Rick, ID: ");
            ViewData["Message"] = "Hello" + name;
            ViewData["numTimes"] = numTimes;
            return View();
        
        }
    }
}