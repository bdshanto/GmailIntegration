﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



public class EmailModel
{
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public IFormFile Attachment { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
