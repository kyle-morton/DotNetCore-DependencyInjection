using DNC_DI.data.Repositories;
using System.Collections.Generic;

namespace DNC_DI.logic.Handler.Customer
{

    public interface IGetCustomersHandler
    {
        List<shared.Models.Customer> GetCustomers();
    }
    public class GetCustomersHandler : IGetCustomersHandler
    {

        private ICustomerRepository _repo;

        public GetCustomersHandler(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public List<shared.Models.Customer> GetCustomers()
        {
            return _repo.GetCustomers();
        }
    }
}
