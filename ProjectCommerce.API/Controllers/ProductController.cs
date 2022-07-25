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
        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());
        [HttpGet]
        public IActionResult Get(int id) => Ok(_service.Get(id));
        [HttpDelete]
        public IActionResult Delete(int id) 
        {
            _service.Delete(id);
            return Ok("Done"); 
        }
    }
}
