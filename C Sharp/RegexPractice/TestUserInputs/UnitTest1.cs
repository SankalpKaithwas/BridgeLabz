using NUnit.Framework;
using RegexPractice;
using System;

namespace TestUserInputs
{
    public class Tests
    {
        RegEX regEX;
        [SetUp]
        public void Setup()
        {
            regEX = new RegEX();
        }

        [TestCase("Sankalp")]
        public void FirstName(string firsName)
        {
            var result = false;
            try
            {
                result = regEX.CheckFirst(firsName);
            }
            catch (Exception)
            {
                Assert.AreEqual(true, result);
            }
        }
        [TestCase("Kaithwas")]
        public void LastName(string lastName)
        {
            var result = false;
            try
            {
                result = regEX.CheckLast(lastName);
            }
            catch (Exception)
            {
                Assert.AreEqual(true, result);

            }
        }

        [TestCase("Sankalp kaithwas lives in india")]
        public void Address(string address)
        {
            var result = false;
            try
            {
                result = regEX.CheckAddress(address);
            }
            catch (Exception)
            {
                Assert.AreEqual(true, result);
            }
        }

        [TestCase("sankalp.123@gmail.com")]
        [TestCase("sankalp.123mail.com")]
        public void Email(string email)
        {
            var result = false;
            try
            {
                result = regEX.CheckEmail(email);
            }
            catch (Exception)
            {
                Assert.AreEqual(true, result);
            }
        }
    }
}