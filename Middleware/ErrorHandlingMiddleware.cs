using System.Net;
using System.Text.Json;
// add error handling middleware

using Microsoft.AspNetCore.Mvc;

namespace minimalapicleanarchitecture.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }
        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
             var response = context.Response;
            response.ContentType = "application/json";
            response.StatusCode = exception switch
            {
                ApplicationException => (int)HttpStatusCode.BadRequest,// custom application error
                KeyNotFoundException  => (int)HttpStatusCode.NotFound,// not found error
                _ => (int)HttpStatusCode.InternalServerError// unhandled error
            };
            var result = JsonSerializer.Serialize(new { message = exception?.Message });
            await response.WriteAsync(result);
        }
    }
}
