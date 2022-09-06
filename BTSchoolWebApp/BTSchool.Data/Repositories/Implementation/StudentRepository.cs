using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(BTSDataContext context)
            : base(context)
        {
        }
    }
}
