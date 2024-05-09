using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Employee Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Employee position is required.")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Employee salary is required.")]
        [Range(1000, 100000, ErrorMessage ="Salary must be between 1000 and 100,000.")]
        public decimal Salary { get; set; }
    }
}
