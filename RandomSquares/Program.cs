using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquares
{
  class Program
  {
    static void Main(string[] args)
    {
      Random rnd = new Random();
      var randomList = new List<int>();
      for (var ctr = 1; ctr <= 20; ctr++)
      {
        randomList.Add(rnd.Next(1, 50));
      }

      foreach (var rando in randomList)
      {
        Console.WriteLine(rando);
      }
      Console.WriteLine("*********************");
      var squaredList = randomList.Select(num => num * num).ToList();
      squaredList.RemoveAll(numb => numb % 2 != 0);
      foreach (var sqRnd in squaredList)
      {
        Console.WriteLine(sqRnd);
      }

    }
  }
}
