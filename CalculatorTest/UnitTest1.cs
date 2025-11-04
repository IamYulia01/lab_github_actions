using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTestAssert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sumMass_massTesting_11()
        {
            int[] massTest1 = new int[] { 5, 6, 84, 2, 7, 9 };
            int first = 1;
            int second = 2;
            int excepted = 11;
            
            CMass massTesting = new CMass(massTest1);
            int rezult = CMass.sumMass(first, second, massTesting);

            MsTestAssert.AreEqual(excepted, rezult);
        }
        [TestMethod]
        public void sumMass_massTesting_86()
        {
            int[] massTest1 = new int[] { 5, 6, 84, 2, 7, 9 };
            int first = 3;
            int second = 4;
            int excepted = 86;

            CMass massTesting = new CMass(massTest1);
            int rezult = CMass.sumMass(first, second, massTesting);

            MsTestAssert.AreEqual(excepted, rezult);
        }
        [TestMethod]
        public void sumMass_massTesting_113()
        {
            int[] massTest1 = new int[] { 5, 6, 84, 2, 7, 9 };
            int excepted = 113;

            CMass massTesting = new CMass(massTest1);
            int first = 1;
            int second = massTesting.getLenghMass;
            int rezult = CMass.sumMass(first, second, massTesting);

            MsTestAssert.AreEqual(excepted, rezult);
        }
        [TestMethod]
        public void sumMass_massTesting_99()
        {
            int[] massTest1 = new int[] { 5, 6, 84, 2, 7, 9 };
            int first = 2;
            int second = 5;
            int excepted = 99;

            CMass massTesting = new CMass(massTest1);
            int rezult = CMass.sumMass(first, second, massTesting);

            MsTestAssert.AreEqual(excepted, rezult);
        }
        [TestMethod]
        public void sumMass_massTesting_6()
        {
            int[] massTest1 = new int[] { 5, 6, 84, 2, 7, 9 };
            int first = 2;
            int second = 2;
            int excepted = 6;

            CMass massTesting = new CMass(massTest1);
            int rezult = CMass.sumMass(first, second, massTesting);

            MsTestAssert.AreEqual(excepted, rezult);
        }
        [TestMethod]
        public void sumMass_massTesting_0()
        {
            int[] massTest1 = new int[] { 5, 6, 84, 2, 7, 9 };
            int first = 6;
            int second = 1;
            int excepted = 0;

            CMass massTesting = new CMass(massTest1);
            int rezult = CMass.sumMass(first, second, massTesting);

            MsTestAssert.AreEqual(excepted, rezult);
        }

    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Sum_massTesting_6()
        {
            int[] massTest1 = new int[] { 5, -6, -84, -2, 7, 9 };
            int excepted = -92;

            CMass massTesting = new CMass(massTest1);
            int rezult = CMass.Sum(massTesting);

            MsTestAssert.AreEqual(excepted, rezult);
        }
        [TestMethod]
        public void Sum_massTesting0_0()
        {
            int excepted = 0;

            CMass massTesting = new CMass(0);
            int rezult = CMass.Sum(massTesting);

            MsTestAssert.AreEqual(excepted, rezult);
        }
        [TestMethod]
        public void Sum_massTesting_0()
        {
            int[] massTest1 = new int[] { 5, 6, 84, 2, 7, 9 };
            int excepted = 0;

            CMass massTesting = new CMass(massTest1);
            int rezult = CMass.Sum(massTesting);

            MsTestAssert.AreEqual(excepted, rezult);
        }
        [TestMethod]

        public void Sum_massTesting_massTesting1_90()
        {
            int[] massTest1 = new int[] { 5, 6, -84, 2, 7, 9 };
            int[] massTest2 = new int[] { 5, -6, 84, 2, 7, 9 };
            int excepted = -90;

            CMass massTesting = new CMass(massTest1);
            CMass massTesting1 = new CMass(massTest2);

            int rezult = CMass.Sum(massTesting, massTesting1);

            MsTestAssert.AreEqual(excepted, rezult);
        }
        [TestMethod]

        public void Sum_0()
        {
            int excepted = 0;

            int rezult = CMass.Sum();

            MsTestAssert.AreEqual(excepted, rezult);
        }

    }
}