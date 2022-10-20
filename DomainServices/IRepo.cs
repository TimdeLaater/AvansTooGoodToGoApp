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
        public List<T> Get();
        public T Get(T entity);
        public void Create(T entity);
        public void Remove(T etityId);
        public void Update(T Entity, T etityId);

    }
}
