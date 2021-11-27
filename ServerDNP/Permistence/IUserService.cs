using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;


namespace ServerDNP.Permistence
{
    
    public interface IUserService
    {
        Task<IList<User>> GetUsers();

        User ValidateUser(string username, string password);
        Task<User> Add(User user);
    }
    }
