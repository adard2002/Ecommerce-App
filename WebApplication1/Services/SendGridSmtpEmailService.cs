using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class SendGridEmailService : IEmailService
    {
        public Task SendEmail(string email, string subject)
        {
            throw new NotImplementedException();
        }
    }

    public class sendGridHttpEmailService : IEmailService
    {
        public IConfiguration configuration;

        public sendGridHttpEmailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        public Task SendEmail(string email, string subject)
        {
            var http = new HttpClient();
            var sendUrl = configuration["SendGrid:ApiSendUrl"] ?? throw new InvalidOperationException("Missing ApiSendUrl");

            throw new NotSupportedException("Api too hard");
        }
    }
    public class SendGridSmtpEmailService : IEmailService
        {
            public Task SendEmail(string email, string subject)
            {
                var smtp = new SmtpClient();

                // TODO: GET THE API KEY https://app.sendgrid.com/login?redirect_to=%2Fguide%2Fintegrate%2Flangs%2Fcurl 
                return Task.CompletedTask;
            }
        }
    }

