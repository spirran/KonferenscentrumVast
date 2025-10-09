using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Options;

public class EmailNotifications
{
    private readonly Smtpdata _edata;
    private readonly ILogger<EmailNotifications> _logger;

    public EmailNotifications(IOptions<Smtpdata> edata, ILogger<EmailNotifications> logger)
    {
        _edata = edata.Value;
        _logger = logger;
    }

    public async Task SendAsync(string to, string subject, string body)
    {
        using var smtp = new SmtpClient(_edata.Host, _edata.Port)
        {
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(_edata.Username, _edata.Password)
        };

        using var msg = new MailMessage(
            from: new MailAddress(_edata.Username, "Konferenscentrum Väst"),
            to: new MailAddress(to))
        {
            Subject = subject,
            Body = body,
            IsBodyHtml = false
        };

        await smtp.SendMailAsync(msg);
        _logger.LogInformation("Mail sent to {To}", to);
    }
}