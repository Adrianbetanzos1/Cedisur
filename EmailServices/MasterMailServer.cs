using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;


namespace Cedisur.EmailServices
{
    public abstract class MasterMailServer
    {
        private SmtpClient SmtpClient;
        protected string? SenderMail { get; set; }
        protected string? Contraseña { get; set; }
        protected string? Host { get; set; }
        protected int Port { get; set; }
        protected bool Ssl { get; set; }

        protected void InitializeSmtpClient()
        {
            SmtpClient = new()
            {
                Credentials = new NetworkCredential(SenderMail, Contraseña),
                Host = Host,
                Port = Port,
                EnableSsl = Ssl
            };


        }


        public void SendMail(string asunto, string cuerpo, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(SenderMail);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = asunto;
                mailMessage.Body = cuerpo;
                mailMessage.Priority = MailPriority.Normal;
                SmtpClient.Send(mailMessage);

            }
            catch(Exception ex)
            {

            }
            finally
            {
                mailMessage.Dispose();
                SmtpClient.Dispose();
            }

        }

    }
}
