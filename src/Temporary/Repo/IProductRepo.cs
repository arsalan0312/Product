using System.Collections.Generic;
using System.Threading.Tasks;
using Temporary.Models;

namespace Temporary.Repo 
{
    public interface IProductRepo 
    {
        Task<int> Add(Product product);
        void Update(Product product);
        void Remove(long key);        
        Product Find(long key);
     
        IEnumerable<Product> GetAll();
    }
}
