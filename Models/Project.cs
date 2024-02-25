using System.Collections.Generic;
namespace Web_CourseWork.Models
{
    public class Project
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Duration { get; set; }
        public Department? Department { get; set; }


    }
}