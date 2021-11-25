using System.Threading.Tasks;
using Client.Models;

namespace Client.Login
{
    public interface IUserData
    {
        Task Add(User user);
        Task<User> Get(string username, string password);
       
    }
}