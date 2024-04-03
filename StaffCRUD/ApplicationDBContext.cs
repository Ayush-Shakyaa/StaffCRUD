using Microsoft.EntityFrameworkCore;

namespace StaffCRUD
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<Staff> Staffs { get; set; }
    }
}
