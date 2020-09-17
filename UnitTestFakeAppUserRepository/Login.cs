using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P3_Code;

namespace UnitTestFakeAppUserRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginWithCorrectCredentialsSuccessful()
        {
            // Arrange
            const string USER_NAME = "Naluca";
            const string PASSWORD = "password";
            FakeAppUserRepository UsrRepository = new FakeAppUserRepository();

            // Act
            bool result = UsrRepository.Login(USER_NAME, PASSWORD);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LoginWithIncorrectCredentialsFail()
        {
            // Arrange
            const string USER_NAME = "Test";
            const string PASSWORD = "Case";
            FakeAppUserRepository UsrRepository = new FakeAppUserRepository();

            // Act
            bool result = UsrRepository.Login(USER_NAME, PASSWORD);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
