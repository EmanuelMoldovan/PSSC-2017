using Core.Identity_and_access_layer.Models;
using Infrastructure.Exceptions;
using Infrastructure.Services;
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

        [SetUp]
        public void Init()
        {
            userService = new UserService();
        }

        [Test]
        [Category("UserManagementShouldPass")]
        [Description("Logging in with correct credentials should work.")]
        [TestCase("vladorbulescu10","Par0la01")]
        public void LoggingInRightCredentialsShouldPass(String u, String p)
        {
            User user = userService.Login(u, p);
            Assert.AreNotEqual(user, null);
        }

        [Test]
        [Category("UserManagementShouldFail")]
        [Description("Logging in with wrong credentials should not work.")]
        [TestCase("asdasda","fsdgdsfsd")]
        public void LoggingInWrongCredentialsNotPass(String u, String p)
        {
            Assert.Throws<WrongCredentialsException>(() => userService.Login(u,p));
        }
    }
}
