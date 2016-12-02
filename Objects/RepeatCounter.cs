namespace RepeatCounter
{
  public class RepeatCounter
  {
    private int _wordCount = 0;
    public int Count(string inputString, string comparisonString)
    {
      if (inputString == comparisonString)
      {
        _wordCount++;
      }
      return _wordCount;
    }
  }
}