using DNC_DI.data.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DNC_DI.logic.Handler.Customer
{
    public class EditCustomerHandler : IRequestHandler<EditCustomerRequest, EditCustomerResponse>
    {

        private ICustomerRepository _repo;

        public EditCustomerHandler(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public async Task<EditCustomerResponse> Handle(EditCustomerRequest request, CancellationToken cancellationToken)
        {
            await _repo.Edit(request.customer);
            return new EditCustomerResponse();
        }

    }

    public class EditCustomerRequest : IRequest<EditCustomerResponse>
    {
        public shared.Models.Customer customer { get; set; }
    }

    public class EditCustomerResponse
    {
    }
}
