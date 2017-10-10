using System;
using System.Linq;
using System.Threading;

namespace SortingsProject.Sortings.Print
{
  public class ConsolePrinterGraphSorting : IPrint<int[]>
  {
    public void Print(int[] array)
    {
      Thread.Sleep(200);

      Console.Clear();
      Console.WriteLine();

      var maxValue = array.Max();
      var count = array.Length;
      int[,] matrix = new int[maxValue, count];

      for (int i = maxValue - 1; i >= 0; i--)
      {
        var idx = count - 1;
        for (int j = count - 1; j >= 0; j--)
        {
          var value = maxValue - array[idx];
          if (value <= i)
            matrix[i, j] = 1;
          else
            matrix[i, j] = 0;

          idx--;
        }
      }

      for (int i = 0; i < maxValue; i++)
      {
        for (int j = 0; j < count; j++)
          Console.Write(matrix[i, j] == 0 ? "   " : " _ ");

        Console.WriteLine("\n");
      }
    }
  }
}
