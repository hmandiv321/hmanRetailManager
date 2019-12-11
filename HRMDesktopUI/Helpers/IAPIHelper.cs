using System.Threading.Tasks;
using HRMDesktopUI.Models;

namespace HRMDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUserModel> Authenticate(string username, string password);
    }
}