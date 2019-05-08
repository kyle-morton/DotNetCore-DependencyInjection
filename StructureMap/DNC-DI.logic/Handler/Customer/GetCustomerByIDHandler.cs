using DNC_DI.data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DNC_DI.logic.Handler.Customer
{
    public class GetCustomerByIDHandler : IRequestHandler<GetCustomerByIDRequest, GetCustomerByIDResponse>
    {

        private ICustomerRepository _repo;

        public GetCustomerByIDHandler(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public async Task<GetCustomerByIDResponse> Handle(GetCustomerByIDRequest request, CancellationToken cancellationToken)
        {
            var customer = await _repo.GetByID(request.ID);
            return new GetCustomerByIDResponse {
                Customer = customer
            };
        }
    }

    public class GetCustomerByIDRequest : IRequest<GetCustomerByIDResponse>
    {
        public int ID { get; set; }
    }

    public class GetCustomerByIDResponse
    {
        public shared.Models.Customer Customer { get; set; }
    }
}
