using System.Collections.Generic;
using System.Threading.Tasks;
using ServerDNP.Models;

namespace ServerDNP.Permistence
{
    
    public interface IUserService
    {
        Task<IList<User>> GetUsers();

        User ValidateUser(string username, string password);
        void SaveChanges();
        Task<User> Add(User user);
    }
    }
