namespace RepeatCounter
{
  public class RepeatCounter
  {
    private string _inputString;
    private string _comparisonString;
    private int _wordCount = 0;
    public RepeatCounter(string inputString, string comparisonString)
    {
      _inputString = inputString;
      _comparisonString = comparisonString;
    }
    public int Count()
    {
      string[] words = _inputString.Split(' ');
      foreach (string word in words)
      {
        if (word == _comparisonString)
        {
          _wordCount++;
        }
      }
      return _wordCount;
    }
  }
}