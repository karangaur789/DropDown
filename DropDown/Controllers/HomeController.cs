using DropDown.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace DropDown.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          //Here i crete list because . We have not Database;
           List<string> Department=new List<string>();
            Department.Add("It");
            Department.Add("Medical");
            Department.Add("Civil");
            Department.Add("Electric");


            // Variable for dropdown
            List<SelectListItem> drop = new List<SelectListItem>();

            // First Item on drop down
            drop.Add(new SelectListItem
            {
                Text = "Select Department",
                Value = ""
            });
            int i = 1;
            foreach (var item in Department)
            {
                drop.Add(new SelectListItem
                {
                    Text = item,
                    Value = $"{i}"
                });
                i++;
            }
           //viewbeg that use in view
            ViewBag.cities = drop;
            return View();
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