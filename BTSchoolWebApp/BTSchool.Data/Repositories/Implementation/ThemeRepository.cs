using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class ThemeRepository : Repository<Theme>, IThemeRepository
    {
        public ThemeRepository(BTSDataContext context)
            : base(context)
        {
        }
    }
}
