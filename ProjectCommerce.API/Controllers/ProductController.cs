using Microsoft.AspNetCore.Mvc;
using ProjectCommerce.API.Service;

namespace ProjectCommerce.API.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }

        public IActionResult GetAll() => Ok(_service.GetAll());
        public IActionResult Get(int id) => Ok(_service.Get(id));
    }
}
