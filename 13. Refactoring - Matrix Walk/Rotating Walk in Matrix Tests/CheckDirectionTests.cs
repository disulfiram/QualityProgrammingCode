using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotatingWalkInMatrix;

namespace RotatingWalkInMatrixTests
{
    [TestClass]
    public class CheckDirectionTests
    {
        [TestMethod]
        [Timeout(100)]
        [DeploymentItem("RotatingWalkInMatrix.exe")]
        public void CheckDirectionTest_BottomRightFalse()
        {
            int[,] testMatrix =
            {
                { 1, 0, 0, 0, 0, 0 },
                { 0, 2, 0, 0, 0, 0 },
                { 0, 0, 3, 0, 0, 0 },
                { 0, 0, 0, 4, 0, 0 },
                { 0, 0, 0, 0, 5, 0 },
                { 0, 0, 0, 0, 0, 0 },
            };

            int currentRow = 5;
            int currentColumnt = 5;

            PrivateType pt = new PrivateType(typeof(WalkInMatrix));
            bool canContinue = ((bool)pt.InvokeStatic("CanContinue", new object[] { testMatrix, currentRow, currentColumnt }));

            Assert.IsTrue(canContinue);
        }

        [TestMethod]
        [Timeout(100)]
        [DeploymentItem("RotatingWalkInMatrix.exe")]
        public void CheckDirectionTest_BottomLeft()
        {
            int[,] testMatrix =
            {
                { 1, 0, 0, 0, 0, 0 },
                { 0, 2, 0, 0, 0, 0 },
                { 0, 0, 3, 0, 0, 0 },
                { 0, 0, 0, 4, 0, 0 },
                { 0, 0, 0, 0, 5, 0 },
                { 0, 10, 9, 8, 7, 6 },
            };

            int currentRow = 5;
            int currentColumnt = 0;

            PrivateType pt = new PrivateType(typeof(WalkInMatrix));
            bool canContinue = ((bool)pt.InvokeStatic("CanContinue", new object[] { testMatrix, currentRow, currentColumnt }));

            Assert.IsTrue(canContinue);
        }

        [TestMethod]
        [Timeout(100)]
        [DeploymentItem("RotatingWalkInMatrix.exe")]
        public void CheckDirectionTest_TopLeft()
        {
            int[,] testMatrix =
            {
                { 1, 0, 0, 0, 0, 0 },
                { 0, 2, 0, 0, 0, 0 },
                { 14, 0, 3, 0, 0, 0 },
                { 13, 0, 0, 4, 0, 0 },
                { 12, 0, 0, 0, 5, 0 },
                { 11, 10, 9, 8, 7, 6 },
            };

            int currentRow = 1;
            int currentColumnt = 0;

            PrivateType pt = new PrivateType(typeof(WalkInMatrix));
            bool canContinue = ((bool)pt.InvokeStatic("CanContinue", new object[] { testMatrix, currentRow, currentColumnt }));

            Assert.IsTrue(canContinue);
        }

        [TestMethod]
        [Timeout(100)]
        [DeploymentItem("RotatingWalkInMatrix.exe")]
        public void CheckDirectionTest_TopRight()
        {
            int[,] testMatrix =
            {
                { 1, 16, 17, 18, 19, 0 },
                { 15, 2, 0, 0, 0, 0 },
                { 14, 0, 3, 0, 0, 0 },
                { 13, 0, 0, 4, 0, 0 },
                { 12, 0, 0, 0, 5, 0 },
                { 11, 10, 9, 8, 7, 6 },
            };

            int currentRow = 0;
            int currentColumnt = 5;

            PrivateType pt = new PrivateType(typeof(WalkInMatrix));
            bool canContinue = ((bool)pt.InvokeStatic("CanContinue", new object[] { testMatrix, currentRow, currentColumnt }));

            Assert.IsTrue(canContinue);
        }

        [TestMethod]
        [Timeout(100)]
        [DeploymentItem("RotatingWalkInMatrix.exe")]
        public void CheckDirectionTest_BottomRightTriangle_LeftTriangle()
        {
            int[,] testMatrix =
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 0, 0, 0, 21 },
                { 14, 0, 3, 0, 0, 22 },
                { 13, 0, 0, 4, 0, 23 },
                { 12, 0, 0, 0, 5, 0 },
                { 11, 10, 9, 8, 7, 6 },
            };

            int currentRow = 4;
            int currentColumnt = 5;

            PrivateType pt = new PrivateType(typeof(WalkInMatrix));
            bool canContinue = ((bool)pt.InvokeStatic("CanContinue", new object[] { testMatrix, currentRow, currentColumnt }));

