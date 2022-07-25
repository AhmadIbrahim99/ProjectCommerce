using ProjectCommerce.API.Models;
using System.Collections.Generic;

namespace ProjectCommerce.API.Service
{
    public interface IProductService
    {
        public List<Product> GetAll();
        public Product Get(int Id);
    }
}
