using ERP.Application.Common.Dates;
using ERP.Application.Interfaces.Common.Dates;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ERP.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddMvc().AddFluentValidation();
            services.AddTransient<IMachineDateTime, MachineDateTime>();
        }
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(errorApp =>
            {
                // Logs unhandled exceptions. For more information about all the
                // different possibilities for how to handle errors see
                // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-5.0

                errorApp.Run(async context =>
                {
                    var y = context.Features.Get<IExceptionHandlerFeature>();
                    var problemDetails = new ProblemDetails
                    {
                        Type = "https://datatracker.ietf.org/doc/html/rfc7807#page-6",
                        Title = "An unrecoverable error occurred",
                        Status = context.Response.StatusCode,
                        Detail = y.Error.Message,
                    };
                    problemDetails.Extensions.Add("RequestId", context.TraceIdentifier);
                    await context.Response.WriteAsJsonAsync(problemDetails, problemDetails.GetType(), null, contentType: "application/problem+json");
                });
            });
        }
    }
}