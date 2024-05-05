using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Models
{
    public class Employee
    {
        [Key]
        public int EId { get; set; }
        public string? EName { get; set; }
        public int? ESalary { get; set; }
        public int DepartmentId { get; set; }

        // Navigation property
        public Department Department { get; set; }
    }
}
