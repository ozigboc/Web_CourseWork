using System.Collections.Generic;
namespace Web_CourseWork.Models
{
    public class Assignment
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? Deadline { get; set; }
        public string? Description { get; set; }
        public Project? Project { get; set; }

    }
}