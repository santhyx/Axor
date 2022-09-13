using Domain.Types;

namespace Domain.Models
{
    public sealed class User : Entity
    {
        public string? NickName { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Salt { get; private set; }
        public string Email { get; private set; }


        private User(Guid id)
        {
            Id = id;
        }

        protected User()
        {
           
        }
        

        public static User GetRelational(Guid id) => new(id);
    }
}
