using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ICDE.CompareProducts.Models;
using HtmlAgilityPack;

namespace ICDE.CompareProducts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public List<List<string>> table;

        [HttpGet]
        public ActionResult Index()
        {
            //string url = urlInput.Text;
            HtmlWeb w = new HtmlWeb();
            var docu = w.Load("https://github.com/varunagarwal97/Predict-Employee-Attrition/blob/master/HR.csv");
            table = docu.DocumentNode.SelectSingleNode("//table[@class='js-csv-data csv-data js-file-line-container']")
                .Descendants("tr")
                .Where(tr => tr.Elements("td").Any() || tr.Elements("th").Any())
                .Select(tr => (tr.Elements("td").Any() ? tr.Elements("td") : tr.Elements("th")).Select(td => td.InnerText.Trim()).ToList())
                .ToList();
            return View(table);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
