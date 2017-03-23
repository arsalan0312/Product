using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Temporary.Dto;
using Temporary.Models;
using Temporary.Repo;
using Temporary.Service.Interface;

namespace Temporary.Service.ServiceImplimentation
{
    public class ProductSerivce : IProductService
    {
        private readonly IProductRepo _productRepo;
        public ProductSerivce(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<int> AddProduct(AddUpdateProductRequestDto productRequestDto)
        {
            try
            {
                var response = _productRepo.Add(new Product
                {
                    ProductName = productRequestDto.ProductName
                });
                return await response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
