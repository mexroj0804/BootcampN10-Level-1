using N37_HT1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using N37_HT1.Models;

namespace N37_HT1.Services
{
    internal class NotificationManagementService : INotificationManagementService
    {
        private IUserService _userService;
        private IEmailService _emailService;
        private IEmailTemplateService _emailTemplateService;
        private IEmailSenderService _emailSenderService;

        public NotificationManagementService(UserService userService, EmailService emailService,
            EmailTemplateService emailTemplateService, EmailSenderService emailSenderService)
        {
            _userService = userService;
            _emailService = emailService;
            _emailTemplateService = emailTemplateService;
            _emailSenderService = emailSenderService;
        }

        public async Task NotifyUsers()
        {
            var users = _userService.GetUsers();
            var templates = _emailTemplateService.GetTemplates(users);
            var messages = _emailService.GetMessages(templates, users);
            await _emailSenderService.SendEmailsAsync(messages);
        }
    }
}
