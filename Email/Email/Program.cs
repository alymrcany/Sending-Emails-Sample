﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            string fromMail = "alymrcany@gmail.com";
            string fromPassword = "otmd yvyn oesm muhr";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Read Me Juseyo";
            message.To.Add(new MailAddress("ptc.kanebertmendova@gmail.com"));
            message.To.Add(new MailAddress("kanebertmendova@gmail.com"));
            message.CC.Add(new MailAddress("alymrcany@gmail.com"));
            message.Body = "<html><body> Check out. This is an autogenerated email. May error pa. </body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }
    }
}
