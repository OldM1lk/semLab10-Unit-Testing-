using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverloadingOperations;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AdditionTest()
        {
            int matrixSize = 3;
            SquareMatrix matrix1 = new SquareMatrix(matrixSize);
            SquareMatrix matrix2 = new SquareMatrix(matrixSize);
            SquareMatrix actualResult = new SquareMatrix(matrixSize);
            SquareMatrix expectedResult = new SquareMatrix(matrixSize);

            matrix1.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            matrix2.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            expectedResult.matrix = new int[,] { { 2, 4, 6 }, { 8, 10, 12 }, { 14, 16, 18 } };
            actualResult = matrix1 + matrix2;
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            int matrixSize = 3;
            SquareMatrix matrix1 = new SquareMatrix(matrixSize);
            SquareMatrix matrix2 = new SquareMatrix(matrixSize);
            SquareMatrix actualResult = new SquareMatrix(matrixSize);
            SquareMatrix expectedResult = new SquareMatrix(matrixSize);

            matrix1.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            matrix2.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            expectedResult.matrix = new int[,] { { 30, 36, 42 }, { 66, 81, 96 }, { 102, 126, 150 } };
            actualResult = matrix1 * matrix2;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DeterminantTest()
        {
            int matrixSize = 3;
            int expectedResult = 0;
            int actualResult;
            SquareMatrix matrix = new SquareMatrix(matrixSize);

            matrix.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            actualResult = matrix.Determinant();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void InverseTest()
        {
            int matrixSize = 3;
            SquareMatrix matrix = new SquareMatrix(matrixSize);
            SquareMatrix actualResult = new SquareMatrix(matrixSize);
            SquareMatrix expectedResult = new SquareMatrix(matrixSize);

            matrix.matrix = new int[,] { { 1, -2, 1 }, { 2, 1, -1 }, { 3, 2, -2 } };
            expectedResult.matrix = new int[,] { { 0, 2, -1 }, { -1, 5, -3 }, { -1, 8, -5 } };
            actualResult = matrix.Inverse();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MoreTest()
        {
            int matrixSize = 3;
            SquareMatrix matrix1 = new SquareMatrix(matrixSize);
            SquareMatrix matrix2 = new SquareMatrix(matrixSize);
            bool actualResult;
            bool expectedResult = false;

            matrix1.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            matrix2.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            actualResult = matrix1 > matrix2;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LessTest()
        {
            int matrixSize = 3;
            SquareMatrix matrix1 = new SquareMatrix(matrixSize);
            SquareMatrix matrix2 = new SquareMatrix(matrixSize);
            bool actualResult;
            bool expectedResult = false;

            matrix1.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            matrix2.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            actualResult = matrix1 < matrix2;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MoreOrEqualTest()
        {
            int matrixSize = 3;
            SquareMatrix matrix1 = new SquareMatrix(matrixSize);
            SquareMatrix matrix2 = new SquareMatrix(matrixSize);
            bool actualResult;
            bool expectedResult = true;

            matrix1.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            matrix2.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            actualResult = matrix1 >= matrix2;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LessOrEqual()
        {
            int matrixSize = 3;
            SquareMatrix matrix1 = new SquareMatrix(matrixSize);
            SquareMatrix matrix2 = new SquareMatrix(matrixSize);
            bool actualResult;
            bool expectedResult = true;

            matrix1.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            matrix2.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            actualResult = matrix1 <= matrix2;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EqualTest()
        {
            int matrixSize = 3;
            SquareMatrix matrix1 = new SquareMatrix(matrixSize);
            SquareMatrix matrix2 = new SquareMatrix(matrixSize);
            bool actualResult;
            bool expectedResult = true;

            matrix1.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            matrix2.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            actualResult = matrix1 == matrix2;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void NotEqualTest()
        {
            int matrixSize = 3;
            SquareMatrix matrix1 = new SquareMatrix(matrixSize);
            SquareMatrix matrix2 = new SquareMatrix(matrixSize);
            bool actualResult;
            bool expectedResult = false;

            matrix1.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            matrix2.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            actualResult = matrix1 != matrix2;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void NullTest()
        {
            int matrixSize = 3;
            SquareMatrix matrix = new SquareMatrix(matrixSize);
            bool actualResult;
            bool expectedResult = false;

            matrix.matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            actualResult = matrix.IsMatrixNull();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}