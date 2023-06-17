
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using RJP.Controllers;
using Core.Interface;
using Core.Model;
namespace MyProject.Tests
{
    [TestFixture]
    public class AccountControllerTests
    {
        private readonly Mock<IAccountRepository> _accountRepositoryMock = new Mock<IAccountRepository>();
        private readonly Mock<ILogger<AccountController>> _loggerMock = new Mock<ILogger<AccountController>>();

        private AccountController _accountController;

        [SetUp]
        public void SetUp()
        {
            _accountController = new AccountController(_loggerMock.Object, _accountRepositoryMock.Object);
        }

        [Test]
        public void Save_ReturnsSavedAccount()
        {
            // Arrange
            var accountModel = new AccountModel { CustomerId=1,Balance=12};
            _accountRepositoryMock.Setup(x => x.Add(accountModel)).Returns(accountModel);

            // Act
            var result = _accountController.Save(accountModel);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(accountModel.Balance, result.Balance);
            Assert.AreEqual(accountModel.AccountId, result.AccountId);
            _accountRepositoryMock.Verify(x => x.Add(accountModel), Times.Once);
        }
    }

}
