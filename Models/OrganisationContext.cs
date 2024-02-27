using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Web_CourseWork.Models
{
    public class OrganisationContext : IdentityDbContext<IdentityUser>
    {
        public OrganisationContext(DbContextOptions<OrganisationContext> options)
        : base(options)
        { }


        public DbSet<Department> Department { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Employee_Skills> Employee_Skills { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Assignment> Assignment { get; set; }
    }

}