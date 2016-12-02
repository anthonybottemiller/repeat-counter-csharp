namespace RepeatCounter
{
  public class RepeatCounter
  {
    private int _wordCount = 0;
    public int Count(string inputString, string comparisonString)
    {
      string[] words = inputString.Split();
      foreach (string word in words)
      {
        if (word == comparisonString)
        {
          _wordCount++;
        }
      }
      return _wordCount;
    }
  }
}