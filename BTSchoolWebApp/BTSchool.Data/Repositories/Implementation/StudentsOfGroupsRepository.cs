using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class StudentsOfGroupsRepository : Repository<StudentOfGroup>, IStudentsOfGroupsRepository
    {
        public StudentsOfGroupsRepository(BTSDataContext context)
            : base(context)
        {
        }
    }
}
