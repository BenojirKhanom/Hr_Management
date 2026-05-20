using HR_Management.Data;
using Microsoft.AspNetCore.Mvc;

namespace HR_Management.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _Context;
        public EmployeesController(AppDbContext Context)
        {
            _Context = Context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
