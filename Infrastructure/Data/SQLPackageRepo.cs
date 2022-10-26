using DomainModel.Models;
using DomainServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class SQLPackageRepo : IPackageRepo
    {
        private readonly FoodDBContext _context;
        public SQLPackageRepo(FoodDBContext foodDBContext)
        {
            this._context = foodDBContext;
        }

        

        public void Create(Package package)
        {
            _context.Packages.Add(package);
            _context.SaveChanges();


        }

        public List<Package> GetAll()
        {
            return _context.Packages.ToList();
        }

        public async Task<IEnumerable<Package>> GetAllAsync()
        {
            return await _context.Packages.ToListAsync();
        }

       

        public Task<IEnumerable<Product>> GetAllProducts(int PackageId)
        {
            //TODO: Implement Getting al the products
            throw new NotImplementedException();
        }

        public Package GetbyId(int etityId)
        {
            throw new NotImplementedException();
        }

        public async Task<Package> GetByIdAsync(int id) => await _context.Packages
            .Include(p => p.PackageId)
            .FirstOrDefaultAsync();

        public void Remove(int etityId)
        {
            _context.Remove(etityId);
            _context.SaveChanges();

        }

        public void Update(Package Entity, int etityId)
        {
            _context.Update(Entity);
            _context.SaveChanges();
        }
    }
}
