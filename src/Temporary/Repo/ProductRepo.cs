using System;
using System.Threading.Tasks;
using Temporary.Models;

namespace Temporary.Repo
{
    public class ProductRepo : IProductRepo
    {
        private ItestingContext _testingContext;
        public ProductRepo(ItestingContext testingContext)
        {
            _testingContext = testingContext;
        }
        public int Add(Product product)
        {
            try
            {
                _testingContext.Product.Add(product);
                return _testingContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<int> add(Product product)
        {
            try
            {
                _testingContext.Product.Add(product);
                return await Task.FromResult(_testingContext.SaveChanges());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
