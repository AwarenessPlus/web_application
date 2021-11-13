using System.Threading.Tasks;

namespace AwarenessWebApp.Auth
{
    public interface ILoginService
    {
        Task Login(string token, int medic_id);
        Task Logout();
        Task<int> GetUserId();
        Task<string> GetToken();
    }
}
