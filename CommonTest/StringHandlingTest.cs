using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class StringHandlingTest
    {
        [TestMethod]
        public void InsertSpaceTest()
        {
            var source = "KlockiLego";
            var expected = "Klocki Lego";

            var stringHandling = new StringHandling();

            var actual = stringHandling.InertSpace(source);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void InsertSpaceWithSpaceTest()
        {
            var source = "Klocki Lego";
            var expected = "Klocki Lego";

            var stringHandling = new StringHandling();

            var actual = stringHandling.InertSpace(source);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void InsertSpaceTestWithNullValue()
        {
                      
            var stringHandling = new StringHandling();

            var actual = stringHandling.InertSpace(null);
           
        }

       
        // Todo - dokończyć test
        [TestMethod]
        public void InsertSpaceTestOnlyBigLetters()
        {
            var source = "KLOCKILEGO";
            var expected = "KLOCKILEGO";

            var stringHandling = new StringHandling();

            var actual = stringHandling.InertSpace(source);

            //Assert.AreEqual(expected, actual);
        }
    }
}
