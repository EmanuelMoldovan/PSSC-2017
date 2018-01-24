using Application.Services;
using Core.Identity_and_access_layer.Models;
using Core.Persons_layer.Models;
using Infrastructure.Exceptions;
using Infrastructure.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    class IdentityAccessTests
    {
        UserService userService;
        Mock<IDataValidation> mockDataValidation;

        [SetUp]
        public void Init()
        {
            mockDataValidation = new Mock<IDataValidation>();
            userService = new UserService(mockDataValidation.Object);
        }

        [Test]
        [Category("UserManagementShouldPass")]
        [Description("Logging in with correct credentials should work.")]
        [TestCase("vladorbulescu10", "Par0la01")]
        public void LoggingInRightCredentialsShouldPass(String u, String p)
        {
            User user = userService.Login(u, p);
            Assert.AreNotEqual(user, null);
        }

        [Test]
        [Category("UserManagementShouldFail")]
        [Description("Logging in with wrong credentials should not work.")]
        [TestCase("asdasda", "fsdgdsfsd")]
        public void LoggingInWrongCredentialsNotPass(String u, String p)
        {
            Assert.Throws<WrongCredentialsException>(() => userService.Login(u, p));
        }

        [Test]
        [Category("UserManagementShouldPass")]
        [Description("Registering a new user should add a new user, verify if it is added, then delete it." +
            "from both users and persons storage should work.")]
        [TestCase("testuser", "Testpass1", "test@email.com", "test", "test", null, 22)]
        public void RegisterNewUserShouldPass(String username, String pass, String email, String nume, String prenume,
            Adresa a, int varsta)
        {
            User user = userService.Register(username, pass, email, nume, prenume, a, varsta);
            Assert.AreNotEqual(user, null);
            Assert.AreEqual(userService.RemoveUser(user.UserId), true);
        }

        [Test]
        [Category("UserManagementShouldNotPass")]
        [Description("I can not create a user with a short password")]
        [TestCase("testuser", "abc", "test@email.com", "test", "test", null, 22)]
        public void RegisterAUserWithShortPasswordShouldFail(String username, String pass, String email, String nume, String prenume,
            Adresa a, int varsta)
        {
            Assert.Throws<PasswordTooShortException>(() => userService.Register(username, pass, email, nume, prenume, a, varsta));
        }

        [Test]
        [Category("UserManagementShouldNotPass")]
        [Description("I can not create a user with a long password")]
        [TestCase("testuser", "abcdefghijklmnopq", "test@email.com", "test", "test", null, 22)]
        public void RegisterAUserWithLongPasswordShouldFail(String username, String pass, String email, String nume, String prenume,
            Adresa a, int varsta)
        {
            Assert.Throws<PasswordTooLongException>(() => userService.Register(username, pass, email, nume, prenume, a, varsta));
        }

        [Test]
        [Category("UserManagementShouldNotPass")]
        [Description("I can not create a user without the required chars.")]
        [TestCase("testuser", "abcdefg", "test@email.com", "test", "test", null, 22)]
        public void RegisterAUserWithWrongCharsPasswordShouldFail(String username, String pass, String email, String nume, String prenume,
            Adresa a, int varsta)
        {
            Assert.Throws<PasswordCharsNotMetException>(() => userService.Register(username, pass, email, nume, prenume, a, varsta));
        }

        [Test]
        [Category("UserManagementShouldNotPass")]
        [Description("Creating a user with an existing username should not work.")]
        [TestCase("vladorbulescu10", "Par0la", "test@email.com", "test", "test", null, 22)]
        public void RegisterAUserWithUsernameExistingShouldFail(String username, String pass, String email, String nume, String prenume,
            Adresa a, int varsta)
        {
            Assert.AreEqual(userService.Register(username, pass, email, nume, prenume, a, varsta), null);
        }
    }
}
