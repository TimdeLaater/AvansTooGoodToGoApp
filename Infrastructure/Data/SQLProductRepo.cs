using DomainModel.Models;
using DomainServices;
using Infrastructure;
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

        public Task<IEnumerable<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> Get()
        {
            throw new NotImplementedException();
        }

        public Product Get(Product entity)
        {
            throw new NotImplementedException();
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
}
