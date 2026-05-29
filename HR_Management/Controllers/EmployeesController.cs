using HR_Management.Data;
using HR_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            EmployeeViewModel vm = new EmployeeViewModel();

            vm.EmployeesList = _Context.EmployeeDitailse
                .Select(x => new EmployeeViewModel
                {
                    EmployeeDetails = new EmployeeDitailse
                    {
                        Department = x.Department,
                        JoinDesignation = x.JoinDesignation
                    }
                }).ToList();

            return View(vm);
        }
        [HttpPost]
        public IActionResult Index(EmployeeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var details = new EmployeeDitailse
                {
                    JoiningDate = model.EmployeeDetails.JoiningDate,
                    Department = model.EmployeeDetails.Department,
                    JoinDesignation = model.EmployeeDetails.JoinDesignation,

                };

                var social = new EmployeeSocialMedia
                {
                    GitHubProfileURL = model.EmployeeSocialMedia.GitHubProfileURL,
                };

                _Context.EmployeeDitailse.Add(details);
                _Context.EmployeeSocialMedia.Add(social);
                _Context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}

