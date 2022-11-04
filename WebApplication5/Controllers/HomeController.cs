using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication5.Models;
using WebApplication5.ViewModels;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(RoleManager<IdentityRole> roleManager, ILogger<HomeController> logger)
        {
            _roleManager = roleManager;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            bool x = await _roleManager.RoleExistsAsync("Admin");
            if (!x)
            {
                // first we create Admin role    
                var role = new IdentityRole();
                role.Name = "Admin";
                await _roleManager.CreateAsync(role);

            }
            // creating Creating Teacher role     
            x = await _roleManager.RoleExistsAsync("Teacher");
            if (!x)
            {
                var role = new IdentityRole();
                role.Name = "Teacher";
                await _roleManager.CreateAsync(role);
            }

            // creating Creating School Manager role     
            x = await _roleManager.RoleExistsAsync("Manager");
            if (!x)
            {
                var role = new IdentityRole();
                role.Name = "Manager";
                await _roleManager.CreateAsync(role);
            }
            // creating Creating School Agent role     
            x = await _roleManager.RoleExistsAsync("Agent");
            if (!x)
            {
                var role = new IdentityRole();
                role.Name = "Agent";
                await _roleManager.CreateAsync(role);
            }
            // creating Creating The student's parent role     
            x = await _roleManager.RoleExistsAsync("parent");
            if (!x)
            {
                var role = new IdentityRole();
                role.Name = "parent";
                await _roleManager.CreateAsync(role);
            }
            // creating Creating Student role     
            x = await _roleManager.RoleExistsAsync("Student");
            if (!x)
            {
                var role = new IdentityRole();
                role.Name = "Student";
                await _roleManager.CreateAsync(role);
            }
            // creating Creating Procurement Officer role     
            x = await _roleManager.RoleExistsAsync("ProcurementOfficer");
            if (!x)
            {
                var role = new IdentityRole();
                role.Name = "ProcurementOfficerisor";
                await _roleManager.CreateAsync(role);
            }
            // creating Creating supervisor  role     
            x = await _roleManager.RoleExistsAsync("supervisor");
            if (!x)
            {
                var role = new IdentityRole();
                role.Name = "supervisor";
                await _roleManager.CreateAsync(role);
            }
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}