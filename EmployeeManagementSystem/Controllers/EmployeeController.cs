using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
           _employeeRepository = employeeRepository;
        }

        #region List of Employees
        // This method get list of employees from repository (database) based on Id.

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = await _employeeRepository.GetAllEmployees();
            return View(employees);
        }

        #endregion

        #region Employee Details
        // This method get employee from repository (database) based on Id.
        public async Task<IActionResult> EmployeeDetails(int id)
        {
            var employee = await _employeeRepository.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        #endregion

        #region Create Employee
        // The create method code handle server-side of creating a new employee,
        // attempts to save it to db and provide feedback to the user based on the outcome
        [HttpGet]
        public IActionResult CreateEmployee()
        {
          return View(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEmployee(Employee employee)
        {
            try
            {
                await _employeeRepository.AddEmployee(employee);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Unable to save changes. Please try again..");
                return View(employee);
            }
        }

        #endregion

        #region Update Employee
        // The Update Employee method handle the process of retrieving and employee for editing
        // and the updating the employee data in db.
        [HttpGet]
        public async Task<IActionResult> UpdateEmployee(int id)
        {
            var employee = await _employeeRepository.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateEmployee(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }
            try
            {
                await _employeeRepository.UpdateEmployee(employee);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Unable to update changes. Please try again..");

                return View(employee);
            }
        }

        #endregion

        #region Delete Employee
        // This method remove employee based on Id.
        [HttpGet]
        public async Task<IActionResult> DeleteEmployee(int id) 
        {
            var employee = await _employeeRepository.GetEmployeeById(id);
            if (employee == null) 
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost, ActionName("DeleteEmployee")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _employeeRepository.DeleteEmployee(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Unable to delete changes. Please try again..");
                return RedirectToAction(nameof(DeleteEmployee), new { id = id, saveChangesError = true});
            }
        }

        #endregion

    }
}
