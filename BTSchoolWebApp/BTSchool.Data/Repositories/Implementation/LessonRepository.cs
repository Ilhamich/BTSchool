using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class LessonRepository : Repository<Lessons>, ILessonRepository
    {
        public LessonRepository(AppContext context)
            : base(context)
        {
        }
    }
}
