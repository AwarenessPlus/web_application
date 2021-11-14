using System.Threading.Tasks;

namespace AwarenessWebApp.Auth
{
    public interface ILoginService
    {
        Task Login(string token, int medic_id, string medic_username);
        Task Logout();
        Task<int> GetUserId();
        Task<string> GetUserUserName();
    }
}
