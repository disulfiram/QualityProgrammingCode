using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotatingWalkInMatrix;

namespace RotatingWalkInMatrixTests
{
    [TestClass]
    public class ChangeDirectionTests
    {
        [TestMethod]
        [Timeout(100)]
        [DeploymentItem("RotatingWalkInMatrix.exe")]
        public void CheckDirectionTest_BottomRightFalse()
        {
            int dRow = 1;
            int dColumn = 1;

            PrivateType pt = new PrivateType(typeof(WalkInMatrix));
            pt.InvokeStatic("ChangeDirection", new object[] { dRow, dColumn,  dRow,  dColumn });

            int expectedRow = 1;
            int expectedColumn = 0;

            Assert.AreEqual(dRow, expectedRow);
            Assert.AreEqual(dColumn, expectedColumn);
        }
    }
}