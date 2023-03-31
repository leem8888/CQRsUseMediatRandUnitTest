using MediatR;

namespace CQRSTest.Model
{
    public class GetCustomerDetailQuery : IRequest<CustomerDetailViewModel>
    {
        public int Id { get; set; }
    }
}

