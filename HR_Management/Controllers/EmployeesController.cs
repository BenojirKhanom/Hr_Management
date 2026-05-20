using HR_Management.Data;
using HR_Management.Models;
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
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee_Ditailse employee_Ditailse)
        {
            if (ModelState.IsValid)
            {
                _Context.Employees.Add(employee_Ditailse);

                _Context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(employee_Ditailse);
        }
    }
}
