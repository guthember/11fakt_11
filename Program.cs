using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
  class Program
  {
    static void Main(string[] args)
    {
      //int szam = 10;
      // 10 egész szám tárolására alkalmas
      int[] tomb = new int[5];
      Random vel = new Random();

      Console.WriteLine("A tömb elemeinek száma: " + tomb.Length);

      for (int i = 0; i < tomb.Length; i++)
      {
        tomb[i] = vel.Next(1, 5); // [1-100]    
      }

      for (int i = 0; i < tomb.Length; i++)
      {
        if (i % 10 == 0 && i != 0)
        {
          Console.WriteLine();
        }
        Console.Write(tomb[i].ToString().PadLeft(5));
      }

      int min = tomb[0]; // feltételezzük
      for (int i = 1; i < tomb.Length; i++)
      {
        if (min > tomb[i])
        {
          min = tomb[i];
        }
      }

      int max = tomb[0];
      for (int i = 1; i < tomb.Length; i++)
      {
        if (max < tomb[i])
        {
          max = tomb[i];
        }
      }

      int osszeg = 0;

      for (int i = 0; i < tomb.Length; i++)
      {
        osszeg = osszeg + tomb[i];
      }

      Console.WriteLine();
      Console.WriteLine("A legkisebb elem: " + min);
      Console.WriteLine("A legnagyobb elem: " + max);
      Console.WriteLine("Az elemek összege: " + osszeg);
      Console.ReadKey();
    }
  }
}
