using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No1.Solution.Tests.ForTests;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        private PasswordCheckerService checker;

        [Test]
        public void InsertNumber_SetNullPassword_ThrowException()
        {
            checker = new PasswordCheckerService(new SqlRepository());
            Assert.Throws<ArgumentNullException>(() => checker.CreateRepository(null));
        }

        [Test]
        public void InsertNumber_SetEmptyPassword_ThrowException()
        {
            checker = new PasswordCheckerService(new SqlRepository());
            Assert.Throws<ArgumentException>(() => checker.CreateRepository(string.Empty));
        }

        [Test]
        public void VerifyPassword_SetNumbersInPassword_ReturnFalseAndHasntLetters()
        {
            string password = "12345678";
            var expectedResult = (false, "Password isn't valid");
            checker = new PasswordCheckerService(new SqlRepository());
            var result = checker.CreateRepository(password, new VerifierForContains());
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void VerifyPassword_SetLettersInPassword_ReturnFalseAndHasntDigits()
        {
            string password = "abcasdfg";
            var expectedResult = (false, "Password isn't valid");
            checker = new PasswordCheckerService(new SqlRepository());
            var result = checker.CreateRepository(password, new VerifierForContains());
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void VerifyPassword_Set17LettersInPasswordAndOtherRepository_ReturnFalseAndLengthTooLong ()
        {
            string password = "abcdefghijklmnopr";
            var expectedResult = (false, "Password isn't valid");
            checker = new PasswordCheckerService(new RepositoryNoThree());
            var result = checker.CreateRepository(password, new VerifierForLength());
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void VerifyPassword_SetTruePassword_ReturnExpectedResult()
        {
            string password = "abcdefghijklmnopr";
            var expectedResult = (false, "Password isn't valid");
            checker = new PasswordCheckerService(new RepositoryNoThree());
            var result = checker.CreateRepository(password, new VerifierForLength(), new VerifierForContains());
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void VerifyPassword_SetTooShortPasswordAndOtherRepository_ReturnExpectedResult()
        {
            string password = "asdfs";
            var expectedResult = (false, "Password isn't valid");
            checker = new PasswordCheckerService(new RepositoryNoTwo());
            var result = checker.CreateRepository(password, new VerifierForLength());
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void VerifyPassword_SetValidPasswordAndOtherRepository_ReturnExpectedResult()
        {
            string password = "asdfs111111";
            var expectedResult = (true, "Password is Ok. User was created");
            checker = new PasswordCheckerService(new RepositoryNoTwo());
            var result = checker.CreateRepository(password, new VerifierForContains());
            Assert.AreEqual(expectedResult, result);
        }
    }
}
