using ProjectCommerce.API.Data;
using ProjectCommerce.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectCommerce.API.Service
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Product Get(int Id) => _context.Products.Find(Id);

        public List<Product> GetAll() => _context.Products.ToList();
    }
}
