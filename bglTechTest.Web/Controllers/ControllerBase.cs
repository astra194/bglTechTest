using bglTechTest.Web.Infrastructure.RequestResponse;
using System;
using System.Web.Mvc;

namespace bglTechTest.Web.Controllers
{
    public class ControllerBase : Controller
    {
        protected object ToViewModel<TResponse>(IRequestResponse<TResponse> response, Func<TResponse, object> success, Func<object> failure)
        {
            if (response.IsSuccess)
                return success(response.Response);
            else
            {
                foreach (string error in response.Errors)
                {
                    ModelState.AddModelError("", error);
                }
                return failure();
            }
        }
    }
}