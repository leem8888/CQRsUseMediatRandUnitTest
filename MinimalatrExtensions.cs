using CQRSTest.Requests;
using MediatR;

namespace CQRSTest
{
    public static class MinimalatrExtensions
    {
        public static WebApplication MediateGet<TRequest>(
            this WebApplication app,
            string template            ) where TRequest : IHttpRequest
        {
            app.MapGet(template,async (IMediator mediator,[AsParameters] IRequest request)=>await mediator.Send(request));
            return app;
        }

        public static WebApplication MediatePost<TRequest>(
          this WebApplication app,
          string template) where TRequest : IHttpRequest
        {
            app.MapPost(template, async (IMediator mediator, [AsParameters] IRequest request) => await mediator.Send(request));
            return app;
        }

    }
}
