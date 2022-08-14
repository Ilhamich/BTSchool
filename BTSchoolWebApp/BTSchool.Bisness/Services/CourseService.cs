using BTSchool.Data.Repositories;

namespace BTSchool.Buisness.Services
{
    public class CourseService
    {
        IUnitOfWork _unitOfWork;

        public CourseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
