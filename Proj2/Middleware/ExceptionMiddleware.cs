using System.Text.Json;
using Proj2.Exceptions;

namespace Proj2.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionMiddleware> _logger;

    public ExceptionMiddleware(RequestDelegate next,
    ILogger<ExceptionMiddleware> logger)
    {
        _next=next;
        _logger=logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch(Exception ex)
        {
            _logger.LogError(ex,ex.Message);

            context.Response.ContentType="application/json";

            context.Response.StatusCode=ex switch
            {
                ProductNotFoundException=>StatusCodes.Status404NotFound,
                _=>StatusCodes.Status500InternalServerError
            };

            // var message=ex switch
            // {
            //     ProductNotFoundException=>ex.Message,
            //     _=> "An unexpected error occured"
            // };\


            var message=ex.Message;

            var response = new
            {
                success=false,
                message=message
            };

            await context.Response.WriteAsync(
                JsonSerializer.Serialize(response)
            );

        }
    }
}