namespace SortingsProject.Sortings
{
  public interface ISorting<in TArray>
  {
    void BeginSorting(TArray array);
  }
}
