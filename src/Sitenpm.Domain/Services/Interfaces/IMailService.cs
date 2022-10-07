using System.Threading.Tasks;
using admin.Domain.Entities;

namespace admin.Domain.Services.Interfaces;

public interface IMailService
{
    Task SendPasswordResetMail(User user);
    Task SendActivationEmail(User user);
    Task SendCreationEmail(User user);
}