            Assert.IsTrue(canContinue);
        }

        [TestMethod]
        [Timeout(100)]
        [DeploymentItem("RotatingWalkInMatrix.exe")]
        public void CheckDirectionTest_TopLeft_LeftTriangle()
        {
            int[,] testMatrix =
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 0, 0, 0, 21 },
                { 14, 0, 3, 26, 0, 22 },
                { 13, 0, 0, 4, 25, 23 },
                { 12, 0, 0, 0, 5, 24 },
                { 11, 10, 9, 8, 7, 6 },
            };

            int currentRow = 1;
            int currentColumnt = 2;

            PrivateType pt = new PrivateType(typeof(WalkInMatrix));
            bool canContinue = ((bool)pt.InvokeStatic("CanContinue", new object[] { testMatrix, currentRow, currentColumnt }));

            Assert.IsTrue(canContinue);
        }

        [TestMethod]
        [Timeout(100)]
        [DeploymentItem("RotatingWalkInMatrix.exe")]
        public void CheckDirectionTest_TopRight_LeftTriangle()
        {
            int[,] testMatrix =
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 0, 21 },
                { 14, 0, 3, 26, 0, 22 },
                { 13, 0, 0, 4, 25, 23 },
                { 12, 0, 0, 0, 5, 24 },
                { 11, 10, 9, 8, 7, 6 },
            };

            int currentRow = 1;
            int currentColumnt = 4;

            PrivateType pt = new PrivateType(typeof(WalkInMatrix));
            bool canContinue = ((bool)pt.InvokeStatic("CanContinue", new object[] { testMatrix, currentRow, currentColumnt }));

            Assert.IsTrue(canContinue);
        }

        [TestMethod]
        [Timeout(100)]
        [DeploymentItem("RotatingWalkInMatrix.exe")]
        public void CheckDirectionTest_Final_LeftTriangle()
        {
            int[,] testMatrix =
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 0, 3, 26, 0, 22 },
                { 13, 0, 0, 4, 25, 23 },
                { 12, 0, 0, 0, 5, 24 },
                { 11, 10, 9, 8, 7, 6 },
            };

            int currentRow = 2;
            int currentColumnt = 4;

            PrivateType pt = new PrivateType(typeof(WalkInMatrix));
            bool canContinue = ((bool)pt.InvokeStatic("CanContinue", new object[] { testMatrix, currentRow, currentColumnt }));

            Assert.IsFalse(canContinue);
        }

        [TestMethod]
        [Timeout(100)]
        [DeploymentItem("RotatingWalkInMatrix.exe")]
        public void CheckDirectionTest_Start_RightTriangle()
        {
            int[,] testMatrix =
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 0, 32, 4, 25, 23 },
                { 12, 0, 0, 0, 5, 24 },
                { 11, 10, 9, 8, 7, 6 },
            };

            int currentRow = 4;
            int currentColumnt = 3;

            PrivateType pt = new PrivateType(typeof(WalkInMatrix));
            bool canContinue = ((bool)pt.InvokeStatic("CanContinue", new object[] { testMatrix, currentRow, currentColumnt }));

            Assert.IsTrue(canContinue);
        }

        [TestMethod]
        [Timeout(100)]
        [DeploymentItem("RotatingWalkInMatrix.exe")]
        public void CheckDirectionTest_BottomRight_RightTriangle()
        {
            int[,] testMatrix =
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 0, 32, 4, 25, 23 },
                { 12, 0, 34, 33, 5, 24 },
                { 11, 10, 9, 8, 7, 6 },
            };

            int currentRow = 4;
            int currentColumnt = 1;

            PrivateType pt = new PrivateType(typeof(WalkInMatrix));
            bool canContinue = ((bool)pt.InvokeStatic("CanContinue", new object[] { testMatrix, currentRow, currentColumnt }));

            Assert.IsTrue(canContinue);
        }

        [TestMethod]
        [Timeout(100)]
        [DeploymentItem("RotatingWalkInMatrix.exe")]
        public void CheckDirectionTest_TopRight_RightTriangle()
        {
            int[,] testMatrix =
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 0, 32, 4, 25, 23 },
                { 12, 35, 34, 33, 5, 24 },
                { 11, 10, 9, 8, 7, 6 },
            };

            int currentRow = 3;
            int currentColumnt = 1;

            PrivateType pt = new PrivateType(typeof(WalkInMatrix));
            bool canContinue = ((bool)pt.InvokeStatic("CanContinue", new object[] { testMatrix, currentRow, currentColumnt }));

            Assert.IsFalse(canContinue);
        }
    }
}