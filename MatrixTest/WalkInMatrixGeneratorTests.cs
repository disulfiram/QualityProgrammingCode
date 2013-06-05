using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotatingWalkInMatrix;

namespace MatrixTest
{
    [TestClass]
    public class WalkInMatrixGeneratorTests
    {
        [TestMethod]
        [DeploymentItem("RotatingWalkInMatrix.exe")]
        public void GenerateMatrix_Input6Correct()
        {
            int n = 6;
            int[,] expected = 
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 36, 32, 4, 25, 23 },
                { 12, 35, 34, 33, 5, 24 },
                { 11, 10, 9, 8, 7, 6 },
            };

            PrivateType pt = new PrivateType(typeof(WalkInMatrica));
            int[,] actual = (int[,])pt.InvokeStatic("WalkInMatrixGenerator", new object[] { n });

            bool areEqual = AreMatricesEqual(actual, expected);
            Assert.AreEqual(areEqual, true);
        }

        [TestMethod]
        [DeploymentItem("RotatingWalkInMatrix.exe")]
        public void GenerateMatrix_Input6Incorrect()
        {
            int n = 6;
            int[,] expected = 
            {
                { 0, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 36, 32, 4, 25, 23 },
                { 12, 35, 34, 33, 5, 24 },
                { 11, 10, 9, 8, 7, 6 },
            };

            PrivateType pt = new PrivateType(typeof(WalkInMatrica));
            int[,] actual = (int[,])pt.InvokeStatic("WalkInMatrixGenerator", new object[] { n });

            bool areEqual = AreMatricesEqual(actual, expected);
            Assert.AreEqual(areEqual, false);
        }

        private bool AreMatricesEqual(int[,] actual, int[,] expected)
        {
            bool result = true;
            int matrixSize = actual.GetLength(1);

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (actual[row, col] != expected[row, col])
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}