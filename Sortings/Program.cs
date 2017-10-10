using System;
using SortingsProject.Sortings;
using SortingsProject.Sortings.Print;
using SortingsProject.Sortings.Swap;

namespace SortingsProject
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] someArray = { 6, 8, 4, 7, 11, 5, 10, 9, 1, 2, 3 };

      BubbleSorting bubbleSorting = new BubbleSorting(new ConsolePrinterGraphSorting(), new SwapSorting());
      bubbleSorting.BeginSorting(someArray);

      Console.ReadLine();
      someArray = new[] { 6, 8, 4, 7, 11, 5, 10, 9, 1, 2, 3 };

      ShakerSorting shakerSorting = new ShakerSorting(new ConsolePrinterGraphSorting(), new SwapSorting());
      shakerSorting.BeginSorting(someArray);

      Console.ReadLine();
    }
  }
}
