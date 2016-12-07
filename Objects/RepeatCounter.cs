namespace RepeatCounter
{
  public class RepeatCounter
  {
    private string _inputString;
    private string _comparisonString;
    private int _wordCount = 0;
    public int GetWordCount()
    {
      return _wordCount;
    }    
    public int CountRepeats(string inputString, string comparisonString)
    {
      string[] words = inputString.ToLower().Split(' ');
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