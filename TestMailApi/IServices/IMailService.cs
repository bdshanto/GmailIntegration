using TestMailApi.Models;
using TestMailApi.Services;

namespace TestMailApi.IServices;

public interface IMailService
{
    Task SendEmailAsync(MailRequest mailRequest);
}