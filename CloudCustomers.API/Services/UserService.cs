using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services
{
    public class UserService : IUserService
    {
        public UserService()
        {

        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Name = "Gerard",
                    Email = "Gerard@email.com",
                    Address = new Address()
                    {
                        Street = "Street 1",
                        City = "City 1",
                        PostalCode = "PostalCode 1"
                    }
                },
                new User()
                {
                    Id = 2,
                    Name = "John",
                    Email = "John@email.com",
                    Address = new Address()
                    {
                        Street = "Street 2",
                        City = "City 2",
                        PostalCode = "PostalCode 2"
                    }
                }
            };

            return users;
        }
    }

    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
    }
}
