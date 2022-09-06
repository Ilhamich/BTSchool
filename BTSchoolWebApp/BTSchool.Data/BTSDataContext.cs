using Microsoft.EntityFrameworkCore;

using BTSchool.Core.Entities;
using BTSchool.Data.Configurations;

namespace BTSchool.Data
{
    public class BTSDataContext : DbContext
    {
        public BTSDataContext(DbContextOptions<BTSDataContext> options)
            : base(options)
        { }

        public virtual DbSet<Accountant> Accountants { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceOfCourse> ServicesOfCourses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentOfGroup> StudentsOfGroups { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<TrainerOfCourse> TrainersOfCourses { get; set; }
        public virtual DbSet<TrainerOfGroup> TrainersOfGroups { get; set; }

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
