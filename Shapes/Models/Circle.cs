using System;
namespace Shapes.Models
{
  public class Circle
  {
    public double Circumference { get; set; }
    public double Diameter { get; set; }
    public double PI = 3.14;
    public double Radius;
    

    public Circle(double radius)
    {
      Radius = radius;
      Diameter = radius * radius * 2;
      Circumference = 2 * PI * Radius;
    }
  }
}