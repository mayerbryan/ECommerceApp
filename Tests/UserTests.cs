using Xunit;
using Domain;

namespace Tests
{
    public class UserTests
    {
        [Fact]
        public void User_ShouldCreateUser()
        {
            // Arrange
            var user = new User
            {
                Id = 1,
                FirstName = "First",
                LastName = "Last",
                Email = "test@example.com"
            };

            // Act
            var createdUser = new User
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };

            // Assert
            Assert.NotNull(createdUser);
            Assert.Equal(user.Id, createdUser.Id);
            Assert.Equal(user.FirstName, createdUser.FirstName);
            Assert.Equal(user.LastName, createdUser.LastName);
            Assert.Equal(user.Email, createdUser.Email);
        }
    }
}
