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
        [HttpPost]
        public IActionResult Create(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var details = new EmployeeDitailse
                {
                    JoiningDate = model.EmployeeDetails.JoiningDate,
                    ActivityStatus = model.EmployeeDetails.ActivityStatus,
                    Department = model.EmployeeDetails.Department,
                    JoinDesignation = model.EmployeeDetails.JoinDesignation,
                    EmployeeStatus = model.EmployeeDetails.EmployeeStatus,
                    BranchName = model.EmployeeDetails.BranchName
                };

                var social = new EmployeeSocialMedia
                {
                    LinkedInProfileURL = model.EmployeeSocialMedia.LinkedInProfileURL,
                    FacebookProfileURL = model.EmployeeSocialMedia.FacebookProfileURL,
                    TwitterHandleURL = model.EmployeeSocialMedia.TwitterHandleURL,
                    InstagramHandleURL = model.EmployeeSocialMedia.InstagramHandleURL,
                    GitHubProfileURL = model.EmployeeSocialMedia.GitHubProfileURL,
                    PortfolioURL = model.EmployeeSocialMedia.PortfolioURL
                };

                _Context.EmployeeDitailse.Add(details);

                _Context.EmployeeSocialMedia.Add(social);

                _Context.SaveChanges();

                return RedirectToAction("Create");
            }

            return View(model);
        }


    }
    }

