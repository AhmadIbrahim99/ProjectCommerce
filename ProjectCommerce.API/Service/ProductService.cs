using ProjectCommerce.API.Data;
using ProjectCommerce.API.DTO;
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

        public List<Product> Create(CreateProductDTO productDTO)
        {
            _context.Products.Add(new Product() { Name = productDTO.Name, Cost = productDTO.Cost });
            _context.SaveChanges();
            return GetAll();
        }

        public void Delete(int Id)
        {
            _context.Products.Remove(_context.Products.Find(Id));
            _context.SaveChanges();
        }

        public Product Get(int Id) => _context.Products.Find(Id);

        public List<Product> GetAll() => _context.Products.ToList();

        public Product Update(UpdateProductDTO productDTO)
        {
            var product = new Product() { Id = productDTO.Id, Name = productDTO.Name, Cost = productDTO.Cost };
            _context.Products.Update(product);
            _context.SaveChanges();
            return product;
        }
    }
}
