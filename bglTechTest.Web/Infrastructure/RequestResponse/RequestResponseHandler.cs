using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace bglTechTest.Web.Infrastructure.RequestResponse
{
    public abstract class RequestResponseHandler<TRequest, TResponse> : IRequestHandler<TRequest, IRequestResponse<TResponse>>
        where TRequest : IRequest<IRequestResponse<TResponse>>
    {
        public async Task<IRequestResponse<TResponse>> Handle(TRequest request, CancellationToken cancellationToken)
        {
            try
            {
                return await HandleRequest(request, cancellationToken);
            }
            catch (Exception ex)
            {
                return await HandleException(ex, cancellationToken);
            }
        }

        protected abstract Task<IRequestResponse<TResponse>> HandleRequest(TRequest request, CancellationToken cancellationToken);

        protected virtual Task<IRequestResponse<TResponse>> HandleException(Exception ex, CancellationToken cancellationToken)
            => Task.FromResult(Failure(ex));

        protected IRequestResponse<TResponse> Success(TResponse response) => new SuccessResponse<TResponse>(response);

        protected IRequestResponse<TResponse> Failure(string error) => new FailureResponse<TResponse>(error);

        protected IRequestResponse<TResponse> Failure(Exception ex) => new FailureResponse<TResponse>(ex);
    }
}