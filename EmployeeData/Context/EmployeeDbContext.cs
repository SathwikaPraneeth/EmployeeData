using EmployeeData.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeData.Context
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext()
        { }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
