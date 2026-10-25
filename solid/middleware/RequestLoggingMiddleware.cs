
using System.Diagnostics;

public class RequestLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RequestLoggingMiddleware> _logger;

    public RequestLoggingMiddleware(RequestDelegate next, 
                                    ILogger<RequestLoggingMiddleware> logger)
    {
        _next=next;
        _logger=logger;
    }


    public async Task InvokeAsync(HttpContext context)
    {
        var stopwatch=Stopwatch.StartNew();

        _logger.LogInformation("Stopwatch started: {Method} {Path}",
                    context.Request.Method,
                    context.Request.Path);

        try
        {
            await _next(context);
        }
        finally
        {
            stopwatch.Stop();

            _logger.LogInformation("Stopwatch stopped : {StatusCode} took {EllapsedMiliseconds} ms",
                context.Response.StatusCode,
                stopwatch.ElapsedMilliseconds);
        }
    }
}