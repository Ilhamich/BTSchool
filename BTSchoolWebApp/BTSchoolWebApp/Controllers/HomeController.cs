using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BTSchool.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        // GET: HomeController
        public async Task<ActionResult> Index()
            => await Task.Run(() => View());   
    }
}
