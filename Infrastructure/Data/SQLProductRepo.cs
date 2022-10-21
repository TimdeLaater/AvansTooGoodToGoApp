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

        public List<Product> GetAll()
        {
            return _context.Products.ToList();

        }

        public Product GetbyId(int etityId)
        {
            return _context.Products.Find(etityId);
            
        }

        public void Create(Product entity)
        {
            _context.Products.Add(entity);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            _context.Products.Remove(_context.Products.Find(id));
            _context.SaveChanges();
        }

        public void Update(Product Entity, int etityId)
        {

            _context.Update(Entity);
            _context.SaveChanges();
        }

        
    }

}