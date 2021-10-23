using System;

namespace IdentityExample.Services
{
    public interface IEmailService : IDisposable
    {
        void Send(string to, string subject, string html, string from = null);
        //Task SendAlreadyRegisteredEmail(string emial, string origin);
    }
}
