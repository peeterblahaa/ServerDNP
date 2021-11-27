using System.Threading.Tasks;

using Entities;

namespace Client.Login
{
    public interface IUserData
    {
        Task Add(User user);
        Task<User> Get(string username, string password);
       
    }
}