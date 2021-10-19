using System;
using LocalizaMe.Localize;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace LocalizaMe.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Index(
            [FromServices] IStringLocalizer<Messages> localizer)
        {
            //return Ok(_resourceManager.GetString("Hello World"));
            return Ok(new
            {
                Message = localizer["Hello World"].Value,
                Date = DateTime.Now,
                DateUtc = DateTime.Now.ToUniversalTime()
            });
        }
    }
}