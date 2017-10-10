using System.Linq;
using SortingsProject.Sortings.Print;
using SortingsProject.Sortings.Swap;

namespace SortingsProject.Sortings
{
  public class ShakerSorting : ISorting<int[]>, ISwap<int, int>, IPrint<int[]>
  {
    public static IPrint<int[]> Printer { get; private set; }
    public static ISwap<int, int> Swaper { get; private set; }

    public ShakerSorting(IPrint<int[]> printer, ISwap<int, int> swaper)
    {
      Printer = printer;
      Swaper = swaper;
    }

    public void BeginSorting(int[] array)
    {
      if (array == null) return;

      Printer.Print(array);

      var count = array.Count();
      int left = 1;
      int right = count - 1;

      while (left <= right)
      {
        bool isSwap = false;

        for (int i = right; i >= left; i--)
        {
          if (array[i - 1] <= array[i]) continue;

          Swap(ref array[i - 1], ref array[i]);
          isSwap = true;
          
          Print(array);
        }
        
        left++;

        for (int i = left; i <= right; i++)
        {
          if (array[i - 1] <= array[i]) continue;

          Swap(ref array[i - 1], ref array[i]);
          isSwap = true;
          
          Print(array);
        }
        
        right--;

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
