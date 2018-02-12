using Avatar.Domain.Commands.UserCommands;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Services.UserServices;
using Avatar.Infra.Data.Repository.Context;
using Avatar.Infra.Data.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Avatar.Tests.User.ServiceTests
{
    [TestClass]
    public class CreateUserServiceTests
    {

        [TestMethod]
        [TestCategory("User - Service Create")]
        public void EmailIsValid()
        {
            CreateUserService createUserService;
            var createUserCommand = new CreateUserCommand("teste", "newemail@teste.com");

            var options = new DbContextOptionsBuilder<AvatarContext>()
                .UseInMemoryDatabase(databaseName: "Email valid to create new user")
                .Options;


            using (var context = new AvatarContext(options))
            {
                var userRepository = new UserRepository(context);

                //Act
                createUserService = new CreateUserService(createUserCommand, userRepository);
            }            

            Assert.IsFalse(createUserCommand.HasNotifications());            
        }


        [TestMethod]
        [TestCategory("User - Service Create")]
        public void EmailAlreadyExists()
        {
            CreateUserService createUserService;

            var createUserCommand = new CreateUserCommand("john", "john@test.com");

            var user = new Avatar.Domain.Entities.User("John K.", "john@test.com");

            var options = new DbContextOptionsBuilder<AvatarContext>()
                .UseInMemoryDatabase(databaseName: "Email is not valid")
                .Options;

            using (var context = new AvatarContext(options))
            {
                context.User.Add(user);
                context.SaveChanges();
            }

            using (var context = new AvatarContext(options))
            {
                var userRepository = new UserRepository(context);

                //Act
                createUserService = new CreateUserService(createUserCommand, userRepository);
            }

            //Assert
            Assert.IsTrue(createUserService.HasNotifications());
        }
    }
}
