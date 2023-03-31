using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;



namespace CQRSTest.Model
{
    public class GetCustomerDetailQueryHandler : IRequestHandler<GetCustomerDetailQuery, CustomerDetailViewModel>
    {
        public async Task<CustomerDetailViewModel> Handle(GetCustomerDetailQuery request, CancellationToken cancellationToken)
        {

            List<Customers> Customers = new List<Customers>()
                    {
                new Customers{Id=1,Name="anh" , Address="Phu Tho"},
                new Customers{Id=2,Name="trang" , Address="hoi an"},
                new Customers{Id=3,Name="son" , Address="ca mau"},
                new Customers{Id=4,Name="duc" , Address="ha giang"},
                    };
            // Ở đây chỉ giả lập dữ liệu. Trên thực tế phải tương tác với DB thật
            var model = Customers.Find(c => c.Id == request.Id);
            if (model == null)
            {
                throw new Exception(); //NotFoundException(nameof(Customer), request.Id);
            }
            var vm = new CustomerDetailViewModel
            {
                Name = model.Name,
                Address = model.Address
            };
            return await Task.FromResult(vm);

        }
    }
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
