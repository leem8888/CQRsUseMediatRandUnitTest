using FluentValidation;

namespace CQRSTest.Model
{
    public class GetCustomerDetailQueryValidator : AbstractValidator<GetCustomerDetailQuery>
    {
        public GetCustomerDetailQueryValidator()
        {
            RuleFor(v => v.Id).GreaterThan(0);
        }
    }
}
