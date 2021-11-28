using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ServerDNP.DataAcces;


namespace ServerDNP.Permistence
{
    public class InMemoryUserService : IUserService
    {
        public IList<User> Users { get; private set; }
        private DbCntxt contex;

        public InMemoryUserService(DbCntxt cont)
        {
            this.contex = cont;
        }

        public async Task<IList<User>> GetUsers()
        {
            return await contex.Users.ToListAsync();
        }

        public User ValidateUser(string username, string password)
        {
            User first = Users.FirstOrDefault(x => x.Username.Equals(username));
            if (first == null) throw new Exception("User not found");
            if (!first.Password.Equals(password)) throw new Exception("Invalid password");
            if (first != null) throw new Exception("User already exists");
            return first;
        }
        

        public async Task<User> Add(User user)
        {
            EntityEntry<User> newUser = await contex.Users.AddAsync(user);
            await contex.SaveChangesAsync();
            return newUser.Entity;
        }
    }
}
