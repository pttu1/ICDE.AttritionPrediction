using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ICDE.CompareProducts.Controllers
{
    public class DefaultController : Controller
    {
        // GET: /Default/
        public IActionResult Index()
        {
            return View();
        }

        //GET: Welcome
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            return View();
        }
    }
}
