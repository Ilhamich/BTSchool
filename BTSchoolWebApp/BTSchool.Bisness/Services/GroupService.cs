using BTSchool.Data.Repositories;

namespace BTSchool.Buisness.Services
{
    public class GroupService
    {
        IUnitOfWork _unitOfWork;

        public GroupService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
