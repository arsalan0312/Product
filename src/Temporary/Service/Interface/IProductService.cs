using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Temporary.Dto;
using Temporary.Repo;

namespace Temporary.Service.Interface
{
    
    public interface IProductService
    {
        Task<int> AddProduct(AddUpdateProductRequestDto productRequestDto);
    }
}
