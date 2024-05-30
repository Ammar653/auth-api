using AuthApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace AuthApi.Repositories
{
    public static class UserRepository
    {
        public static List<User> Users = new List<User>
        {
            new User { Username = "user1", Password = "password1", Role = "player", Region = "b_game" },
            new User { Username = "admin", Password = "password2", Role = "admin", Region = "vip_chararacter_personalize" }
        };

        public static User ValidateUser(string username, string password)
        {
            return Users.SingleOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}