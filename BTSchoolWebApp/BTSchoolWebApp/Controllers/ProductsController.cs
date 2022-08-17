using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using BTSchool.Buisness.ServiceInterfaces;

namespace BTSchool.WebApp.Controllers
{
    public class ProductsController : Controller
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<ActionResult> Index()
        {
            var products = await _productService.GetAllProductsAsync();

            return View(products);
        }
    }
}
