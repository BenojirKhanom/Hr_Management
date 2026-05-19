using Microsoft.AspNetCore.Mvc;

namespace HR_Management.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
