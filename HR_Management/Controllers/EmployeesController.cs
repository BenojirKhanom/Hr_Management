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
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Employee Details save
                _Context.Employee_Ditailse.Add(model.EmployeeDetails);

                // Social Media save
                _Context.EmployeeSocialMedia.Add(model.EmployeeSocialMedia);

                _Context.SaveChanges();

                return RedirectToAction("Create");
            }

            return View(model);
        }
    }
}
