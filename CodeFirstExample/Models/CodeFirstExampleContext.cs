using Microsoft.EntityFrameworkCore;

namespace CodeFirstExample.Models
{
    public class CodeFirstExampleContext:DbContext
    {
        public CodeFirstExampleContext()
        {
        }

        public CodeFirstExampleContext(DbContextOptions<CodeFirstExampleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}
