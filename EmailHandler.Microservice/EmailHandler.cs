using MassTransit;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailHandler.Microservice
{
    public class EmailHandler : IConsumer<EmailModel>
    {
        public async Task Consume(ConsumeContext<EmailModel> context)
        {
            var email = context.Message;

            // Process Email here

        }
    }
}
