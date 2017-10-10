namespace SortingsProject.Sortings.Swap
{
  public class SwapSorting : ISwap<int, int>
  {
    public void Swap(ref int first, ref int second)
    {
      var temporary = first;
      first = second;
      second = temporary;
    }
  }
}
