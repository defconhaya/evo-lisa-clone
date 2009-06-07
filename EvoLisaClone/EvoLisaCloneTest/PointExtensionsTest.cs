﻿using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for PointExtensionsTest and is intended
    ///to contain all PointExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PointExtensionsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AreColinear
        ///</summary>
        [TestMethod()]
        public void AreColinearTest1()
        {
            Point[] points = null;
            bool expected = true;
            bool actual;
            actual = PointExtensions.AreColinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreColinear
        ///</summary>
        [TestMethod()]
        public void AreColinearTest2()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(1, 1), new Point(1, 2) };
            bool expected = false;
            bool actual;
            actual = PointExtensions.AreColinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreColinear
        ///</summary>
        [TestMethod()]
        public void AreColinearTest3()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(1, 1), new Point(2, 2) };
            bool expected = true;
            bool actual;
            actual = PointExtensions.AreColinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreColinear
        ///</summary>
        [TestMethod()]
        public void AreColinearTest4()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(1, 0), new Point(0, 1) };
            bool expected = false;
            bool actual;
            actual = PointExtensions.AreColinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreColinear
        ///</summary>
        [TestMethod()]
        public void AreColinearTest5()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(0, 1), new Point(1, 0) };
            bool expected = false;
            bool actual;
            actual = PointExtensions.AreColinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreColinear
        ///</summary>
        [TestMethod()]
        public void AreColinearTest6()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(1, 0), new Point(2, 0) };
            bool expected = true;
            bool actual;
            actual = PointExtensions.AreColinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreColinear
        ///</summary>
        [TestMethod()]
        public void AreColinearTest7()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(0, 1), new Point(0, 2) };
            bool expected = true;
            bool actual;
            actual = PointExtensions.AreColinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreColinear
        ///</summary>
        [TestMethod()]
        public void AreColinearTest8()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(1, 3) };
            bool expected = false;
            bool actual;
            actual = PointExtensions.AreColinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreColinear
        ///</summary>
        [TestMethod()]
        public void AreColinearTest9()
        {
            Point[] points = new Point[0] {};
            bool expected = true;
            bool actual;
            actual = PointExtensions.AreColinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreColinear
        ///</summary>
        [TestMethod()]
        public void AreColinearTest10()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(3, 4), new Point(1, 1) };
            bool expected = false;
            bool actual;
            actual = PointExtensions.AreColinear(points);
            Assert.AreEqual(expected, actual);
        }
    }
}