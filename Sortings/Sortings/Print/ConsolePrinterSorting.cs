using System;

namespace SortingsProject.Sortings.Print
{
  public class ConsolePrinterSorting : IPrint<int[]>
  {
    public void Print(int[] array)
    {
      foreach (int t in array)
        Console.Write(t + " ");

      Console.WriteLine("\n");
    }
  }
}
