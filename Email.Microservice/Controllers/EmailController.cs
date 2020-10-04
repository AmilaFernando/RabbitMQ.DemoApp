using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace Email.Microservice.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IBus _bus;
        public EmailController(IBus bus)
        {
            _bus = bus;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(EmailModel email)
        {
            if (email != null)
            {
                email.SendDate = DateTime.Now;
                Uri uri = new Uri("rabbitmq://localhost/emailQueue");
                var endPoint = await _bus.GetSendEndpoint(uri);
                await endPoint.Send(email);
                return Ok();
            }
            return BadRequest();
        }
    }
}
