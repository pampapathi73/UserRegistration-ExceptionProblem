using NUnit.Framework;
using System;
using UserRegistrationExceptionProblem;

namespace TestProject1
{
    public class Tests
    {
        readonly Patterns patternsMatch = new Patterns();

        [Test]
        public void GivenFirstName_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, patternsMatch.ValidateFirstName(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid FirstName", e.Message);
            }
        }
        [Test]
        public void GivenLastName_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, patternsMatch.ValidateLastName(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid LastName", e.Message);
            }
        }
        [Test]
        public void GivenEmailID_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, patternsMatch.ValidateEmailId(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid Email ID", e.Message);
            }
        }
        [Test]
        public void GivenMobileNumber_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, patternsMatch.ValidateMobileNumber(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid Mobile Number", e.Message);
            }
        }
        [Test]
        public void GivenPassword_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, patternsMatch.ValidatePassword(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid Password", e.Message);
            }
        }
    }
}