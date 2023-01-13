using Microsoft.EntityFrameworkCore;
using Portside.Persistance.DbContext;
using Portside.Persistance.Model;
using PortsideUi.Services.Interfaces;

namespace PortsideUi.Services;

public class CustomerService : ICustomerService
{
    private readonly DataBaseContext _context;

    public CustomerService(DataBaseContext context)
    {
        _context = context;
    }

    public async Task<List<Customer?>> GetCustomersAsync()
    {
        return await _context.Customers.ToListAsync();
    }

    public async Task<Customer?> GetCustomerByIdAsync(string id)
    {
        return await _context.Customers.FindAsync(id);
    }

    public async Task AddCustomerAsync(Customer customer)
    {
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateCustomerAsync(Customer customer)
    {
        _context.Customers.Update(customer);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteCustomerAsync(string id)
    {
        var customer = await _context.Customers.FindAsync(id);
        _context.Customers.Remove(customer);
        await _context.SaveChangesAsync();
    }
}