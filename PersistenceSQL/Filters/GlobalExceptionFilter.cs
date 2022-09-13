using ERP.Application.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ERP.PersistenceSQL.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception.GetType() == typeof(NotFoundException))
            {
                var exception = (NotFoundException)context.Exception;

                var validation = new
                {
                    Detail = exception.Message
                };

                var json = new
                {
                    errors = new[] { validation }
                };

                var probleDetails = new ProblemDetails
                {
                    Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.3.5",
                    Title = "The specified resource was not found.",
                    Status = StatusCodes.Status204NoContent,
                    Detail = context.Exception.Message,
                };

                context.Result = new BadRequestObjectResult(probleDetails);
                context.HttpContext.Response.StatusCode = StatusCodes.Status204NoContent;
                context.ExceptionHandled = true;
                probleDetails.Extensions.Add("errors", json);
            }

            if (context.Exception.GetType() == typeof(BadRequestException))
            {
                var exception = (BadRequestException)context.Exception;

                var validation = new
                {
                    Detail = exception.Message
                };

                var json = new
                {
                    errors = new[] { validation }
                };

                var probleDetails = new ProblemDetails
                {
                    Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.1",
                    Title = "One or more validation errors occurred.",
                    Status = StatusCodes.Status400BadRequest,
                    Detail = context.Exception.Message,
                };

                context.Result = new BadRequestObjectResult(probleDetails);
                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.ExceptionHandled = true;
                probleDetails.Extensions.Add("errors", json);
            }
        }
    }
}
