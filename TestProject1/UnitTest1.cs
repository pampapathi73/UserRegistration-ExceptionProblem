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
    }
}