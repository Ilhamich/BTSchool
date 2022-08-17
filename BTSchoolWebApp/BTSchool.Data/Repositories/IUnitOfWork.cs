using BTSchool.Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace BTSchool.Data.Repositories
{
    public interface IUnitOfWork
    {
        IAccountRepository AccountRepository { get; } 
        IAccountantRepository AccountantRepository { get; }
        ICourseRepository CourseRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        IGroupRepository GroupRepository { get; }
        ILessonRepository LessonRepository { get; }
        IProductRepository ProductRepository { get; }
        ISaleRepository SaleRepository { get; }
        IServiceRepository ServiceRepository { get; }
        IServicesOfCoursesRepository ServicesOfCoursesRepository { get; }
        IStudentRepository StudentRepository { get; }
        IStudentsOfGroupsRepository StudentsOfGroupsRepository { get; }
        IThemeRepository ThemeRepository { get; }
        ITrainersOfCoursesRepository TrainersOfCoursesRepository { get; }
        ITrainersOfGroupsRepository TrainersOfGroupsRepository { get; }
        ITrainersRepository TrainersRepository { get; }
        Task CommitAsync();
        Task Rollback();
    }
}
