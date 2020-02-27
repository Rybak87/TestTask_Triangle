using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangles;

namespace UnitTestTriangle
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AcuteTriangle()
        {
            Assert.AreEqual(KindTriangle.Acute, Triangle.GetKindTriangle(1, 2, 2));
        }

        [TestMethod]
        public void RightTriangle()
        {
            Assert.AreEqual(KindTriangle.Right, Triangle.GetKindTriangle(5, 3, 4));
        }

        [TestMethod]
        public void ObtuseTriangle()
        {
            Assert.AreEqual(KindTriangle.Obtuse, Triangle.GetKindTriangle(3, 6, 4));
        }

        [TestMethod]
        public void ImpossibleTriangle()
        {
            Assert.ThrowsException<Exception>(() => Triangle.GetKindTriangle(3, 6, 3));
        }

        [TestMethod]
        public void ImpossibleTriangleNegativeSide()
        {
            Assert.ThrowsException<Exception>(() => Triangle.GetKindTriangle(-1, -1, -1));
        }
    }
}
