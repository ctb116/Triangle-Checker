using System;

class TriangleCheck
{
  static void Main()
  {
    Console.WriteLine("Find out what type of triangle you have");
    Console.WriteLine("Enter first side length");
    int firstSide = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter second side length");
    int secondSide = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter third side length");
    int thirdSide = int.Parse(Console.ReadLine());

    if (firstSide > (secondSide + thirdSide) || secondSide > (firstSide + thirdSide) || thirdSide > (firstSide + secondSide))
    {
      Console.WriteLine("This is not a triangle");
    }
    // else if ()
    // {
    //
    // }
  }
}

// read line number - 2 times INT
// side one side two side three
// if side one equals side two then isosceles
// if side one two and three equal then equailateral
// else scalene no sides are equal
