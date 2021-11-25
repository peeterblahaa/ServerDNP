using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Client.Models;
using Newtonsoft.Json;


namespace Client.Login
{
    public class UserData : IUserData
    {

        private HttpClient client;
        private const string _url = "https://localhost:5002/Users";
        public IList<User> Users {  get; set; }
        public UserData()
        {
            client = new();
            Users = new List<User>();
        }

        public async Task<IList<User>> GetUsers()
        {
            if (!Users.Any())
            {
                HttpResponseMessage response = await client.GetAsync(_url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                
                Users = JsonConvert.DeserializeObject<List<User>>(responseBody);
            }

            return Users;
        }
        public async Task Add(User user)
        {
            User first = Users.FirstOrDefault(u => u.Username.Equals(user.Username));
            if (first != null) throw new Exception("User already exists");

            StringContent queryString = new(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(_url, queryString);
            response.EnsureSuccessStatusCode();
            Users.Add(JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync()));
        }
        public async Task<User> Get(string username, string password)
        {
            if (Users.Count == 0) await GetUsers();
            User first = Users.FirstOrDefault(x => x.Username.Equals(username));
            if (first == null) throw new Exception("User not found");
            if (!first.Password.Equals(password)) throw new Exception("Invalid password");
            return first;
        }
    }
}