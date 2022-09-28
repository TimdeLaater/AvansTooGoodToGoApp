using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices
{
    public interface IProductRepo: IRepo<Product>
    {
        public Product Get(int productId);
        public void Remove(int productId);
        public void Update(Product product, int productId);
    }
}
