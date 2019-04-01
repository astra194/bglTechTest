using System.Collections.Generic;

namespace bglTechTest.Web.Infrastructure.RequestResponse
{
    public interface IRequestResponse
    {
        IEnumerable<string> Errors { get; }

        bool IsSuccess { get; }
    }

    public interface IRequestResponse<TResult> : IRequestResponse
    {
        TResult Response { get; }
    }
}