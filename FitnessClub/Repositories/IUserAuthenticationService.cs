using FitnessClub.Models;
using FitnessClub.ViewModels;

namespace FitnessClub.Repositories
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginViewModel model);
        Task<Status> RegistrationAsync(RegisterViewModel model);
        Task LogoutAsync();
    }
}
