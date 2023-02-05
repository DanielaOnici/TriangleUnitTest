using TriangleSolver;
using NUnit;

namespace TriangleTests
{
    public class Tests
    {


        [Test]
        public void ValidEquilateral_Input5and5and5_outputIsAnEquilateral()
        {
            //Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 5;

            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

            //Act
            Triangle triangleTest = new Triangle();
            string output = triangleTest.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            //Assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ValidIsoscelesTriangle_Input10and10and5_outputIsAnIsosceles()
        {
            //Arrange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 5;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            Triangle triangleTest = new Triangle();
            string output = triangleTest.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            //Assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ValidIsoscelesTriangle_Input20and15and20_outputIsAnIsosceles()
        {
            //Arrange
            int firstSide = 20;
            int secondSide = 15;
            int thirdSide = 20;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            Triangle triangleTest = new Triangle();
            string output = triangleTest.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            //Assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ValidIsoscelesTriangle_Input3and9and9_outputIsAnIsosceles()
        {
            //Arrange
            int firstSide = 3;
            int secondSide = 9;
            int thirdSide = 9;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            Triangle triangleTest = new Triangle();
            string output = triangleTest.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            //Assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ValidScaleneTriangle_Input13and9and14_outputIsAScalene()
        {
            //Arrange
            int firstSide = 13;
            int secondSide = 9;
            int thirdSide = 14;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            Triangle triangleTest = new Triangle();
            string output = triangleTest.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            //Assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ValidScaleneTriangle_Input20and22and10_outputIsAScalene()
        {
            //Arrange
            int firstSide = 20;
            int secondSide = 22;
            int thirdSide = 10;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            Triangle triangleTest = new Triangle();
            string output = triangleTest.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            //Assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ValidScaleneTriangle_Input20and42and40_outputIsAScalene()
        {
            //Arrange
            int firstSide = 20;
            int secondSide = 42;
            int thirdSide = 40;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            Triangle triangleTest = new Triangle();
            string output = triangleTest.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            //Assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ValidScaleneTriangle_Input5and7and6_outputIsAScalene()
        {
            //Arrange
            int firstSide = 5;
            int secondSide = 7;
            int thirdSide = 6;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            Triangle triangleTest = new Triangle();
            string output = triangleTest.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            //Assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ValidScaleneTriangle_Input3and9and10_outputIsAScalene()
        {
            //Arrange
            int firstSide = 3;
            int secondSide = 9;
            int thirdSide = 10;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            Triangle triangleTest = new Triangle();
            string output = triangleTest.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            //Assert
            Assert.AreEqual(expected, output);
        }
    }
}