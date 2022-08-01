using Microsoft.EntityFrameworkCore;

namespace BTSchool.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        { }


    }
}
