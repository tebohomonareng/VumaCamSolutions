using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

//Test class that will be used
[TestClass]
public class ShapeTests
{
    //Test method for the Triangle class
    [TestMethod]
    public void TriangleTest()
    {
        Triangle triangle = new Triangle(@base: 3, height: 6);
        double expectedArea = 0.5 * 3 * 6;

        //Checking the calculated result and expected result
        Assert.AreEqual(expectedArea, triangle.Area());
    }

    [TestMethod]
    //Test method for the Square class
    public void SquareAreaTest()
    {
        Square square = new Square(sideLength: 4);

        //Calculate expected result
        //The 'Math.Pow' function calulates the sqaure of a number, in this case
        double expectedArea = Math.Pow(4, 2);

        //Checking the calculated result and expected result
        Assert.AreEqual(expectedArea, square.Area());
    }

    [TestMethod]
    //Test method for the Circle class
    public void CircleTest()
    {
        //Create new instance
        Circle circle = new Circle(radius: 5);

        //Calculate expected result
        double expectedArea = Math.PI * Math.Pow(5, 2);

        //Checking the calculated result and expected result
        Assert.AreEqual(expectedArea, circle.Area(), delta: 0.001);
    }
    
    //Edge cases
    //Testing with a Triangle base of 0
    [TestMethod]
    public void TriangleTestZeroBase()
    {
        Triangle triangle = new Triangle(@base: 0, height: 6);

        //Checking the calculated result and expected result
        Assert.AreEqual(0, triangle.Area());
    }

    //Testing with a Triangle height of 0
    [TestMethod]
    public void TriangleZeroHeight()
    {
        Triangle triangle = new Triangle(@base: 3, height: -1);

        //Checking the calculated result and expected result
        Assert.AreEqual(0, triangle.Area());
    }

    //Testing with a Circle radius of -1
    [TestMethod]
    public void CircleNegativeRadius()
    {
        // Arrange: Attempt to create a Circle instance with a negative radius
        Circle circle = new Circle(radius: -1);

        // Act: Call the Area method (this should throw an exception)
        double actualArea = circle.Area();

        // Assert: This method should not be reached due to the expected exception
        Assert.AreEqual(-1, actualArea);
    }
}
