

using N37_HT1.Enum;
using N37_HT1.Models;
using N37_HT1.Services;

var user = new User("Mexroj", "Xaybullayev", "mexrojxaybullayev@gmail.com", Status.Registered);
var emailtemplate = new EmailTemplate("subjectAA", "bodyAA");

var emailservice = new EmailService();
var userservice = new UserService();
var emailtemplateService = new EmailTemplateService();
var emailsenderService = new EmailSenderService();

var notification = new NotificationManagementService(userservice, emailservice,
    emailtemplateService, emailsenderService);

await notification.NotifyUsers();
