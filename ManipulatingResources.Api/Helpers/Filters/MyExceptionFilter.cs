using Microsoft.AspNetCore.Mvc.Filters;

namespace ManipulatingResources.Api.Helpers.Filters
{
    public class MyExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context) 
        {

        }
    }
}
