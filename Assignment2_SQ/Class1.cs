using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace Assignment2_SQ
{
    [TestFixture]
    public class Class1
    {
        // Valid Equilateral Triangle
        [Test]
        public void Triangle_InputThreeEqualSides_OutputEquilateral()
        {
            // Arrange
            int sideA = 5, sideB = 5, sideC = 5;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Equilateral triangle", result);
        }

        // Valid Isosceles Triangles
        [Test]
        public void Triangle_TwoEqualSides_OutputIsosceles()
        {
            // Arrange
            int sideA = 5, sideB = 5, sideC = 3;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void Triangle_TwoOtherEqualSides_OutputIsosceles()
        {
            // Arrange
            int sideA = 5, sideB = 3, sideC = 5;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void Triangle_BaseAndHeightEqual_OutputIsosceles()
        {
            // Arrange
            int sideA = 3, sideB = 5, sideC = 5;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }
    }
}
