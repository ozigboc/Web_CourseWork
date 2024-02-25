using System.Collections.Generic;
namespace Web_CourseWork.Models
{
    public class Employees
    {
        public int? Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Position { get; set; }
        public Department? Department { get; set; }
        public Assignment? Task { get; set; }

        public List<Employee_Skills>? Employee_Skills { get; set; }

    }
}