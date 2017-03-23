using System;
using System.Threading.Tasks;
using Temporary.Models;
using Temporary.Controllers;
using System.Collections.Generic;
using System.Linq;

using Temporary.Dto;

namespace Temporary.Repo
{
    public class ProductRepo : IProductRepo
    {
        private readonly ItestingContext _testingContext;
        private AddUpdateProductRequestDto validat;

        public ProductRepo(ItestingContext testingContext)
        {
            _testingContext = testingContext;
        }

        public async Task<int> Add(Product product)
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

      
        public Product Find(long key)
        {
            try
            {
                return _testingContext.Product.FirstOrDefault(t => t.ProductId == key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            
        }

        public IEnumerable<Product> GetAll()
        {
            try
            {
                return _testingContext.Product.ToList();
            }
            catch(Exception ex)
            {
                Console.Write(ex);
                throw;
            }

         
        }

        

        public void Remove(long key)
        {
            try
            
        {
            var entity = _testingContext.Product.First(t => t.ProductId == key);
            _testingContext.Product.Remove(entity);
            _testingContext.SaveChanges();
          }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }

        public  void Update(Product product)
        {

            try
            {
                _testingContext.Product.Update(product);
                _testingContext.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
       
    }
}
