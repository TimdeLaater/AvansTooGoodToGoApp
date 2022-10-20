using DomainModel.Models;
using DomainServices;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class SQLProductRepo : IProductRepo
    {
        FoodDBContext _context = new();
        public SQLProductRepo(FoodDBContext context)
        {
            this._context = context;
        }
        public SQLProductRepo()
        {

        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(i => i.ProductId == id);
        }

        public List<Product> Get()
        {
            return _context.Products.ToList();

        }

        public Product Get(int id)
        {
            var product = _context.Products.Where(i => i.ProductId == id);
            return (Product)product;
        }

        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product etityId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product Entity, Product etityId)
        {
            throw new NotImplementedException();
        }
    }
