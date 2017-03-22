using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Temporary.Models;

namespace Temporary.Repo
{
    public interface ItestingContext
    {
        DbSet<Product> Product { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

   
}
