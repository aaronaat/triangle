using System;

namespace Triangle {

  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Enter side one: ");
      string stringSideOne = Console.ReadLine();
      int one = int.Parse(stringSideOne);

      Console.WriteLine("Enter side two: ");
      string stringSideTwo = Console.ReadLine();
      int two = int.Parse(stringSideTwo);

      Console.WriteLine("Enter side three: ");
      string stringSideThree = Console.ReadLine();
      int three = int.Parse(stringSideThree);

      Tri check = new Tri(one, two, three);

      if (check.GetSideOne() + check.GetSideTwo() < check.GetSideThree())
      {
        Console.WriteLine("Not a triangle!");
      }

      if (check.GetSideOne() + check.GetSideThree() < check.GetSideTwo())
      {
        Console.WriteLine("Not a triangle!");
      }

      if (check.GetSideTwo() + check.GetSideThree() < check.GetSideTwo())
      {
        Console.WriteLine("Not a triangle!");
      }

      if (check.GetSideOne() == check.GetSideTwo() && check.GetSideTwo() == check.GetSideThree())
      {
        Console.WriteLine("Equilateral!");
      }

      else if ((check.GetSideOne() == check.GetSideTwo()) || (check.GetSideTwo() == check.GetSideThree()) || (check.GetSideOne() == check.GetSideThree()))
      {
        Console.WriteLine("Isosceles!");
      }
      else
      {
        Console.WriteLine("Scalene!");
      }
    }
  }
}
