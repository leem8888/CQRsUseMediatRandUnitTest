using CQRSTest.Requests;
using MediatR;

namespace CQRSTest.Handles
{
    public class ExampleHandle : IRequestHandler<ExampleRequest, IResult>
    {
        public async Task<IResult> Handle(ExampleRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(10);
            return Results.Ok(new
            {
                mess = $"the age was:{request.Age} and the name was {request.Name}"
            });
        }
    }
}
