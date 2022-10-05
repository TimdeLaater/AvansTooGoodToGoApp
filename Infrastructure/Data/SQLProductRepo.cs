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
        FoodDBContext context = new();
        public SQLProductRepo(FoodDBContext context)
        {
            this.context = context;
        }
        public SQLProductRepo()
        {

        }

        public void Create(Product entity)
        {
            context.Products.Add(entity);
            context.SaveChanges();
        }

        public Product Get(int productId)
        {
            var product = context.Products.Where(p => p.ProductId == productId);
            return (Product)product;
        }

        public List<Product> Get()
        {
            return context.Products.ToList();
        }

        public Product Get(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int productId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product, int productId)
        {
            throw new NotImplementedException();
        }
    }
}
