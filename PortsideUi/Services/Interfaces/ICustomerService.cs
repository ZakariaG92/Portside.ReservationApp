using Portside.Persistance.Model;

namespace PortsideUi.Services.Interfaces;

public interface ICustomerService
{
    Task<List<Customer?>> GetCustomersAsync();
    Task<Customer?> GetCustomerByIdAsync(string id);
    Task AddCustomerAsync(Customer customer);
    Task UpdateCustomerAsync(Customer customer);
    Task DeleteCustomerAsync(string id);
}