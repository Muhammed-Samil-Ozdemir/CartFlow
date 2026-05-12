using CartFlow.Common;
using Microsoft.AspNetCore.Mvc;

namespace CartFlow.Abstractions;

[Route("api/[controller]")]
[ApiController]
public class CustomBaseController : ControllerBase
{
    [NonAction]
    public IActionResult CreateActionResult<T>(Result<T> result)
    {
        return result.Status switch
        {
            ResultStatus.Ok =>
                Ok(result),

            ResultStatus.Created =>
                Created(string.Empty, result),

            ResultStatus.BadRequest =>
                BadRequest(result),

            ResultStatus.NotFound =>
                NotFound(result),

            ResultStatus.Unauthorized =>
                Unauthorized(result),

            ResultStatus.Conflict =>
                Conflict(result),

            ResultStatus.ServerError =>
                StatusCode(500, result),

            _ =>
                StatusCode(500, result)
        };
    }

    [NonAction]
    public IActionResult CreateActionResult(Result result)
    {
        return result.Status switch
        {
            ResultStatus.Ok =>
                Ok(result),

            ResultStatus.Created =>
                StatusCode(201, result),

            ResultStatus.BadRequest =>
                BadRequest(result),

            ResultStatus.NotFound =>
                NotFound(result),

            ResultStatus.Unauthorized =>
                Unauthorized(result),

            ResultStatus.Conflict =>
                Conflict(result),

            ResultStatus.ServerError =>
                StatusCode(500, result),

            _ =>
                StatusCode(500, result)
        };
    }
}