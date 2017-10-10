namespace SortingsProject.Sortings.Print
{
  public interface IPrint<in TParam>
  {
    void Print(TParam param);
  }
}
