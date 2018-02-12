using Avatar.Domain.Commands.UserCommands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools;

namespace Avatar.Tests.User.CommandTests
{
    [TestClass]
    public class CreateUserCommandTests
    {
        [TestMethod]
        [TestCategory("User - Command Create")]
        public void IsValid()
        {
           
            var userName = "testuser";
            var email = "test@domain.com";
                        
            var createUserCommand = new CreateUserCommand(userName, email);

            Assert.AreEqual(false, createUserCommand.HasNotifications());
        }

        [TestMethod]
        [TestCategory("User - Command Create")]
        public void IsInvalidWhenNameIsNull()
        {

            string userName = null;
            var email = "test@domain.com";

            var createUserCommand = new CreateUserCommand(userName, email);
            foreach (var notification in createUserCommand.Notifications)
            {
                Assert.AreEqual("Empty User Name", notification.Key);
            }
        }

        [TestMethod]
        [TestCategory("User - Command Create")]
        public void IsInvalidWhenNameIsEmpty()
        {

            string userName = "";
            var email = "test@domain.com";

            var createUserCommand = new CreateUserCommand(userName, email);

            foreach (var notification in createUserCommand.Notifications)
            {
                Assert.AreEqual("Empty User Name", notification.Key);
            }
        }

        [TestMethod]
        [TestCategory("User - Command Create")]
        public void IsInvalidWhenEmailIsNull()
        {

            string userName = "joao";
            string email = null;

            var createUserCommand = new CreateUserCommand(userName, email);

            foreach (var notification in createUserCommand.Notifications)
            {
                Assert.AreEqual("Empty Email", notification.Key);
            }
        }

        [TestMethod]
        [TestCategory("User - Command Create")]
        public void IsInvalidWhenEmailIsEmpty()
        {

            string userName = "joao";
            string email = null;

            var createUserCommand = new CreateUserCommand(userName, email);

            foreach (var notification in createUserCommand.Notifications)
            {
                Assert.AreEqual("Empty Email", notification.Key);
            }
        }

    }
}
