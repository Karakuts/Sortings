using System.Linq;
using SortingsProject.Sortings.Print;
using SortingsProject.Sortings.Swap;

namespace SortingsProject.Sortings
{
  public class BubbleSorting : ISorting<int[]>, ISwap<int, int>, IPrint<int[]>
  {
    public static IPrint<int[]> Printer { get; private set; }
    public static ISwap<int, int> Swaper { get; private set; }

    public BubbleSorting(IPrint<int[]> printer, ISwap<int, int> swaper)
    {
      Printer = printer;
      Swaper = swaper;
    }

    public void BeginSorting(int[] array)
    {
      if (array == null) return;

      Print(array);

      var count = array.Count();
      for (int i = 0; i < count; i++)
      {
        bool isSwap = false;

        for (int j = 0; j < count - 1 - i; j++)
        {
          if (array[j] > array[j + 1])
          {
            Swap(ref array[j], ref array[j + 1]);
            isSwap = true;
            
            Print(array);
          }
        }

        if (!isSwap)
          break;
      }
    }

    public void Swap(ref int first, ref int second)
    {
      Swaper.Swap(ref first, ref second);
    }
    public void Print(int[] param)
    {
      Printer.Print(param);
    }
  }
}
