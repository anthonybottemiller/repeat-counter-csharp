using Xunit;
namespace RepeatCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounter_ForTwoWordsThatDontMatch_0()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(0, testRepeatCounter.CountRepeats("c#","java"));
    }
    [Fact]
    public void RepeatCounter_ForTwoWordsThatMatch_1()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(1, testRepeatCounter.CountRepeats("c#","c#"));
    }
    [Fact]
    public void RepeatCounter_ForManyThatMatch_2()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(2, testRepeatCounter.CountRepeats("c# c#","c#"));
    }
    [Fact]
    public void RepeatCounter_ForManyThatMatchOneNoMatch_2()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(2, testRepeatCounter.CountRepeats("c# c# python","c#"));
    }
    [Fact]
    public void RepeatCounter_ForManyThatMatchAndManyDontMatch_2()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(2, testRepeatCounter.CountRepeats("python c# c# python","c#"));
    }
    [Fact]
    public void RepeatCounter_ForManyThatMatchAndManyDontMatchWithPunctuation_2()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(2, testRepeatCounter.CountRepeats("python c#, c#, python","c#"));
    }
  }
}