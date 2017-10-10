namespace SortingsProject.Sortings.Swap
{
  public interface ISwap<TFirst, TSecond>
  {
    void Swap(ref TFirst first, ref TSecond second);
  }
}
