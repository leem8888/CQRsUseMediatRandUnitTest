using MediatR;

namespace CQRSTest.Requests
{
    public interface IHttpRequest :IRequest<IResult>
    {
    }
}
