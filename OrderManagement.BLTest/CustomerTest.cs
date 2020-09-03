using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement.BL;

namespace OrderManagement.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FirstNameAndLastNameTest()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Jan";
            customer.LastName = "Kowalski";

            string expectedValue = "Jan Kowalski";

            //Act
            string actualValue = customer.FirstNameAndLastName;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void FirstNameAndLastNameTestSurnameIsNull()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "Kowalski";

            string expectedValue = "Kowalski";

            //Act
            string actualValue = customer.FirstNameAndLastName;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void FirstNameAndLastNameTestNameIsNull()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Jan";

            string expectedValue = "Jan";

            //Act
            string actualValue = customer.FirstNameAndLastName;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void staticTest()
        {
            //Arrange
            Customer customer1 = new Customer();
            customer1.FirstName = "Jan";
            Customer.Count += 1;

            Customer customer2 = new Customer();
            customer2.FirstName = "Tomek";
            Customer.Count += 1;

            Customer customer3 = new Customer();
            customer3.FirstName = "Jacek";
            Customer.Count += 1;


            Assert.AreEqual(3, Customer.Count);
        }

        [TestMethod]
        public void ValidateMethodTestCorrectValue()
        {
            Customer customer = new Customer();
            customer.LastName = "Nowak";
            customer.EmailAddress = "Jan@o2.pl";

            var expected = true;
            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidateMethodTestNoCorrectValueMissingEmail()
        {
            Customer customer = new Customer();
            customer.LastName = "Nowak";
            customer.FirstName = "Marek";

            var expected = false;
            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);

        }





        //[TestMethod]
        //public void FirstNameAndLastNameTestNameAndSurnameIsNull()
        //{
        //    //Arrange
        //    Customer customer = new Customer();

        //    //Act
        //    string actualValue = customer.FirstNameAndLastName;

        //    //Assert
        //    Assert.ThrowsException<ArgumentNullException>(()=> actualValue);
        //}

    }
}

