using Microsoft.AspNetCore.Mvc;

namespace ContosoUni.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
