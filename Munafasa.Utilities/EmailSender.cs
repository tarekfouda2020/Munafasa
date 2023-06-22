using System;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Munafasa.Utilities
{
    public class EmailSender : IEmailSender
    {

        Task IEmailSender.SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}

