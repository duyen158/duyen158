using Microsoft.AspNetCore.Mvc;

namespace Duyen158.Controllers;
public class Person : Controller
{
public IActionResult Index()
    {
        return View();
    }

public IActionResult people()
    {
        return View();
    }

}
