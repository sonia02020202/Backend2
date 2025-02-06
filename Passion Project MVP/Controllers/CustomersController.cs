using Microsoft.AspNetCore.Mvc;
using Sonia_s_Pizza_Store.Models;
using Sonia_s_Pizza_Store.Models.Sonia_s_Pizza_Store.Models;
using System.Collections.Generic;

namespace Sonia_s_Pizza_Store.Controllers
{
    /// <summary>
    /// Manages customer-related things such as Create, Read, Update, and Delete.
    /// </summary>
    public class CustomersController : Controller
    {
        /// <summary>
        /// A
        /// list of customers  database.
        /// </summary>
        private static List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, FirstName = "Calico", LastName = "Cat", Phone = "000-000-0000", Email = "cat@email.ca", Address = "123 St" }
        };

        /// <summary>
        /// Displays a list of customers.
        /// </summary>
        /// <returns>A view showing the customer list.</returns>
        public IActionResult Index() => View(customers);

        /// <summary>
        /// Displays the form to create a new customer.
        /// </summary>
        /// <returns>The customer creation view.</returns>
        public IActionResult Create() => View();

        /// <summary>
        /// Processes the customer creation form submission.
        /// </summary>
        /// The new customer
        /// <returns>Redirects to the Index view if successful.</returns>
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            customers.Add(customer);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Displays the form to edit an existing customer.
        /// </summary>
        /// <param name="id">The ID of the customer to edit.</param>
        /// <returns>The edit view if customer exists or NotFound.</returns>
        public IActionResult Edit(int id)
        {
            var customer = customers.Find(c => c.Id == id);
            return customer == null ? NotFound() : View(customer);
        }

        /// <summary>
        /// Processes the customer edit form submission.
        /// </summary>
        
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            var existing = customers.Find(c => c.Id == customer.Id);
            if (existing == null) return NotFound();

            existing.FirstName = customer.FirstName;
            existing.LastName = customer.LastName;
            existing.Phone = customer.Phone;
            existing.Email = customer.Email;
            existing.Address = customer.Address;

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Deletes a customer by ID.
        /// </summary>
        /// The ID of the customer to delete.
        /// <returns>Redirects to the Index view after deletion.</returns>
        public IActionResult Delete(int id)
        {
            var customer = customers.Find(c => c.Id == id);
            if (customer != null) customers.Remove(customer);
            return RedirectToAction("Index");
        }
    }
}
