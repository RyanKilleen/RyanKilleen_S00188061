using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RyanKilleen_S00188061;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckPrice_Increase()
        {
            //Arrange
            Phone p1 = new Phone();
            int expectedPrice = 550;

            //Act
            p1.IncreasePrice(50);

            //Assert
            Assert.Equals(expectedPrice, p1.Price);
        }
    }
}
