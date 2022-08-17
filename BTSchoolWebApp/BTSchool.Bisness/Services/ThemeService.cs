using BTSchool.Data.Repositories;

namespace BTSchool.Buisness.Services
{
    public class ThemeService
    {
        IUnitOfWork _unitOfWork;

        public ThemeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
