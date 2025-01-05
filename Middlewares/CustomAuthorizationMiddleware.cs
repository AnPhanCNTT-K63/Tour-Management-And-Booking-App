using Microsoft.AspNetCore.Http;
using System.Net;
using System.Threading.Tasks;

public class CustomAuthorizationMiddleware
{
    private readonly RequestDelegate _next;

    public CustomAuthorizationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        await _next(context);

        // Check if the response status code is 401 (Unauthorized)
        if (context.Response.StatusCode == (int)HttpStatusCode.Unauthorized)
        {
            // Customize the response for unauthorized access
            context.Response.ContentType = "application/json";
            var response = "You are not authorized to access this resource.";
            var responseBody = System.Text.Json.JsonSerializer.Serialize(response);

            // Rewrite the response body
            await context.Response.WriteAsync(responseBody);
        }

        if (context.Response.StatusCode == (int)HttpStatusCode.Forbidden)
        {
            // Customize the response for unauthorized access
            context.Response.ContentType = "application/json";
            var response = "You do not have permission to access this resource.";
            var responseBody = System.Text.Json.JsonSerializer.Serialize(response);

            // Rewrite the response body
            await context.Response.WriteAsync(responseBody);
        }
    }
}
