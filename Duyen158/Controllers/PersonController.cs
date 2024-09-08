using Duyen158.Models;
using Microsoft.AspNetCore.Mvc;

namespace Duyen158.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
            }

    [HttpPost]
    public IActionResult Index(Person ps)
    {   
        string strOutput = "Xin chào " + ps.PersonId + " - " + ps.FullName + " - " + ps.Address;
        Viewbag.infoPerson = strOutput;
     return View();
    }
}
}
    