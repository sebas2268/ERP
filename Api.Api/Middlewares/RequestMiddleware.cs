using Api.Api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace MovaltoSeguridadSocial.Api.Middlewares
{
    public class RequestMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestMiddleware> _logger;

        public RequestMiddleware(RequestDelegate next, ILogger<RequestMiddleware> logger)
        {
            _next = next ?? throw new ArgumentNullException(nameof(next));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var originalRequestBody = context.Request.Body;
            string apiKey = string.Empty;

            var ip = context.Connection.RemoteIpAddress.ToString().Equals("::1")
                ? "127.0.0.1"
                : context.Connection.RemoteIpAddress?.ToString() ?? "127.0.0.1";
            var objRequest = new Log { Ip = ip };
            var requestBodyStream = new MemoryStream();
            await context.Request.Body.CopyToAsync(requestBodyStream);
            requestBodyStream.Seek(0, SeekOrigin.Begin);
            var url = context.Request.GetDisplayUrl();
            var requestBodyText = await new StreamReader(requestBodyStream).ReadToEndAsync();
            objRequest.Url = url;
            objRequest.ClientId = apiKey;
            objRequest.HttpStatusCode = (int)HttpStatusCode.Continue;
            objRequest.HttpStatusCodeDescription = HttpStatusCode.Continue.ToString();
            objRequest.Method = context.Request.Method;
            objRequest.Body = (context.Request.ContentLength ?? 0) <= 5242880
                ? requestBodyText
                : "::PAQUETE ENVIADO DESDE FRONTEND ES DEMASIADO GRANDE POR ESO NO SE TRAZA EN DB::";
            objRequest.CreationDate = DateTime.Now;
            requestBodyStream.Seek(0, SeekOrigin.Begin);
            context.Request.Body = requestBodyStream;
            _logger.LogInformation(JsonConvert.SerializeObject(objRequest));
            var originalBody = context.Response.Body;
            await _next(context);

            context.Response.Body = originalBody;

        }
    }
}
