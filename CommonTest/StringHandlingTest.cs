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

            var actual = StringHandling.InsertSpace(source);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void InsertSpaceWithSpaceTest()
        {
            var source = "Klocki Lego";
            var expected = "Klocki Lego";

            var actual = StringHandling.InsertSpace(source);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void InsertSpaceTestWithSourceIsEmptyString()
        {
            var source = "";
            var actual = StringHandling.InsertSpace(source);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void InsertSpaceTestWithNullValue()
        {

            var actual = StringHandling.InsertSpace(null);

        }

       
        // Todo - dokończyć test
        [TestMethod]
        public void InsertSpaceTestOnlyBigLetters()
        {
            var source = "KLOCKILEGO";
            var expected = "KLOCKILEGO";

            var actual = StringHandling.InsertSpace(source);

            //Assert.AreEqual(expected, actual);
        }
    }
}
