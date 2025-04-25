using System.Configuration;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Booker.Services
{
    public static partial class RegisterServices
    {
        public static IServiceCollection AddBookerServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<SendMailSvc.SmtpSettings>(configuration.GetSection("SmtpSettings"));   
            services.AddSingleton<IEmailSender, SendMailSvc>();
            return services;
        }
    }
}
