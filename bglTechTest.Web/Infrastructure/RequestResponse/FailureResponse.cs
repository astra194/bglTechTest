using System;
using System.Collections.Generic;

namespace bglTechTest.Web.Infrastructure.RequestResponse
{
    public class FailureResponse<TResponse> : IRequestResponse<TResponse>
    {
        private readonly List<string> _errors;
        private readonly TResponse _response = default(TResponse);

        public FailureResponse()
            : this (null, default(TResponse))
        {
        }

        public FailureResponse(TResponse response)
            : this(null, response)
        {
        }

        public FailureResponse(Exception ex)
            : this(ex?.Message, default(TResponse))
        {
        }

        public FailureResponse(string error, TResponse response = default(TResponse))
        {
            _errors = new List<string>();
            if (error != null)
                _errors.Add(error);

            _response = response;
        }

        public IEnumerable<string> Errors => _errors;

        public bool IsSuccess => false;

        public TResponse Response => _response;
    }
}