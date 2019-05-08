using DNC_DI.data.Repositories;

namespace DNC_DI.logic.Handler.Customer
{

    public interface ICreateCustomerHandler
    {
        void Create(shared.Models.Customer customer);
    }

    public class CreateCustomerHandler : ICreateCustomerHandler
    {

        private ICustomerRepository _repo;

        public CreateCustomerHandler(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public void Create(shared.Models.Customer customer)
        {
            _repo.CreateCustomer(customer);
        }

    }
}
