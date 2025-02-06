using Microsoft.AspNetCore.Mvc;
using Sonia_s_Pizza_Store.Models;
using System.Collections.Generic;

namespace Sonia_s_Pizza_Store.Controllers
{
    /// <summary>
    /// Manages orders such as displaying orders.
    /// </summary>
    public class OrdersController : Controller
    {
        /// <summary>
        /// A list of orders.
        /// </summary>
        private static List<Order> orders = new List<Order>
        {
            new Order { Id = 1, CustomerName = "Calico Cat", OrderDate = "01/14/2025", TotalAmount = 79.35m, Status = "Delivered" }
        };

        /// <summary>
        /// Displays a list of orders.
        /// </summary>
        /// <returns>A view showing the order list.</returns>
        public IActionResult Index() => View(orders);
    }
}
