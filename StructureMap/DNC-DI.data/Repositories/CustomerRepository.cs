using DNC_DI.data.DataStore;
using DNC_DI.shared.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNC_DI.data.Repositories
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> Get();
        Task<Customer> GetByID(int id);
        Task Create(Customer customer);
        Task Edit(Customer customer);
    }
    public class CustomerRepository : ICustomerRepository
    {

        public async Task Create(Customer customer)
        {
            await Task.Run(() =>
            {
                CustomersData.Customers.Add(customer);
            });
            
        }

        public async Task<Customer> GetByID(int id)
        {
            return await Task.Run(() =>
            {
                return CustomersData.Customers.SingleOrDefault(x => x.ID == id);
            });
        }

        public async Task<List<Customer>> Get()
        {
            return await Task.Run(() =>
            {
                return CustomersData.Customers;
            });   
        }

        public async Task Edit(Customer customer)
        {
            await Task.Run(() =>
            {
                var origCustomer = CustomersData.Customers.Single(c => c.ID == customer.ID);

                origCustomer.Name = customer.Name;
                origCustomer.Address = customer.Address;

            });
        }
    }
}
