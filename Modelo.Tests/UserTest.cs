using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo.Domain.Entities;
using Modelo.Service.Services;

namespace Modelo.Tests
{
    [TestClass]
    public class UserTest
    {
        private readonly UserValidator _userValidator;
        private readonly string _name;
        private readonly string _birthDate;
        private readonly string _cpf;

        public UserTest()
        {
            _userValidator = new UserValidator();

            _name = "test";
            _birthDate = "16/03/2019";
            _cpf = "000.000.000-00";
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCpfIsInvalid()
        {
            var user = new User();
            user.Name = _name;
            user.Cpf = _cpf;
            user.BirthDate = _birthDate;

            bool result = _userValidator.Validate(user).IsValid;

            Assert.IsTrue(result);
        }
    }
}
