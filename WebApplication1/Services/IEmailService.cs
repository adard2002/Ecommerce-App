using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public interface IEmailService
    {
        Task SendEmail(string email, string subject);
    }

    public class NullEmailService : IEmailService
    {
        public Task SendEmail(string email, string subject)
        {
            return Task.CompletedTask;
        }
    }

    public partial class LoggerEmailService : IEmailService
    {
        private readonly ILogger<LoggerEmailService> logger;
        public LoggerEmailService(ILogger<LoggerEmailService> logger)
        {
            this.logger = logger;
        }
        public Task SendEmail(string email, string subject)
        {
            logger.LogInformation("Sending to {0} with subject and stuff '{2}'", email, subject);
            return Task.CompletedTask;
        }
    }
}
