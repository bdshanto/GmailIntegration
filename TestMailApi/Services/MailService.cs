using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Options;
using TestMailApi.IServices;
using TestMailApi.Models;

namespace TestMailApi.Services;

public class MailService : IMailService
{
    private readonly MailSettings _mailSettings;
    public MailService(IOptions<MailSettings> mailSettings)
    {
        _mailSettings = mailSettings.Value;
    }

    public async Task SendEmailAsync(MailRequest mailRequest)
    {
        try
        {
            string toEmail = mailRequest.ToEmail;


            MailMessage mail = new MailMessage()
            {
                From = new MailAddress(_mailSettings.Mail, "CDAS MAIL CHECKING")
            };
            mail.To.Add(new MailAddress(toEmail));

            mail.Subject = "Personal Management System - ";
            mail.Body = @"THIS IS CONSTANT TEST Message";
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            using (SmtpClient smtp = new SmtpClient(_mailSettings.Host, _mailSettings.Port))
            {
                smtp.Credentials = new NetworkCredential(_mailSettings.Mail, _mailSettings.Password);
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(mail);
            }
        }
        catch (Exception ex)
        {
            //do something here
        }


    }
}