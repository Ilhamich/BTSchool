using BTSchool.Data.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{
    internal class StudentsOfGroupsRepository : Repository<StudentsOfGroups>, IStudentsOfGroupsRepository
    {
        public StudentsOfGroupsRepository(AppContext context)
            : base(context)
        {
        }
    }
}
