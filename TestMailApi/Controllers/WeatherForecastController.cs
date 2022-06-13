using Microsoft.AspNetCore.Mvc;

namespace TestMailApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MailController : ControllerBase
    {


        private readonly ILogger<MailController> _logger;
        private readonly IMailService _iMailService;

        public MailController(ILogger<MailController> logger, IMailService mailService)
        {
            _logger = logger;
            this._iMailService = mailService;
        }

        [HttpGet]
        public async Task<IActionResult> SendMail()
        {
            var request = new MailRequest
            {
                Body = "I'm Working",
                Subject = "I'm Testing Subject",
                ToEmail = "hsibbd@gmail.com"
            };


            try
            {
                await _iMailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}