using System.Collections.Generic;
namespace Web_CourseWork.Models
{
    public class Employee_Skills
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public Employees? Employees { get; set; }
        public Skill? Skill { get; set; }
    }
}