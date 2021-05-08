using System.Threading.Tasks;

namespace WebApplication1.Services
{

    public partial class LoggerEmailService
    {
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
}
