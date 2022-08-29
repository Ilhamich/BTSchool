using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class GroupRepository : Repository<Groups>, IGroupRepository
    {
        public GroupRepository(AppContext context)
            : base(context)
        {
        }
    }
}
