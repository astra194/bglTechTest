using System.Collections.Generic;

namespace bglTechTest.Web.Infrastructure.RequestResponse
{
    public class SuccessResponse<TResponse> : IRequestResponse<TResponse>
    {
        private readonly TResponse _response;

        public SuccessResponse(TResponse response)
        {
            _response = response;
        }

        public IEnumerable<string> Errors
        {
            get
            {
                yield break;
            }
        }

        public bool IsSuccess => true;

        public TResponse Response => _response;
    }
}