namespace Abraks.Web.Areas.Identity.Services
{
    using System.Threading.Tasks;
    using Common.Constants;
    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.Extensions.Options;
    using SendGrid;
    using SendGrid.Helpers.Mail;

    public class SendGridEmailSender : IEmailSender
    {
        private readonly SendGridOptions options;

        public SendGridEmailSender(IOptions<SendGridOptions> options)
        {
            this.options = options.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient("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");
            var from = new EmailAddress(StringConstants.SendGridDefaultEmail, StringConstants.SendGridDefaultSender);
            var to = new EmailAddress(email, email);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, htmlMessage, htmlMessage);
            var response = await client.SendEmailAsync(msg);
            var body = await response.Body.ReadAsStringAsync();
            var statusCode = response.StatusCode;
        }
    }
}
