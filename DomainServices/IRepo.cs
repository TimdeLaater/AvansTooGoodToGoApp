using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices
{
    public interface IRepo<T>
    {
        public List<T> GetAll();
        
        public void Create(T entity);
        public void Remove(int etityId);
        public void Update(T Entity);

    }
}
