using jwtTask.Models;

namespace jwtTask.Services
{
    public interface IUser
    {
        void Register(User user);
        User Login(Login user);
        List<User> GetUsers();
    }
    public class UserServices:IUser
    {
        List<User> users = new List<User>();
        public void Register(User  user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
        }

       public User Login(Login user)
        {
            var us=users.FirstOrDefault(x=>x.UserName==user.UserName && x.Password==user.Password);
            return us;
        }
        public List<User> GetUsers()
        {
            return users;
        }
    }
}
