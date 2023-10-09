using DependencyStore.Models;

namespace DependencyStore.Repositories.Contract
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetByIdAsync(string customerId);
    }
}
