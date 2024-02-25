using System.Collections.Generic;
namespace Web_CourseWork.Models
{
    public class Skill
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public string? Category { get; set; }
        public string? Description { get; set; }

        public List<Employee_Skills>? Employee_Skills { get; set; }
    }
}