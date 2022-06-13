using System.IO;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Http;

static  void Main(string[] args)
{


}


public class MailSettings
{
    public string Mail { get; set; }
    public string DisplayName { get; set; }
    public string Password { get; set; }
    public string Host { get; set; }
    public int Port { get; set; }
}
