
using API.Core;

namespace API.Entities
{
    public class User : Entity
    {
        public string FullName { get; private set; } = string.Empty;
        public string UserName { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string Password { get; private set; } = string.Empty;

        private User() { }

        private User(string fullName, string userName, string email, string password) : base(Guid.NewGuid())
        {
            FullName = fullName;
            UserName = userName;
            Email = email;
            Password = password;
        }

        public static User Create(string fullName, string userName, string email, string password)
        {
            var user = new User(fullName, userName, email, password);
            if(user is User)
            {
                return user;
            }
            throw new ArgumentNullException();
        }

        public void ChangeFullName(string fullName)
        {
            if(fullName is null)
            {
                throw new ArgumentNullException();
            }
            FullName = fullName;
        }

        public void ChangeUserName(string userName)
        {
            if (userName is null)
            {
                throw new ArgumentNullException();
            }
            UserName = userName;
        }

        public void ChangeEmail(string email)
        {
            if (email is null)
            {
                throw new ArgumentNullException();
            }
            Email = email;
        }

        public void ChangePassword(string password)
        {
            if (password is null)
            {
                throw new ArgumentNullException();
            }
            Password = password;
        }
    }
}
