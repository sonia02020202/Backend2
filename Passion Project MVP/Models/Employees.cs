namespace Sonia_s_Pizza_Store.Models
{
    /// <summary>
    /// Represents an employee in Sonia's Pizza Store.
    /// </summary>
    public class Employee
    {
     //employees first and last name, position, date hired and salary
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string DateHired { get; set; }
        public decimal Salary { get; set; }
    }
}
