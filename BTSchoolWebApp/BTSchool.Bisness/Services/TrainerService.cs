using BTSchool.Data.Repositories;

namespace BTSchool.Buisness.Services
{
    public class TrainerService
    {
        IUnitOfWork _unitOfWork;

        public TrainerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        } 
    }
}
