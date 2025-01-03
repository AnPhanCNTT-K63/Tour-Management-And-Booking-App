using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using TravelWebBackEndCore.DTOs.Auth;
using TravelWebBackEndCore.Interfaces.Service;
using TravelWebBackEndCore.Interfaces.Repository;

namespace TravelWebBackEndCore.Services
{
    public class EmailService : IEmailService
    {
        private readonly IUserRepository _userRepository;
        public EmailService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IActionResult> SendPasswordResetCode(EmailRequestDTO emailRequest)
        {
            try
            {
                var user = await _userRepository.FindByEmailAsync(emailRequest.To);
                if (user == null)
                {
                    throw new BadHttpRequestException("Invalid email request.");

                }

                var verificationCode = new Random().Next(100000, 999999).ToString();

                user.VerificationCode = verificationCode;
                user.VerificationCodeExpiration = DateTime.UtcNow.AddMinutes(5);
                await _userRepository.SaveChangesAsync();

                emailRequest.Subject = "Password Reset Code";
                emailRequest.Body = $"Your verification code is valid for 5 minutes: {verificationCode}";


                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("phanducan147@gmail.com", "xtoe wian jrwy twdq"),
                    EnableSsl = true
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("phanducan147@gmail.com", "VVBA Travel Agency"),
                    Subject = emailRequest.Subject,
                    Body = emailRequest.Body,
                    IsBodyHtml = false
                };

                mailMessage.To.Add(emailRequest.To);

                await smtpClient.SendMailAsync(mailMessage);

                return new OkObjectResult(new { message = "success" });
            }

            catch (Exception ex)
            {
                throw new BadHttpRequestException(ex.Message);
            }
        }
    }
}
