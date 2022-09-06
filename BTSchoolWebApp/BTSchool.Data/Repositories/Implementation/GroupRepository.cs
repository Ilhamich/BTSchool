using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class GroupRepository : Repository<Group>, IGroupRepository
    {
        public GroupRepository(BTSDataContext context)
            : base(context)
        {
        }
    }
}
