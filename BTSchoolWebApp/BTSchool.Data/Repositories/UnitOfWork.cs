using BTSchool.Data.Repositories.Implementation;
using BTSchool.Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace BTSchool.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        #region private
        private readonly AppContext _context;
        private IAccountRepository _accountRepository;
        private IAccountantRepository _accountantRepository;
        private ICourseRepository _courseRepository;
        private ICustomerRepository _customerRepository;
        private IGroupRepository _groupRepository;
        private ILessonRepository _lessonRepository;
        private IProductRepository _productRepository;
        private ISaleRepository _saleRepository;
        private IServiceRepository _sarviceRepository;
        private IServicesOfCoursesRepository _servicesOfCoursesRepository;
        private IStudentRepository _studentRepository;
        private IStudentsOfGroupsRepository _studentsOfGroupsRepository;
        private IThemeRepository _themeRepository;
        private ITrainersOfCoursesRepository _trainersOfCoursesRepository;
        private ITrainersOfGroupsRepository _trainersOfGroupsRepository;
        private ITrainersRepository _trainersRepository;
        #endregion

        public UnitOfWork(AppContext context)
        {
            _context = context;
        }

        public IAccountRepository AccountRepository
        {
            get => _accountRepository ??= new AccountRepository(_context);
        }

        public IAccountantRepository AccountantRepository
        {
            get => _accountantRepository ??= new AccountantRepository(_context);
        }

        public ICourseRepository CourseRepository
        {
            get => _courseRepository ??= new CourseRepository(_context);
        }

        public ICustomerRepository CustomerRepository
        {
            get => _customerRepository ??= new CustomerRepository(_context);
        }

        public IGroupRepository GroupRepository
        {
            get => _groupRepository ??= new GroupRepository(_context);
        }

        public ILessonRepository LessonRepository
        {
            get => _lessonRepository ??= new LessonRepository(_context);
        }

        public IProductRepository ProductRepository
        {
            get => _productRepository ??= new ProductRepository(_context);
        }

        public ISaleRepository SaleRepository
        {
            get => _saleRepository ??= new SaleRepository(_context);
        }

        public IServiceRepository ServiceRepository
        {
            get => _sarviceRepository ??= new ServiceRepository(_context);
        }

        public IServicesOfCoursesRepository ServicesOfCoursesRepository
        {
            get => _servicesOfCoursesRepository ??= new ServicesOfCoursesRepository(_context);
        }

        public IStudentRepository StudentRepository
        {
            get => _studentRepository ??= new StudentRepository(_context);
        }

        public IStudentsOfGroupsRepository StudentsOfGroupsRepository
        {
            get => _studentsOfGroupsRepository ??= new StudentsOfGroupsRepository(_context);
        }

        public IThemeRepository ThemeRepository
        {
            get => _themeRepository ??= new ThemeRepository(_context);
        }

        public ITrainersOfCoursesRepository TrainersOfCoursesRepository 
        {
            get => _trainersOfCoursesRepository ??= new TrainersOfCoursesRepository(_context);
        }

        public ITrainersOfGroupsRepository TrainersOfGroupsRepository 
        {
            get => _trainersOfGroupsRepository ??= new TrainersOfGroupsRepository(_context);
        }

        public ITrainersRepository TrainersRepository 
        {
            get => _trainersRepository ??= new TrainersRepository(_context);
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Rollback()
        {
            await _context.DisposeAsync();
        }
    }
}
