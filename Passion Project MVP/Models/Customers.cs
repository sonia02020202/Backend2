namespace Sonia_s_Pizza_Store.Models
{
    /// <summary>
    /// Represents a customer in Sonia's Pizza Store.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets the unique identifier for the customer.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets the first name of the customer.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///  last name of the customer.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets phone number of the customer.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// The email address of the customer.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The address of the customer.
        /// </summary>
        public string Address { get; set; }
    }
}
