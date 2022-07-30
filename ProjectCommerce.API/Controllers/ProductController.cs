using Microsoft.AspNetCore.Mvc;
using ProjectCommerce.API.DTO;
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
        [HttpPost]
        public IActionResult Create([FromBody] CreateProductDTO productDTO)=> Ok(_service.Create(productDTO));

        [HttpPut]
        public IActionResult Update([FromBody] UpdateProductDTO productDTO) => Ok(_service.Update(productDTO));

    }
}
