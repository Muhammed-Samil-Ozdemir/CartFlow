using CartFlow.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CartFlow.Controllers;

[ApiController]
[Route("status")]
public class StatusController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            service = "CartFlow",
            status = "healthy",
            timestamp = DateTime.UtcNow
        });
    }
}