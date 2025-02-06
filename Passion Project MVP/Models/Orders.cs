namespace Sonia_s_Pizza_Store.Models
{
    /// <summary>
    /// Represents an order in Sonia's Pizza Store.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets the unique identifier for the order.
        /// gets the name of customer, orderdate and information of each order
        /// </summary>
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
    }
}
