using Microsoft.EntityFrameworkCore;
using RequisiteService.Domain;

namespace RequisiteService.Application.Interface
{
    public interface IRequisiteContext
    {
        public DbSet<Requisite> requisite { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
