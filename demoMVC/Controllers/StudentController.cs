
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace demoMVC.Controllers

{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
public IActionResult Index(Student std)
{
    string strOutput = "Xin chào " + std.StudentId + " - " + std.FullName;
    ViewBag.thongbao = strOutput;
    return View();
}

    
}
}