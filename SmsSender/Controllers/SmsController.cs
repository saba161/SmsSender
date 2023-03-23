using Microsoft.AspNetCore.Mvc;
using SmsSender.Services;

namespace SmsSender.Controllers;

[ApiController]
[Route("[controller]")]
public class SmsController : ControllerBase
{
    private readonly IService _smsSender;

    public SmsController(IService smsSender)
    {
        _smsSender = smsSender;
    }

    [HttpGet]
    public IActionResult SendSms()
    {
        return Ok(_smsSender.Execute());
    }
}