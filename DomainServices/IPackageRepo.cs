using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models;

namespace DomainServices
{
    public interface IPackageRepo : IRepo<Package>
    {
        Task<IEnumerable<Package>> GetAllAsync();
        Task<Package> GetByIdAsync(int id);
        public Package GetbyId(int id);
        Task<IEnumerable<Product>> GetAllProducts(int PackageId);

    }
}
