using System.Threading.Tasks;
using Temporary.Models;

namespace Temporary.Repo 
{
    public interface IProductRepo 
    {
        Task<int> add(Product product);
        int Add(Product product);
    }
}
