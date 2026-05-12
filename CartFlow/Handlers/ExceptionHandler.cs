using CartFlow.Common;
using CartFlow.Exceptions;
using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;

namespace CartFlow.Handlers;

public sealed class ExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        httpContext.Response.ContentType = "application/json";

        var actualException = exception is AggregateException agg && agg.InnerException != null
            ? agg.InnerException
            : exception;

        if (actualException is ValidationException validationException)
        {
            httpContext.Response.StatusCode = 422;
            var errors = validationException.Errors.Select(e => e.PropertyName).ToArray();
            await httpContext.Response.WriteAsJsonAsync(Result<string>.Failure(errors), cancellationToken);
            return true;
        }

        if (actualException is AuthorizationException)
        {
            httpContext.Response.StatusCode = 403;
            await httpContext.Response.WriteAsJsonAsync(Result<string>.Unauthorized("You are not authorized to perform this action"), cancellationToken);
            return true;
        }

        httpContext.Response.StatusCode = 500;
        await httpContext.Response.WriteAsJsonAsync(Result<string>.ServerError("An unexpected error occurred"), cancellationToken);

        return true;
    }
}