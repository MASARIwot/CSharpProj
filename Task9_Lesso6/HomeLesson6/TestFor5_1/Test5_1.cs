using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeTask7;


namespace HomeLesson6.TestFor5_1
{
    [TestClass]
    public class Test5_1
    {
        /*
         * Check phone information
         */
        [TestMethod]
        public void TestCheckPhone()
        {
            AdministratorList test = new AdministratorList();
            Assert.IsFalse(test.checkPhone("75854125155415O"));
            Assert.IsFalse(test.checkPhone("dfdfefew155415"));
            Assert.IsFalse(test.checkPhone("380093tyyg2474"));
            Assert.IsTrue(test.checkPhone("0937027294"));
            Assert.IsTrue(test.checkPhone("380937027294"));
        }
        /*
         * Check Pasport Information
         */
        [TestMethod]
        public void TestCheckPasport()
        {
            AdministratorList test = new AdministratorList();
            Assert.IsFalse(test.checkPasport("AY654585"));
            Assert.IsFalse(test.checkPasport("AY 654585"));
            Assert.IsFalse(test.checkPasport("AA6fg54585"));
            Assert.IsFalse(test.checkPasport("AA6fg5458556"));
            Assert.IsFalse(test.checkPasport("AA65434585"));
            Assert.IsTrue(test.checkPasport("AA654585"));
            Assert.IsTrue(test.checkPasport("AA 654585"));
        }
        /*
         * Check Exeption
         */
        [TestMethod, ExpectedException(typeof(HomeTask7.HomeTaskLogic.MyExeptioClass))]
        public void TestPersoneWithChecking()
        {
            AdministratorList test = new AdministratorList();
            test.addPersoneWithChecking("AAA", "RSR1", new DateTime(2005, 4, 10, 7, 30, 0), "9374444s454", "email.com", "AA 654585", "66554477889955669966", DateTime.Now);
            test.addPersoneWithChecking("ffAAA", "RSfR1", new DateTime(2005, 4, 10, 7, 30, 0), "9374444454", "email.com", "AAt654585", "66554477889955669966", DateTime.Now);
        }
        /*Equals and CompareTo was tested before(TestFor4_1-4_2.cs)*/

    }
}
