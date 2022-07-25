using ProjectCommerce.API.DTO;
using ProjectCommerce.API.Models;
using System.Collections.Generic;

namespace ProjectCommerce.API.Service
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product Get(int Id);
        void Delete(int Id);
        List<Product> Create(ProductDTO productDTO);
        Product Update(ProductDTO productDTO);

    }
}
