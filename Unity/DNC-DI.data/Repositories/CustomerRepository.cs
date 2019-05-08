using DNC_DI.data.DataStore;
using DNC_DI.shared.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNC_DI.data.Repositories
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetCustomers();
        Task<Customer> GetCustomerById(int id);
        Task CreateCustomer(Customer customer);
    }
    public class CustomerRepository : ICustomerRepository
    {

        public async Task CreateCustomer(Customer customer)
        {
            await Task.Run(() =>
            {
                CustomersData.Customers.Add(customer);
            });
            
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await Task.Run(() =>
            {
                return CustomersData.Customers.SingleOrDefault(x => x.ID == id);
            });
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await Task.Run(() =>
            {
                return CustomersData.Customers;
            });   
        }
    }
}
