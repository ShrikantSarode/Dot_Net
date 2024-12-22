using System.Diagnostics;
using CfirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CfirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDbContext employeeDb;


        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}



        //constructor created of EmployeeDbContext
        public HomeController(EmployeeDbContext employeeDb)
        {
            this.employeeDb = employeeDb;
        }

        //show data from Database
        public async Task<IActionResult> Index()
        {
            //Employees is table name
            var empData = await employeeDb.Employes.ToListAsync();

            return View(empData);
        }
        public IActionResult Create()
        {
            return View();
        }

        //Create method to add Data
        [HttpPost]
        public async Task<IActionResult> Create(Employeee emp)
        {
            if (ModelState.IsValid)
            {

                await employeeDb.Employes.AddAsync(emp);
                await employeeDb.SaveChangesAsync();
                return RedirectToAction("Index", "Home");

            }
            return View(emp);
        }

        //edit method
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }

            var empData = await employeeDb.Employes.FindAsync(id);

            if (empData == null)
            {
                return NotFound();
            }

            return View(empData);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, Employeee editEmployee)
        {
            if (id != editEmployee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                employeeDb.Entry(editEmployee).State = EntityState.Modified;
                await employeeDb.SaveChangesAsync();

                //redirect to the details action
                return RedirectToAction("Index", "Home");

            }

            return View(editEmployee);
        }

        //details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || employeeDb.Employes == null)
            {
                return NotFound();
            }
            var empData = await employeeDb.Employes.FirstOrDefaultAsync(x => x.Id == id);

            if (empData == null)
            {
                NotFound();
            }
            return View(empData);
        }

        //delete

        //edit method
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }

            var empData = await employeeDb.Employes.FindAsync(id);

            if (empData == null)
            {
                return NotFound();
            }

            return View(empData);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, Employeee editEmployee)
        {
            if (id != editEmployee.Id)
            {
                return NotFound();
            }
 

                var empData = await employeeDb.Employes.FindAsync(id);

                if (empData == null)
                {
                    return NotFound();
                }

                employeeDb.Employes.Remove(empData);
                employeeDb.SaveChanges();

                //redirect to the details action
                return RedirectToAction("Index");
            
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
