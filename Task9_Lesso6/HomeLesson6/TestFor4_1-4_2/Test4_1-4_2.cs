using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeTask4;
namespace HomeLesson6
{
    [TestClass]
    public class Test4{

        /*
         * TEst clone for TriangleModForHome6.cs
         */
        [TestMethod]
        public void TestClone()
        {
            ITriangle test = new TriangleModForHome6(5);
            ITriangle conedClass = (TriangleModForHome6)test.Clone();
            Assert.IsTrue(test.Equals(conedClass));
            Assert.IsFalse(test == conedClass);
        }
        /*
         * Test Equals For TriangleModForHome6.cs
         */
        [TestMethod]
        public void TestEquals()
        {
            ITriangle test = new TriangleModForHome6(5);
            ITriangle test2 = new TriangleModForHome6(5);
            Assert.IsTrue(test.Equals(test2));
            Assert.IsFalse(test.Equals(new TriangleModForHome6(6)));
        }
        /*
         * Test operator For TriangleModForHome6.cs
         */
        [TestMethod]
        public void TestOperator()
        {
            Assert.IsTrue((new TriangleModForHome6(5) > (new TriangleModForHome6(3))));
            Assert.IsFalse((new TriangleModForHome6(5) < (new TriangleModForHome6(3))));
            TriangleModForHome6 test = new TriangleModForHome6(5);
            TriangleModForHome6 test2 = new TriangleModForHome6(5);
            if ((test2 + test).circlePerimeterBox == test.circlePerimeterBox) { Assert.Fail(); }
            /*...*/
        }
        /*
         * Test comparator For TriangleModForHome6.cs
         */
        [TestMethod]
        public void TestComparator()
        {
            ITriangle test = new TriangleModForHome6(5);
            ITriangle test2 = new TriangleModForHome6(5);
            if (test.CompareTo(test2) != 0) { Assert.Fail(); }
            if (test.CompareTo(new TriangleModForHome6(10)) < 0) { Assert.Fail(); }
            if ((new TriangleModForHome6(3)).CompareTo(test2) < 0) { Assert.Fail(); }
        }
        /*
         * Test MyExeptioClass.class For TriangleModForHome6.cs
         */
        [TestMethod, ExpectedException(typeof(MyExeptioClass))]
        public void TestExeption()
        {
            TriangleModForHome6 forTest;
            TriangleModForHome6 triangle1 = new TriangleModForHome6(10);
            TriangleModForHome6 triangle2 = new TriangleModForHome6(0);
            forTest = triangle1 * triangle2;
            Coordinates.getPerimetr(0);
            Coordinates.getPerimetr(1, 5, -10, 6);
         }
        /*
        * Test Exeptio(DivideByZeroException) For TriangleModForHome6.cs
        */
        [TestMethod, ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZeroException()
        {
            TriangleModForHome6 triangle1 = new TriangleModForHome6(10);
            TriangleModForHome6 triangle2 = new TriangleModForHome6(0);
            int resultTest = triangle1 / triangle2;
        }

        /* Testing Sqvere AND Perimetr ...it*s did not necessary
         * They did not have hard logic, all formulas are standard
         */




    }
}
