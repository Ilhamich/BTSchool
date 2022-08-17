using BTSchool.Data.Repositories;

namespace BTSchool.Buisness.Services
{
    public class StudentService
    {
        IUnitOfWork _unitOfWork;

        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
