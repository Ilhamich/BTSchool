using BTSchool.Data.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{
    internal class ThemeRepository : Repository<Themes>, IThemeRepository
    {
        public ThemeRepository(AppContext context)
            : base(context)
        {
        }
    }
}
