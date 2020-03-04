using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTests
  {
    [TestMethod]
    public void Circle_GetRadius_VolumeOfCube_Radius()
    {
      // Arrange
      Circle newCircle = new Circle(5);
      // Act
      double result = newCircle.Circumference;
      // Assert
      Assert.AreEqual(result, 31.4);
    }
  }
}