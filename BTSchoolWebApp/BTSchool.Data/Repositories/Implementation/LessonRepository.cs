using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class LessonRepository : Repository<Lesson>, ILessonRepository
    {
        public LessonRepository(BTSDataContext context)
            : base(context)
        {
        }
    }
}
