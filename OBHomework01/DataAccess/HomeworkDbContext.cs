using Microsoft.EntityFrameworkCore;
using OBHomework01.Model.DataModel;

namespace OBHomework01.DataAccess
{
    public class HomeworkDbContext : DbContext
    {
        public HomeworkDbContext(DbContextOptions<HomeworkDbContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}
