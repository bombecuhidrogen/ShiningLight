using System;
using System.Collections.Generic;
using System.Text;

namespace ShinigLight.ApplicationLogic.Abstractions
{
     public interface IRepository<T>
       {
            IEnumerable<T> GetAll();
            T Add(T item);
            T Update(T item);
            bool Delete(T item);
       }
    
}
