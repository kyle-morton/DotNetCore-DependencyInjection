using DNC_DI.data.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DNC_DI.logic.Handler.Customer
{

    public class GetCustomersHandler : IRequestHandler<GetCustomersRequest, GetCustomersResponse>
    {

        private ICustomerRepository _repo;

        public GetCustomersHandler(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public async Task<GetCustomersResponse> Handle(GetCustomersRequest request, CancellationToken cancellationToken)
        {
            var customers = await _repo.Get();
            return new GetCustomersResponse {
                Customers = customers
            };
        }
    }

    public class GetCustomersRequest : IRequest<GetCustomersResponse>
    {
    }

    public class GetCustomersResponse
    {
        public List<shared.Models.Customer> Customers { get; set; }
    }
}
