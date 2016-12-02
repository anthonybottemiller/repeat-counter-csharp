using Xunit;
namespace RepeatCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounter_ForTwoWordsThatDontMatch_0()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("c#","java");
      Assert.Equal(0, testRepeatCounter.CountRepeats());
    }
    [Fact]
    public void RepeatCounter_ForTwoWordsThatMatch_1()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("c#","c#");
      Assert.Equal(1, testRepeatCounter.CountRepeats());
    }
    [Fact]
    public void RepeatCounter_ForManyThatMatch_2()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("c# c#","c#");
      Assert.Equal(2, testRepeatCounter.CountRepeats());
    }
  }
}