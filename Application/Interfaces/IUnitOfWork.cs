using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IUnitOfWork
{
    Task<bool> SaveChangesAsync();
}
