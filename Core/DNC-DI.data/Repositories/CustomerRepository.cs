using DNC_DI.data.DataStore;
using DNC_DI.shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace DNC_DI.data.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        void CreateCustomer(Customer customer);
    }
    public class CustomerRepository : ICustomerRepository
    {

        public void CreateCustomer(Customer customer)
        {
            CustomersData.Customers.Add(customer);
        }

        public Customer GetCustomerById(int id)
        {
            return CustomersData.Customers.SingleOrDefault(x => x.ID == id);
        }

        public List<Customer> GetCustomers()
        {
            return CustomersData.Customers;
        }
    }
}
