using BTSchool.Data.Repositories;

namespace BTSchool.Buisness.Services
{
    public class LessonService
    {
        IUnitOfWork _unitOfWork;

        public LessonService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
