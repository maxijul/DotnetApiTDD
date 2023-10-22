using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UserFixture
    {
        public static List<User> GetTestUsers()
        {
            var users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Name = "John",
                    Email = "john@email.com",
                    Address = new Address()
                    {
                        Street = "Street 1",
                        City = "City 1",
                        PostalCode = "Postal Code 1",
                    }
                },
                new User()
                {
                    Id = 2,
                    Name = "Jane",
                    Email = "jane@email.com",
                    Address = new Address()
                    {
                        Street = "Street 2",
                        City = "City 2",
                        PostalCode = "Postal Code 2",
                    }
                },
                new User()
                {
                    Id = 3,
                    Name = "Jack",
                    Email = "jack@email.com",
                    Address = new Address()
                    {
                        Street = "Street 3",
                        City = "City 3",
                        PostalCode = "Postal Code 3",
                    }
                },
            };

            return users;
        }
    }
}
