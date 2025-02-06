using Microsoft.AspNetCore.Mvc;
using Sonia_s_Pizza_Store.Models;
using System.Collections.Generic;

namespace Sonia_s_Pizza_Store.Controllers
{
    /// <summary>
    /// Manages such as viewing employee records.
    /// </summary>
    public class EmployeesController : Controller
    {
        /// <summary>
        /// A list of employees in database.
        /// </summary>
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Sonia", LastName = "Serrano", Position = "Manager", DateHired = "04/04/2024", Salary = 70000 }
        };

        /// <summary>
        /// Displays a list of employees.
        /// </summary>
        /// <returns>A view showing the employee list.</returns>
        public IActionResult Index() => View(employees);
    }
}
