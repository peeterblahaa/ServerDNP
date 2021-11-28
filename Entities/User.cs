using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class User
    { [Key]
        public string Username { get; set; }
        public string City { get; set; }
        public string Sex { get; set; }
        public string Password { get; set; }
        public bool IsRegistered { get; set; }
        
        public User(string username,string city ,string sex, string password, bool isRegistered)
        {
            Username = username;
            City = city;
            Sex = sex;
            Password = password;
            IsRegistered = isRegistered;

        }

        public User()
        {
           
        }
    }
}