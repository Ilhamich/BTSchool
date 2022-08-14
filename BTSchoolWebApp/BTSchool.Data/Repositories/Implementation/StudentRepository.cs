using BTSchool.Data.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{
    internal class StudentRepository : Repository<Students>, IStudentRepository
    {
        public StudentRepository(AppContext context)
            : base(context)
        {
        }
    }
}
