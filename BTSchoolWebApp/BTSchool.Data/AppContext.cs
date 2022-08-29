using Microsoft.EntityFrameworkCore;

using BTSchool.Core.Entities;
using BTSchool.Data.Configurations;

namespace BTSchool.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        { }

        public virtual DbSet<Accountants> Accountants { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Lessons> Lessons { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ServicesOfCourses> ServicesOfCourses { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<StudentsOfGroups> StudentsOfGroups { get; set; }
        public virtual DbSet<Themes> Themes { get; set; }
        public virtual DbSet<Trainers> Trainers { get; set; }
        public virtual DbSet<TrainersOfCourses> TrainersOfCourses { get; set; }
        public virtual DbSet<TrainersOfGroups> TrainersOfGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountantEntityConfiguration())
                .ApplyConfiguration(new AccountEntityConfiguration())
                .ApplyConfiguration(new CourseEntityConfiguration())
                .ApplyConfiguration(new CustomerEntityConfiguration())
                .ApplyConfiguration(new GroupEntityConfiguration())
                .ApplyConfiguration(new LessonEntityConfiguration())
                .ApplyConfiguration(new ProductEntityConfiguration())
                .ApplyConfiguration(new SaleEntityConfiguration())
                .ApplyConfiguration(new ServiceEntityConfiguration())
                .ApplyConfiguration(new ServicesOfCoursesEntityConfiguration())
                .ApplyConfiguration(new StudentEntityConfiguration())
                .ApplyConfiguration(new StudentsOfGroupsEntityConfiguration())
                .ApplyConfiguration(new ThemeEntityConfiguration())
                .ApplyConfiguration(new TrainerEntityConfiguration())
                .ApplyConfiguration(new TrainersOfCoursesEntityConfiguration())
                .ApplyConfiguration(new TrainersOfGroupsEntityConfiguration());
        }
    }
}
